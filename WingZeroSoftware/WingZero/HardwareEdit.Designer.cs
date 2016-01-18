namespace WingZero
{
	partial class HardwareEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareEdit));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.servoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maximumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minimumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.assigmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.openBtn = new System.Windows.Forms.ToolStripButton();
			this.saveBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.attachBtn = new System.Windows.Forms.ToolStripButton();
			this.detachBtn = new System.Windows.Forms.ToolStripButton();
			this.rebuildBtn = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.assigmentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servoDataGridViewTextBoxColumn,
            this.maximumDataGridViewTextBoxColumn,
            this.minimumDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.assigmentBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(493, 661);
			this.dataGridView1.TabIndex = 0;
			// 
			// servoDataGridViewTextBoxColumn
			// 
			this.servoDataGridViewTextBoxColumn.DataPropertyName = "Servo";
			this.servoDataGridViewTextBoxColumn.HeaderText = "Servo";
			this.servoDataGridViewTextBoxColumn.Name = "servoDataGridViewTextBoxColumn";
			// 
			// maximumDataGridViewTextBoxColumn
			// 
			this.maximumDataGridViewTextBoxColumn.DataPropertyName = "Maximum";
			this.maximumDataGridViewTextBoxColumn.HeaderText = "Maximum";
			this.maximumDataGridViewTextBoxColumn.Name = "maximumDataGridViewTextBoxColumn";
			// 
			// minimumDataGridViewTextBoxColumn
			// 
			this.minimumDataGridViewTextBoxColumn.DataPropertyName = "Minimum";
			this.minimumDataGridViewTextBoxColumn.HeaderText = "Minimum";
			this.minimumDataGridViewTextBoxColumn.Name = "minimumDataGridViewTextBoxColumn";
			// 
			// assigmentBindingSource
			// 
			this.assigmentBindingSource.DataSource = typeof(WingZero.Robotics.HardwareInterfaceController.Assigment);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.attachBtn,
            this.detachBtn,
            this.rebuildBtn});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(493, 25);
			this.bindingNavigator1.TabIndex = 1;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Eliminar";
			// 
			// openBtn
			// 
			this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openBtn.Image = global::WingZero.Properties.Resources.openHS;
			this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openBtn.Name = "openBtn";
			this.openBtn.Size = new System.Drawing.Size(23, 22);
			this.openBtn.Text = "Cargar asignaciones";
			this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveBtn.Image = global::WingZero.Properties.Resources.saveHS;
			this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(23, 22);
			this.saveBtn.Text = "Guardar asignaciones";
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Posición";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Mover último";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// attachBtn
			// 
			this.attachBtn.Image = global::WingZero.Properties.Resources.Flag_greenHS;
			this.attachBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.attachBtn.Name = "attachBtn";
			this.attachBtn.Size = new System.Drawing.Size(75, 22);
			this.attachBtn.Text = "Conectar";
			this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
			// 
			// detachBtn
			// 
			this.detachBtn.Image = global::WingZero.Properties.Resources.Flag_redHS;
			this.detachBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.detachBtn.Name = "detachBtn";
			this.detachBtn.Size = new System.Drawing.Size(92, 20);
			this.detachBtn.Text = "Desconectar";
			this.detachBtn.Click += new System.EventHandler(this.detachBtn_Click);
			// 
			// rebuildBtn
			// 
			this.rebuildBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rebuildBtn.Image = global::WingZero.Properties.Resources.RepeatHS;
			this.rebuildBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rebuildBtn.Name = "rebuildBtn";
			this.rebuildBtn.Size = new System.Drawing.Size(23, 20);
			this.rebuildBtn.Text = "Ajustar tabla de asignaciones";
			this.rebuildBtn.Click += new System.EventHandler(this.rebuildBtn_Click);
			// 
			// HardwareEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bindingNavigator1);
			this.Name = "HardwareEdit";
			this.Size = new System.Drawing.Size(493, 686);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.assigmentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton openBtn;
		private System.Windows.Forms.ToolStripButton saveBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton attachBtn;
		private System.Windows.Forms.ToolStripButton detachBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn servoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maximumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn minimumDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource assigmentBindingSource;
		private System.Windows.Forms.ToolStripButton rebuildBtn;
	}
}
