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

namespace WingZero
{
	public partial class HardwareEdit : UserControl
	{
		public HardwareEdit()
		{
			InitializeComponent();
		}

		HardwareInterfaceController Controller;
		public void SetHardwareInterface(HardwareInterfaceController controller)
		{
			Controller = controller;
		}

		private void openBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Asignaciones hardware (*.assigments.xml)|*.assigments.xml|Todos los archivos (*.*)|*.*";
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.Cancel) return;
			XmlSerializer s = new XmlSerializer(typeof(List<HardwareInterfaceController.Assigment>));
			TextReader r = new StreamReader(dialog.FileName);
			Controller.Assigments = (List<HardwareInterfaceController.Assigment>)s.Deserialize(r);
			r.Close();
			AssigmentsChanged();
		}
		
		private void saveBtn_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Asignaciones hardware (*.assigments.xml)|*.assigments.xml|Todos los archivos (*.*)|*.*";
			DialogResult res = dialog.ShowDialog();
			if (res == DialogResult.Cancel) return;
			TextWriter w = new StreamWriter(dialog.FileName);
			XmlSerializer s = new XmlSerializer(typeof(List<HardwareInterfaceController.Assigment>));
			s.Serialize(w, Controller.Assigments);
			w.Close();
		}

		private void AssigmentsChanged()
		{
			if (Controller != null)
			{
				assigmentBindingSource.DataSource = Controller.Assigments;
				assigmentBindingSource.ResetBindings(false);
			}
		}

		private void attachBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Controller.AttachHardware();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error en la conexion");
			}
		}

		private void detachBtn_Click(object sender, EventArgs e)
		{
			Controller.DetachHardware();
		}

		private void rebuildBtn_Click(object sender, EventArgs e)
		{
			if (Controller.SelectedRobot.Chain.Count > Controller.Assigments.Count)
			{
				while(Controller.SelectedRobot.Chain.Count > Controller.Assigments.Count)
				{
					Controller.Assigments.Add(new HardwareInterfaceController.Assigment() { Servo = Controller.Assigments.Count });
				}
			}
			if (Controller.Assigments.Count > Controller.SelectedRobot.Chain.Count)
			{
				Controller.Assigments.RemoveRange(Controller.SelectedRobot.Chain.Count, Controller.Assigments.Count - Controller.SelectedRobot.Chain.Count);
			}
			AssigmentsChanged();
		}


	}
}
