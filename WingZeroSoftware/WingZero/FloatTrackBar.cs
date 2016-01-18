using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace WingZero
{
	
	[DefaultBindingProperty("Value")]	
	public class FloatTrackBar : System.Windows.Forms.TrackBar
	{
		float value, max, min;

		[Bindable(true)]
		public new float Value
		{
			get
			{
				return value;				
			}
			set
			{
				this.value = value;
				int v = (int)(value * 1000.0f);
				base.Value = v > base.Maximum ? base.Maximum : (v < base.Minimum ? base.Minimum : v);
			}
		}

		[Bindable(true)]
		public new float Maximum
		{
			get
			{
				return max;
			}
			set
			{
				max = value;
				base.Maximum = (int)(value * 1000.0f);
			}
		}

		[Bindable(true)]
		public new float Minimum
		{
			get
			{
				return min;				
			}
			set
			{
				min = value;
				base.Minimum = (int)(value * 1000.0f);
			}
		}

		protected override void OnScroll(EventArgs e)
		{
			base.OnScroll(e);
			this.value = base.Value / 1000.0f;
		}

	}

	public class WingZeroPropertyGrid : PropertyGrid
	{		
		protected override void OnSelectedObjectsChanged(EventArgs e)
		{
			base.OnSelectedObjectsChanged(e);
			foreach (object o in SelectedObjects)
			{
				INotifyPropertyChanged opc = o as INotifyPropertyChanged;
				if (opc != null)
				{
					opc.PropertyChanged += new PropertyChangedEventHandler(SelectedItem_PropertyChanged);
				}
			}			
		}

		void SelectedItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (!SelectedObjects.Contains(sender))
			{
				INotifyPropertyChanged opc = sender as INotifyPropertyChanged;
				opc.PropertyChanged -= SelectedItem_PropertyChanged;
			}
			this.OnNotifyPropertyValueUIItemsChanged(this, new EventArgs());
		}
		
	}
}
