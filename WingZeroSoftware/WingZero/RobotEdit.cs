using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WingZero.Robotics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;
using System.IO;

namespace WingZero
{	
	public partial class RobotEdit : UserControl
	{
		public RobotEdit()
		{
			InitializeComponent();
		}

		private void RobotEdit_Load(object sender, EventArgs e)
		{
			this.typeDataGridViewTextBoxColumn.Items.Add(Link.LinkType.Fixed);
			this.typeDataGridViewTextBoxColumn.Items.Add(Link.LinkType.Prismatic);
			this.typeDataGridViewTextBoxColumn.Items.Add(Link.LinkType.Rotative);
		}

		Robot robot;

		[Bindable(true)]
		public Robot SelectedRobot
		{
			get
			{
				return robot;
			}
			set
			{
				robot = value;
				ChangeRobot();
			}
		}

		public ContentManager ContentManager
		{
			get;
			set;
		}

		void ChangeRobot()
		{
			if (robot != null)
			{
				PropertyGrid.SelectedObject = SelectedRobot;
				linkBindingSource.DataSource = SelectedRobot.Chain;
			}
			else
			{
				PropertyGrid.SelectedObject = null;
				linkBindingSource.DataSource = null;
			}
		}

		private void GridView_SelectionChanged(object sender, EventArgs e)
		{
			if (GridView.SelectedRows.Count > 0)
			{
				LinkEdit.SelectedLink = GridView.SelectedRows[0].DataBoundItem as Link;
			}
		}

		private void LinkEdit_TrackBarChanged(object sender, EventArgs e)
		{
			PropertyGrid.Refresh();
		}

		private void ReloadModelsBtn_Click(object sender, EventArgs e)
		{
			if (ContentManager != null && GridView.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow row in GridView.SelectedRows)
				{
					Link link = row.DataBoundItem as Link;
					ReloadLinkModel(link);
				}
			}
		}

		private void ReloadLinkModel(Link link)
		{
			if (!String.IsNullOrEmpty(link.ModelPath))
			{
				link.Model = ContentManager.Load<Model>(link.ModelPath);
			}
		}

		private void ResetRobotBtn_Click(object sender, EventArgs e)
		{
			if (SelectedRobot != null)
			{
				this.SelectedRobot.Reset();
			}
		}

		private void ResetLinkBtn_Click(object sender, EventArgs e)
		{
			if (LinkEdit.SelectedLink != null)
			{
				LinkEdit.SelectedLink.Reset();
			}
		}

		private void SaveRobotBtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Robots XML (*.robot.xml)|*.robot.xml|Todos los archivos (*.*)|*.*";
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.Cancel) return;
			XmlSerializer s = new XmlSerializer(typeof(Robot));
			TextWriter w = new StreamWriter(dialog.FileName);
			s.Serialize(w, SelectedRobot);
			w.Close();
		}

		private void LoadRobotBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Robots XML (*.robot.xml)|*.robot.xml|Todos los archivos (*.*)|*.*";
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.Cancel) return;
			Robot newrobot;
			XmlSerializer s = new XmlSerializer(typeof(Robot));
			TextReader r = new StreamReader(dialog.FileName);
			newrobot = (Robot)s.Deserialize(r);
			SelectedRobot.Chain = newrobot.Chain;
			SelectedRobot.Name = newrobot.Name;
			SelectedRobot.ShowAxisHelper = newrobot.ShowAxisHelper;
			SelectedRobot.AxisHelperScale = newrobot.AxisHelperScale;
			ChangeRobot();
			SelectedRobot.Chain.ForEach(x => ReloadLinkModel(x));
			r.Close();			
		}
					
	}
}
