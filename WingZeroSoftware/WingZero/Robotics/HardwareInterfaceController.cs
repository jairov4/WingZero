using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using WingZero.HardwareInterface.Altera;

namespace WingZero.Robotics
{
	public class HardwareInterfaceController : GameComponent
	{
		public Robot SelectedRobot { get; set; }
		int link;
		bool open = false;
		public List<Assigment> Assigments { get; set; }

		public HardwareInterfaceController(Game game, Robot robot) : base(game)
		{
			SelectedRobot = robot;
			Assigments = new List<Assigment>();
		}

		public void AttachHardware()
		{
			try
			{
				link = JtagUart.Open(0, 0, -1, null);
				JtagUart.Write(link, new byte[] { 0 });
			}
			catch (AccessViolationException e)
			{
				InvalidOperationException ex = new InvalidOperationException("No se pudo establecer conexion con el sistema empotrado. Compruebe que el cable USB este conectado al equipo. Compruebe que el sistema empotrado este en ejecucion.", e);
				throw ex;
			}
			open = true;
		}

		public void DetachHardware()
		{
			open = false;
			JtagUart.Close(link);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing == true)
			{
				DetachHardware();
			}
		}
		
		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			if (open && SelectedRobot != null)
			{
				for (int i = 0; i < SelectedRobot.Chain.Count; i++)
				{					
					Link l = SelectedRobot.Chain[i];
					if (Assigments.Count <= i) break;
					int v = GetHardwareLinkValue(l, i);
					byte[] buffer = new byte[4] { (byte)(i | 0x80), (byte)((v >> 14) & 0x7F), (byte)((v >> 7) & 0x7F), (byte)(v & 0x7F) };
					JtagUart.Write(link, buffer);
				}
				JtagUart.Flush(link);
			}
		}

		private int GetHardwareLinkValue(Link l, int index)
		{
			float t = (l.Value - l.MinValue) / (l.MaxValue - l.MinValue);
			float max = (float)Assigments[index].Maximum;
			float min = (float)Assigments[index].Minimum;
			float s = MathHelper.Lerp(max, min, t);
			return (int)s;
		}

		public class Assigment
		{			
			public int Servo { get; set; }
			public int Maximum { get; set; }
			public int Minimum { get; set; }
		}
	}
	
}
