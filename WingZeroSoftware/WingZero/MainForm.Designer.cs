namespace WingZero
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.RobotEdit = new WingZero.RobotEdit();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.trajectoryEdit1 = new WingZero.TrajectoryEdit();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.hardwareEdit1 = new WingZero.HardwareEdit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(531, 757);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.RobotEdit);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(523, 731);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Status";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// RobotEdit
			// 
			this.RobotEdit.ContentManager = null;
			this.RobotEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RobotEdit.Location = new System.Drawing.Point(3, 3);
			this.RobotEdit.Name = "RobotEdit";
			this.RobotEdit.SelectedRobot = null;
			this.RobotEdit.Size = new System.Drawing.Size(517, 725);
			this.RobotEdit.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.trajectoryEdit1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(523, 731);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "IK Solver";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// trajectoryEdit1
			// 
			this.trajectoryEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trajectoryEdit1.Joystick = null;
			this.trajectoryEdit1.Location = new System.Drawing.Point(3, 3);
			this.trajectoryEdit1.Name = "trajectoryEdit1";
			this.trajectoryEdit1.SelectedTrajectoryController = null;
			this.trajectoryEdit1.Size = new System.Drawing.Size(517, 725);
			this.trajectoryEdit1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.hardwareEdit1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(523, 731);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Hardware";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// hardwareEdit1
			// 
			this.hardwareEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hardwareEdit1.Location = new System.Drawing.Point(3, 3);
			this.hardwareEdit1.Name = "hardwareEdit1";
			this.hardwareEdit1.Size = new System.Drawing.Size(517, 725);
			this.hardwareEdit1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 757);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private RobotEdit RobotEdit;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridViewTextBoxColumn velocityDataGridViewTextBoxColumn;
		private TrajectoryEdit trajectoryEdit1;
		private System.Windows.Forms.TabPage tabPage3;
		private HardwareEdit hardwareEdit1;

	}
}