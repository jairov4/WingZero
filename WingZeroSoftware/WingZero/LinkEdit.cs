using System;
using System.Windows.Forms;
using WingZero.Robotics;
using System.ComponentModel;

namespace WingZero
{
	public partial class LinkEdit : UserControl
	{
		public LinkEdit()
		{
			InitializeComponent();			
			PropertyGrid.DataBindings.Add("Visible", ShowDetailsCheckBox, "Checked", false, DataSourceUpdateMode.OnPropertyChanged);
		}

		Link link;

		[Bindable(true)]		
		public Link SelectedLink
		{
			get { return link; }
			set
			{
				link = value;
				BindingSource.DataSource = link;
				ChangeLink();				
			}
		}

		void ChangeLink()
		{
			if (SelectedLink != null)
			{
				GroupBox.Text = "Link: " + SelectedLink.Name;
				PropertyGrid.SelectedObject = SelectedLink;
				TrackBar.Enabled = true;
				TrackBar.DataBindings.Clear();				
				TrackBar.DataBindings.Add("Maximum", SelectedLink, "MaxValue", false, DataSourceUpdateMode.OnPropertyChanged);
				TrackBar.DataBindings.Add("Minimum", SelectedLink, "MinValue", false, DataSourceUpdateMode.OnPropertyChanged);
				TrackBar.DataBindings.Add("Value", SelectedLink, "Value", false, DataSourceUpdateMode.OnPropertyChanged);				
			}
			else
			{
				TrackBar.Enabled = false;
				GroupBox.Text = "No Link selected";
				TrackBar.DataBindings.Clear();
				PropertyGrid.SelectedObject = null;
			}
		}
				
		public bool ShowDetails
		{
			get
			{
				return ShowDetailsCheckBox.Checked;
			}
			set
			{
				ShowDetailsCheckBox.Checked = value;				
			}
		}

		private void TrackBar_MouseUp(object sender, MouseEventArgs e)
		{
			PropertyGrid.Refresh();
		}
	}
}
