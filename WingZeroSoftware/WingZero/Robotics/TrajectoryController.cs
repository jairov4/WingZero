using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using System.ComponentModel;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;

namespace WingZero.Robotics
{
	public class TrajectoryController : DrawableGameComponent
	{
		public Robot Robot { get; protected set; }
		public InverseKinematicsSolver IKSolver { get; set; }		
		public List<TrajectoryPoint> Trajectory { get; set; }
		public BasicEffect Effect { get; set; }
		public Matrix World { get; set; }
		public Matrix View { get; set; }
		public Matrix Projection { get; set; }
		public TimeSpan Time { get; set; }
				
		public TrajectoryController(Game game, Robot robot, InverseKinematicsSolver iksolver)
			: base(game)
		{
			Robot = robot;
			IKSolver = iksolver;
			Time = new TimeSpan(0);
			Trajectory = new List<TrajectoryPoint>();			
		}

		public TimeSpan TotalTime
		{
			get
			{
				if(Trajectory.Count < 2) return new TimeSpan(0);
				else return Trajectory.Max(x => x.t);
			}
		}

		protected override void LoadContent()
		{
			Effect = new BasicEffect(GraphicsDevice);
			Effect.VertexColorEnabled = true;			
			base.LoadContent();
		}
		
		public override void Update(GameTime gameTime)
		{					
			if (!Enabled || Trajectory.Count < 2) return;
			Time += gameTime.ElapsedGameTime;
			Vector3 v = GetFinalEffector(Time);
			IKSolver.TargetPosition = v;
			InverseKinematicsSolution sol = IKSolver.ProcessSolution(Robot.GetStatus());
			Robot.SetStatus(sol.Status);
			base.Update(gameTime);	
		}

		public Vector3 GetFinalEffector(TimeSpan t)
		{
			TrajectoryPoint p0 = Trajectory.Where(x => x.t < t).OrderByDescending(x => x.t).FirstOrDefault();
			TrajectoryPoint p1 = Trajectory.Where(x => x.t >= t).OrderBy(x => x.t).FirstOrDefault();
			if (p0 == null) return p1.Position;
			if (p1 == null) return p0.Position;
			float amount = (float)(t - p0.t).Ticks / (float)(p1.t - p0.t).Ticks;
			Vector3 v = Vector3.Lerp(p0.Position, p1.Position, amount);
			return v;
		}

		public override void Draw(GameTime gameTime)
		{
			var VertexList = new List<VertexPositionColor>();
			if (Trajectory.Count() < 2) return;
			var trajectory = Trajectory.OrderBy(x => x.t);
			foreach (TrajectoryPoint point in trajectory)
			{
				VertexList.Add(new VertexPositionColor(point.Position, Color.LightPink));
			}			

			var vbuffer = new VertexBuffer(GraphicsDevice, typeof(VertexPositionColor), trajectory.Count(), BufferUsage.WriteOnly);
			vbuffer.SetData<VertexPositionColor>(VertexList.ToArray());
			GraphicsDevice.SetVertexBuffer(vbuffer);
			var decl = VertexPositionColor.VertexDeclaration;
			
			Effect.World = World;
			Effect.View = View;
			Effect.Projection = Projection;
			foreach (var pass in Effect.CurrentTechnique.Passes)
			{
				pass.Apply();
				GraphicsDevice.DrawPrimitives(PrimitiveType.LineStrip, 0, VertexList.Count - 1);
			}

			base.Draw(gameTime);
		}
	}

	[XmlRoot("TrajectoryPoint")]
	public class TrajectoryPoint
	{
		Vector3 position = new Vector3();		

		[Browsable(false)]
		[XmlIgnore]
		public Vector3 Position { get { return position; } set { position = value; } }
		[XmlIgnore]
		public TimeSpan t { get; set; }		
		[XmlAttribute]
		[Browsable(false)]
		public int TimeMiliseconds { get { return (int)t.TotalMilliseconds; } set { t = new TimeSpan(0, 0, 0, 0, value); } }
		[XmlAttribute]
		public float X { get { return Position.X; } set { position.X = value; } }
		[XmlAttribute]
		public float Y { get { return Position.Y; } set { position.Y = value; } }
		[XmlAttribute]
		public float Z { get { return Position.Z; } set { position.Z = value; } }
	}
}
