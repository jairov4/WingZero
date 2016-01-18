namespace WingZero
{
	partial class LinkEdit
	{
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.ShowDetailsCheckBox = new System.Windows.Forms.CheckBox();
			this.TrackBar = new WingZero.FloatTrackBar();
			this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox
			// 
			this.GroupBox.Controls.Add(this.PropertyGrid);
			this.GroupBox.Controls.Add(this.ShowDetailsCheckBox);
			this.GroupBox.Controls.Add(this.TrackBar);
			this.GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox.Location = new System.Drawing.Point(0, 0);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(331, 457);
			this.GroupBox.TabIndex = 0;
			this.GroupBox.TabStop = false;
			this.GroupBox.Text = "Link";
			// 
			// PropertyGrid
			// 
			this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PropertyGrid.Location = new System.Drawing.Point(3, 78);
			this.PropertyGrid.Name = "PropertyGrid";
			this.PropertyGrid.Size = new System.Drawing.Size(325, 376);
			this.PropertyGrid.TabIndex = 0;
			// 
			// ShowDetailsCheckBox
			// 
			this.ShowDetailsCheckBox.AutoSize = true;
			this.ShowDetailsCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ShowDetailsCheckBox.Location = new System.Drawing.Point(3, 61);
			this.ShowDetailsCheckBox.Name = "ShowDetailsCheckBox";
			this.ShowDetailsCheckBox.Size = new System.Drawing.Size(325, 17);
			this.ShowDetailsCheckBox.TabIndex = 2;
			this.ShowDetailsCheckBox.Text = "Show details";
			this.ShowDetailsCheckBox.UseVisualStyleBackColor = true;
			// 
			// TrackBar
			// 
			this.TrackBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TrackBar.LargeChange = 10;
			this.TrackBar.Location = new System.Drawing.Point(3, 16);
			this.TrackBar.Maximum = 1000F;
			this.TrackBar.Minimum = 0F;
			this.TrackBar.Name = "TrackBar";
			this.TrackBar.Size = new System.Drawing.Size(325, 45);
			this.TrackBar.TabIndex = 1;
			this.TrackBar.TickFrequency = 100;
			this.TrackBar.Value = 0F;			
			this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
			// 
			// LinkEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupBox);
			this.Name = "LinkEdit";
			this.Size = new System.Drawing.Size(331, 457);
			this.GroupBox.ResumeLayout(false);
			this.GroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.PropertyGrid PropertyGrid;
		private WingZero.FloatTrackBar TrackBar;
		private System.Windows.Forms.CheckBox ShowDetailsCheckBox;
		private System.Windows.Forms.BindingSource BindingSource;
	}
}
