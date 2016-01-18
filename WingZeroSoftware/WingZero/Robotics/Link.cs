using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WingZero.Robotics
{
	[XmlRoot("Link")]
	[ListBindable(true)]
	public class Link 
	{		
		public Link()
		{
			AxisMeshZ = "AxisZ";
			AxisMeshX = "AxisX";
			ModelDistanceScaleFactor = 0.4f;
		}

		[Category("General")]
		public string Name { get; set; }

		[Category("Display")]
		public string AxisMeshZ { get; set; }
		
		[Category("Display")]
		public string AxisMeshX { get; set; }

		[Category("Display")]
		[XmlIgnore]
		public Model Model { get; set; }

		[Category("Display")]
		public string ModelPath { get; set; }

		[Category("Display")]
		public float ModelDistanceScaleFactor { get; set; }
		
		[Category("DH Parameters")]
		public LinkType Type { get { return _Type; } set { _Type = value; Value = FixLimit(Value); } }
		LinkType _Type;

		[Category("DH Parameters")]
		public float DistanceZ { get; set; }

		[Category("DH Parameters")]
		[Description("Angulo Z en grados radianes")]
		public float AngleZ { get; set; }

		[Category("DH Parameters")]
		[Description("Angulo Z en grados sexagesimales")]
		[DisplayName("Angle Z - Grados")]
		public float AngleZD { get { return MathHelper.ToDegrees(AngleZ); } }

		[Category("DH Parameters")]
		[Description("Angulo X en grados radianes")]
		public float AngleX { get; set; }

		[Category("DH Parameters")]
		[Description("Angulo X en grados sexagesimales")]
		[DisplayName("Angle X - Grados")]
		public float AngleXD { get { return MathHelper.ToDegrees(AngleX); } }

		[Category("DH Parameters")]
		public float DistanceX { get; set; }

		[Category("DH Parameters Edit Mode")]
		public float MaxValue { get; set; }

		[Category("DH Parameters Edit Mode")]
		public float MinValue { get; set; }

		[Category("DH Parameters Edit Mode")]
		public float? Default { get; set; }
		
		[Category("DH Parameters Edit Mode")]
		[DataObjectField(false)]
		public float Value
		{
			get
			{
				switch (Type)
				{
					case LinkType.Fixed:
						return 0.0f;
					case LinkType.Prismatic:
						return DistanceZ;
					case LinkType.Rotative:
						return AngleZ;
					default:
						return 0.0f;
				}
			}
			set
			{
				switch (Type)
				{
					case LinkType.Fixed:						
						break;
					case LinkType.Prismatic:
						DistanceZ = value;
						break;
					case LinkType.Rotative:
						AngleZ = value;
						break;
					default:						
						break;
				}
			}
		}

		public Matrix Eval(float param)
		{
			return GetMatrixM2(param);
		}

		private Matrix GetMatrixM2(float param)
		{
			double ct = Math.Cos(Type == LinkType.Rotative ? param : AngleZ);
			double st = Math.Sin(Type == LinkType.Rotative ? param : AngleZ);
			double ca = Math.Cos(AngleX);
			double sa = Math.Sin(AngleX);
			double a = DistanceX;
			double d = Type == LinkType.Prismatic ? param : DistanceZ;
			float st_ca = (float)(st * ca);
			float ct_ca = (float)(ct * ca);
			float st_sa = (float)(st * sa);
			float ct_sa = (float)(ct * sa);
			float ct_a = (float)(ct * a);
			float st_a = (float)(st * a);

			Matrix m = new Matrix(
				(float)ct, (float)st, 0, 0,
				-st_ca, ct_ca, (float)sa, 0,
				st_sa, -ct_sa, (float)ca, 0,
				ct_a, st_a, (float)d, 1.0f
				);
			return m;
		}

		private Matrix GetMatrixM1(float param)
		{
			Matrix m1 = Matrix.CreateRotationZ(Type == LinkType.Rotative ? param : AngleZ);
			Matrix m2 = Matrix.CreateTranslation(0.0f, 0.0f, Type == LinkType.Prismatic ? param : DistanceZ);
			Matrix m3 = Matrix.CreateTranslation(DistanceX, 0.0f, 0.0f);
			Matrix m4 = Matrix.CreateRotationX(AngleX);
			return m4 * m3 * m2 * m1;
		}

		[Category("Status")]
		public Matrix Transformation
		{
			get
			{
				return Eval(Value);
			}
		}

		public bool IsValidValue(float v)
		{
			if (v > MaxValue || v < MinValue)
			{
				return false;
			}
			return true;
		}

		public float FixLimit(float v)
		{
			if (IsValidValue(v)) return v;
			float d1 = Math.Abs(v - MaxValue);
			float d2 = Math.Abs(v - MinValue);
			if (d1 < d2)
			{
				return MaxValue;
			}
			else
			{
				return MinValue;
			}
		}

		public void Reset() 
		{
			if (Default == null)
			{
				Value = (MaxValue - MinValue) / 2.0f + MinValue;
			}
			else
			{
				Value = (float)Default;
			}
		}

		public void Draw(Matrix transform, Matrix View, Matrix Projection)
		{
			// Copy any parent transforms.

			Matrix[] transforms = new Matrix[Model.Bones.Count];
			Model.CopyAbsoluteBoneTransformsTo(transforms);

			// Draw the model. A model can have multiple meshes, so loop.
			foreach (ModelMesh mesh in Model.Meshes)
			{
				Matrix variable = Matrix.Identity;
				if (mesh.Name == AxisMeshZ)
				{					
					Matrix m1 = Matrix.CreateRotationZ(AngleZ);
					Matrix m2 = Matrix.CreateScale(1.0f, 1.0f, DistanceZ * ModelDistanceScaleFactor);
					variable = m2 * m1;
				} 
				else if (mesh.Name == AxisMeshX)
				{
					Matrix m1 = Matrix.CreateRotationZ(AngleZ);
					Matrix m2 = Matrix.CreateTranslation(0.0f, 0.0f, DistanceZ);
					Matrix m3 = Matrix.CreateRotationX(AngleX);
					Matrix mf = Matrix.CreateRotationZ(DistanceX < 0.0f ? MathHelper.PiOver2 : 0.0f);
					Matrix m4 = Matrix.CreateScale(Math.Abs(DistanceX) * ModelDistanceScaleFactor, 1.0f, 1.0f);
					variable = m4 * mf * m3 * m2 * m1;
				}

				Matrix final = transforms[mesh.ParentBone.Index] * variable * transform;
				// This is where the mesh orientation is set, as well as our camera and projection.
				foreach (BasicEffect effect in mesh.Effects)
				{
					effect.EnableDefaultLighting();
					effect.World = final;
					effect.View = View;
					effect.Projection = Projection;
				}
				// Draw the mesh, using the effects set above.
				mesh.Draw();
			}
		}

		public enum LinkType
		{
			Fixed, Prismatic, Rotative
		}

	}

}
