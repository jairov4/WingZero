using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Content;
using WingZero.Robotics;
using Microsoft.Xna.Framework;

namespace WingZero
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();			
		}
		
		public void SetRobotEdit(Robotics.Robot robot, ContentManager cmgr) 
		{
			RobotEdit.SelectedRobot = robot;	
			RobotEdit.ContentManager= cmgr;
		}

		TrajectoryController trajCtl;
		public void SetTrajectoryController(TrajectoryController trajc)
		{
			trajCtl = trajc;
			trajectoryEdit1.SelectedTrajectoryController = trajc;
		}

		JoystickController joystickCtl;
		public void SetJoystickController(JoystickController trajc)
		{
			joystickCtl = trajc;
			trajectoryEdit1.Joystick = trajc;
		}

		public void SetHardwareInterfaceController(HardwareInterfaceController hwc)
		{
			hardwareEdit1.SetHardwareInterface(hwc);
		}

		private void MainForm_Activated(object sender, EventArgs e)
		{			
			Refresh();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}				
	}

}
