using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.ComponentModel;
using System.Xml.Serialization;

namespace WingZero.Robotics
{
	[XmlRoot("Robot")]
	public class Robot 
	{
		public Robot()
		{
			Chain = new List<Link>();
			AxisHelperScale = 1.0f;
		}

		[Category("General")]
		public List<Link> Chain { get; set; }

		[Category("General")]
		public string Name { get; set; }

		[Category("Display")]
		[XmlIgnore]
		public Model AxisHelperModel { get; set; }

		[Category("Display")]
		public bool ShowAxisHelper { get; set; }

		[Category("Display")]
		public float AxisHelperScale { get; set; }
				
		[Category("Status")]
		[XmlIgnore]
		public Vector3 FinalEffector
		{
			get
			{
				Matrix t = Matrix.Identity;
				foreach (Link node in Chain)
				{
					t = node.Transformation * t;
				}
				return t.Translation;
			}
		}

		public void Reset()
		{
			foreach (Link link in Chain)
			{
				link.Reset();
			}
		}

		public float[] GetRandomState()
		{
			return GetRandomState(new Random());
		}

		public float[] GetRandomState(Random rand)
		{
			float[] initial = new float[Chain.Count];			
			int i = 0;
			foreach (Link node in Chain)
			{
				float f0 = (float)rand.NextDouble()*(node.MaxValue - node.MinValue);
				initial[i++] = f0 + node.MinValue;
			}
			return initial;
		}

		public Vector3 Eval(float[] values)
		{
			Matrix t = Matrix.Identity;
			if (values == null) throw new ArgumentNullException("values");
			if (values.Length != Chain.Count) throw new ArgumentException("Robot State Evaluation: Argument should have same elements as DOFs", "values"); 
			int i = 0;
			foreach (Link node in Chain)
			{
				float param = values[i];
				t = node.Eval(param) * t;
				i++;
			}
			Vector3 v = new Vector3(0, 0, 0);
			return Vector3.Transform(v, t);
		}

		public bool IsValidState(float[] values)
		{
			int i = 0;
			foreach (Link node in Chain)
			{
				float param = values[i];
				if (!node.IsValidValue(param))
				{
					return false;
				}
				i++;
			}
			return true;
		}

		public bool IsLinkValidValue(float value, int link)
		{
			return Chain[link].IsValidValue(value);
		}

		public bool[] CheckLimits(float[] values)
		{
			bool[] re = new bool[values.Length];
			int i = 0;
			foreach (Link node in Chain)
			{
				float param = values[i];
				re[i] = node.IsValidValue(param);				
				i++;
			}
			return re;
		}

		public void FixLimits(float[] values)
		{
			int i = 0;
			foreach (Link node in Chain)
			{
				float param = values[i];
				values[i] = node.FixLimit(param);
				i++;
			}			
		}

		public float[] GetStatus()
		{
			List<float> l = new List<float>();
			foreach (Link node in Chain)
			{
				l.Add(node.Value);
			}
			return l.ToArray();
		}

		public void SetStatus(float[] s)
		{
			int i = 0;
			foreach (Link node in Chain)
			{
				node.Value = s[i];
				i++;
			}
		}
		
		public void Draw(Matrix transform, Matrix view, Matrix projection)
		{
			foreach (Link node in Chain)
			{
				if (ShowAxisHelper && AxisHelperModel != null)
				{
					DrawAxisHelper(transform, view, projection);
				}
				if (node.Model != null)
				{
					node.Draw(transform, view, projection);
				}
				transform = node.Transformation * transform;				
			}
		}

		private void DrawAxisHelper(Matrix transform, Matrix view, Matrix proj)
		{
			// Copy any parent transforms.
			transform = Matrix.CreateScale(AxisHelperScale) * transform;
			DrawModel.Draw(AxisHelperModel, transform, view, proj);
		}

	}
	
}
