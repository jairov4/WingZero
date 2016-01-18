using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WingZero
{
	public class Camera
	{
		public Camera()
		{
			FieldOfView = MathHelper.ToRadians(50.0f);
			NearPlane = 1.0f;
			FarPlane = 10000.0f;
			Up = Vector3.Up;
			Forward = Vector3.Forward;
		}

		public Vector3 Position { get; set; }		
		public float FieldOfView { get; set; }
		public float AspectRatio { get; set; }
		public float NearPlane { get; set; }
		public float FarPlane { get; set; }
		public Vector3 Up { get; set; }
		public Vector3 Forward { get; set; }

		public Matrix GetProjectionMatrix()
		{
			Matrix proj = Matrix.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlane, FarPlane);
			return proj;
		}

		public void TurnLR(float f) 
		{
			Quaternion q = Quaternion.CreateFromAxisAngle(Up, f);
			Quaternion v = new Quaternion(Forward, 0.0f);
			Quaternion qc = q;
			q.Conjugate();
			v = q * v * qc;
			Forward = new Vector3(v.X, v.Y, v.Z);
		}

		public void TurnUD(float f)
		{
			Vector3 axis = Vector3.Cross(Up, Forward);
			Quaternion q = Quaternion.CreateFromAxisAngle(axis, f);
			Quaternion v = new Quaternion(Forward, 0.0f);
			Quaternion qc = q;
			q.Conjugate();
			v = q * v * qc;
			Forward = new Vector3(v.X, v.Y, v.Z);
		}

		public Matrix GetViewMatrix()
		{
			Matrix view = Matrix.CreateLookAt(Position, Position + Forward, Up);			
			return view;
		}

		public void Move(float fb, float lr)
		{
			Vector3 target = Forward;
			target.Normalize();
			Position += target * fb;
			Position += Vector3.Cross(Up, Forward) * lr;
		}
	}
}
