using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WingZero.Robotics;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Xna.Framework;

namespace WingZero
{
	public partial class TrajectoryEdit : UserControl
	{
		int? TrajectoryOpt;
		int? JoystickOpt;

		int PlaneXY;
		int PlaneYZ;
		int PlaneXZ;

		List<TrajectoryPoint> BackupPoints = new List<TrajectoryPoint>();

		public TrajectoryEdit()
		{
			InitializeComponent();
			PlaneXY = comboBoxPlane.Items.Add("Plano XY");
			PlaneXZ = comboBoxPlane.Items.Add("Plano XZ");
			PlaneYZ = comboBoxPlane.Items.Add("Plano YZ");
			comboBoxPlane.SelectedIndex = PlaneXY;
		}
				
		/// <summary>
		/// Controlador de trayectoria para editar los puntos
		/// </summary>
		public TrajectoryController SelectedTrajectoryController
		{
			set
			{
				_SelectedTrajectoryController = value;
				ChangeTrajectoryController();
			}
			get { return _SelectedTrajectoryController; }
		}
		TrajectoryController _SelectedTrajectoryController;

		/// <summary>
		/// Controlador del joystick para activarlo cuando se escoja
		/// </summary>
		public JoystickController Joystick
		{
			set
			{
				_Joystick = value;
				ChangeJoystick();
			}
			get
			{
				return _Joystick;
			}
		}
		JoystickController _Joystick;


		private void ChangeTrajectoryController()
		{
			if (_SelectedTrajectoryController != null)
			{				
				trajectoryPointBindingSource.DataSource = _SelectedTrajectoryController.Trajectory;
				trajectoryPointBindingSource.ResetBindings(false);
			}
			FillControllerCombo();
			FixTimeTrackBar();
		}

		private void FixTimeTrackBar()
		{
			if (_SelectedTrajectoryController != null)
			{
				trackBar1.Maximum = (int)_SelectedTrajectoryController.TotalTime.TotalMilliseconds;
				trackBar1.Minimum = 0;
			}
		}


		private void ChangeJoystick()
		{
			FillControllerCombo();
		}


		private void FillControllerCombo()
		{
			comboBoxController.Items.Clear();
			if (_SelectedTrajectoryController != null)
			{
				TrajectoryOpt = comboBoxController.Items.Add("Controlar por plan de trayectoria");
			}
			else
			{
				TrajectoryOpt = null;
			}
			if (_Joystick != null)
			{
				JoystickOpt = comboBoxController.Items.Add("Controlar por Joystick");
			}
			else
			{
				JoystickOpt = null;
			}

			// se asegura de solo habilitar uno
			if ((_SelectedTrajectoryController != null) && 
				(_Joystick != null) && 
				(_SelectedTrajectoryController.Enabled == _Joystick.Enabled))
			{
				_Joystick.Enabled = true;
				_SelectedTrajectoryController.Enabled = false;
			}
			if ((_SelectedTrajectoryController != null) && _SelectedTrajectoryController.Enabled)
			{
				comboBoxController.SelectedIndex = (int)TrajectoryOpt;
			}
			if ((_Joystick != null) && _Joystick.Enabled)
			{
				comboBoxController.SelectedIndex = (int)JoystickOpt;
			}
		}

		private void comboBoxController_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxController.SelectedIndex == JoystickOpt)
			{
				_Joystick.Enabled = true;
				_SelectedTrajectoryController.Enabled = false;
			}

			if (comboBoxController.SelectedIndex == TrajectoryOpt)
			{
				_Joystick.Enabled = false;
				_SelectedTrajectoryController.Enabled = true;
			}
		}

		private void openBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Plan de trayectoria (*.trajectory.xml)|*.trajectory.xml|Todos los archivos (*.*)|*.*";
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.Cancel) return;
			XmlSerializer s = new XmlSerializer(typeof(List<TrajectoryPoint>));
			TextReader w = new StreamReader(dialog.FileName);
			_SelectedTrajectoryController.Trajectory = (List<TrajectoryPoint>)s.Deserialize(w);
			ChangeTrajectoryController();
			w.Close();
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Plan de trayectoria (*.trajectory.xml)|*.trajectory.xml|Todos los archivos (*.*)|*.*";
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.Cancel) return;
			XmlSerializer s = new XmlSerializer(typeof(List<TrajectoryPoint>));
			TextWriter w = new StreamWriter(dialog.FileName);
			s.Serialize(w, _SelectedTrajectoryController.Trajectory);
			w.Close();
		}

		private void resetAnimBtn_Click(object sender, EventArgs e)
		{
			_SelectedTrajectoryController.Time = new TimeSpan(0);
			_SelectedTrajectoryController.Enabled = false;
		}

		private void playAnimBtn_Click(object sender, EventArgs e)
		{
			if (TrajectoryOpt == comboBoxController.SelectedIndex)
			{
				_SelectedTrajectoryController.Enabled = true;
			}
		}

		private void CicleRelatedControl_ValueChanged(object sender, EventArgs e)
		{					
			if (chkPreview.Checked)
			{				
				List<TrajectoryPoint> points = new List<TrajectoryPoint>();
				MakeCircle(points);
				_SelectedTrajectoryController.Trajectory = points;
				ChangeTrajectoryController();
			}
		}

		private void MakeCircle(List<TrajectoryPoint> points)
		{
			int npoints = (int)numericUpDownPoints.Value + 1;
			TimeSpan time = new TimeSpan(0);
			int totalMilis = (int)numericUpDownVelocity.Value;
			TimeSpan timeInc = new TimeSpan(0, 0, 0, 0, totalMilis / npoints);
			float x0 = (float)numericUpDownX.Value, y0 = (float)numericUpDownY.Value, z0 = (float)numericUpDownZ.Value;
			for (int i = 0; i < npoints; i++)
			{
				float t = (float)i / (float)numericUpDownPoints.Value * MathHelper.TwoPi;
				float u = (float)numericUpDownRadius.Value * (float)Math.Cos(t);
				float v = (float)numericUpDownRadius.Value * (float)Math.Sin(t);
				if (comboBoxPlane.SelectedIndex == PlaneXY)
				{
					points.Add(new TrajectoryPoint() { t = time, X = u + x0, Y = v + y0, Z = z0 });
				}
				else if (comboBoxPlane.SelectedIndex == PlaneXZ)
				{
					points.Add(new TrajectoryPoint() { t = time, X = u + x0, Y = y0, Z = v + z0 });
				}
				else if (comboBoxPlane.SelectedIndex == PlaneYZ)
				{
					points.Add(new TrajectoryPoint() { t = time, X = x0, Y = u + y0, Z = v + z0 });
				}
				time = time + timeInc;
			}
		}

		private void addPointsBtn_Click(object sender, EventArgs e)
		{			
			MakeCircle(_SelectedTrajectoryController.Trajectory);
			ChangeTrajectoryController();
		}

		private void chkPreview_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.Enabled = !chkPreview.Checked;
			openBtn.Enabled = !chkPreview.Checked;	
			addPointsBtn.Enabled = !chkPreview.Checked;
			if (chkPreview.Checked)
			{
				BackupPoints = _SelectedTrajectoryController.Trajectory;
				CicleRelatedControl_ValueChanged(sender, e);
			}
			else
			{
				_SelectedTrajectoryController.Trajectory = BackupPoints;
				ChangeTrajectoryController();
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void trackBar1_MouseUp(object sender, MouseEventArgs e)
		{
			_SelectedTrajectoryController.Time = new TimeSpan(0, 0, 0, 0, trackBar1.Value);
		}
	}
}
