using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.DirectX.DirectInput;
using Microsoft.Xna.Framework.Graphics;

namespace WingZero.Robotics
{
	public class JoystickController : DrawableGameComponent
	{
		public Robot Robot { get; protected set; }
		public InverseKinematicsSolver SoftPassIKSolver { get; set; }
		public InverseKinematicsSolver HardPassIKSolver { get; set; }
		public Device Device { get; set; }
		public Vector3 CurrentPosition { get; protected set; }

		public Matrix World { get; set; }
		public Matrix View { get; set; }
		public Matrix Projection { get; set; }
		Model CursorModel;
		
		public JoystickController(Game game, Robot robot, InverseKinematicsSolver softsolver, InverseKinematicsSolver hardsolver)
			: base(game)
		{
			Robot = robot;
			SoftPassIKSolver = softsolver;
			HardPassIKSolver = hardsolver;
			SetupJoystick();			
		}

		protected override void OnEnabledChanged(object sender, EventArgs args)
		{
			base.OnEnabledChanged(sender, args);
			if (Enabled) CurrentPosition = Robot.FinalEffector;
		}

		private void SetupJoystick()
		{
			DeviceList list = Manager.GetDevices(Microsoft.DirectX.DirectInput.DeviceType.Joystick, EnumDevicesFlags.AttachedOnly);
			System.Diagnostics.Debug.WriteLine(String.Format("Joystick list count: {0}", list.Count));
			if (list.Count > 0)
			{
				while (list.MoveNext())
				{
					// Move to the first device
					DeviceInstance deviceInstance = (DeviceInstance)list.Current;
					try
					{						
						// create a device from this controller.
						Device = new Device(deviceInstance.InstanceGuid);
						System.Diagnostics.Debug.WriteLine(String.Format("Device: {0} / {1}", Device.DeviceInformation.InstanceName, Device.DeviceInformation.ProductName));
						Device.SetCooperativeLevel(Game.Window.Handle, CooperativeLevelFlags.Background | CooperativeLevelFlags.Exclusive);
						// Tell DirectX that this is a Joystick.
						Device.SetDataFormat(DeviceDataFormat.Joystick);
						// Finally, acquire the device.	
						Device.Acquire();
						System.Diagnostics.Debug.WriteLine(String.Format("Device acquired"));
						break;
					}
					catch
					{						
						Device = null;
						System.Diagnostics.Debug.WriteLine(String.Format("Device acquire or data format setup failed"));
					}
				}
			}
		}

		public override void Update(GameTime gameTime)
		{					
			if (!Enabled || Device==null) return;
			Device.Poll();
			byte[] buttons = Device.CurrentJoystickState.GetButtons();
			if (buttons[0] > 127)
			{
				SynchronizeToRealCursor();
			}
			if (buttons[1] > 127)
			{
				SynchronizeToLogicCursor();
			}			
			Vector3 v = GetFinalEffector(gameTime.ElapsedGameTime);
			CurrentPosition = v;
			SoftPassIKSolver.TargetPosition = v;
			InverseKinematicsSolution sol = SoftPassIKSolver.ProcessSolution(Robot.GetStatus());
			if (sol.VectorError.LengthSquared() < (CurrentPosition - Robot.FinalEffector).LengthSquared())
			{
				Robot.SetStatus(sol.Status);
			}
			base.Update(gameTime);	
		}

		public Vector3 GetFinalEffector(TimeSpan t)
		{
			if (Device == null)
			{
				return Robot.FinalEffector;
			}			
			Vector3 force = new Vector3();
			int[] slider = Device.CurrentJoystickState.GetSlider();
			force.X = GetAxis(Device.CurrentJoystickState.X);
			force.Y = -GetAxis(Device.CurrentJoystickState.Y);
			force.Z = GetAxis(65535 - slider[0]);
			byte[] btns = Device.CurrentJoystickState.GetButtons();
			if (btns[2] > 127)
			{
				force.Z += 0.6f;
			}
			if (btns[3] > 127)
			{
				force.Z -= 0.6f;
			}
			//System.Diagnostics.Debug.WriteLine(String.Format("X: {0:00000} Y: {1:00000} Z: {2:00000}", Device.CurrentJoystickState.X, Device.CurrentJoystickState.Y, slider[0]));
			//System.Diagnostics.Debug.WriteLine(String.Format("pX: {0:0.0000} pY: {1:0.0000} pz: {2:0.0000}", force.X, force.Y, force.Z));
			return CurrentPosition + force * (float)t.TotalMilliseconds * 0.1f;
		}

		public void SynchronizeToRealCursor()
		{
			CurrentPosition = Robot.FinalEffector;
		}

		public void SynchronizeToLogicCursor()
		{
			HardPassIKSolver.TargetPosition = CurrentPosition;
			InverseKinematicsSolution sol = HardPassIKSolver.ProcessSolution(Robot.GetStatus());
			Robot.SetStatus(sol.Status);
		}

		private static float GetAxis(int axis)
		{
			float axisOut = 0.0f;
			int deadband = 2000;
			if (axis < (65535 / 2 - deadband) || axis > (65535 / 2 + deadband))
			{
				axisOut = (float)(axis - 65535 / 2) / (float)(65535 / 2);
			}
			return axisOut;
		}

		protected override void LoadContent()
		{
			CursorModel = Game.Content.Load<Model>("Model\\AxisHelper");
			base.LoadContent();	
		}

		public override void Draw(GameTime gameTime)
		{
			if (!Enabled) return;
			Matrix world = Matrix.CreateScale(0.3f) * Matrix.CreateTranslation(CurrentPosition) * World;
			DrawModel.Draw(CursorModel, world, View, Projection);
			base.Draw(gameTime);
		}
	}
}
