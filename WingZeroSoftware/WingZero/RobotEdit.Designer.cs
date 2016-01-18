namespace WingZero
{
	partial class RobotEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotEdit));
			this.SplitContainer = new System.Windows.Forms.SplitContainer();
			this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.LinkEdit = new WingZero.LinkEdit();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.linkBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ReloadModelsBtn = new System.Windows.Forms.ToolStripButton();
			this.ResetRobotBtn = new System.Windows.Forms.ToolStripButton();
			this.ResetLinkBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
			this.SaveRobotBtn = new System.Windows.Forms.ToolStripButton();
			this.LoadRobotBtn = new System.Windows.Forms.ToolStripButton();
			this.GridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.AngleZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DistanceZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DistanceX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AngleX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.SplitContainer.Panel1.SuspendLayout();
			this.SplitContainer.Panel2.SuspendLayout();
			this.SplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SplitContainer
			// 
			this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer.Name = "SplitContainer";
			// 
			// SplitContainer.Panel1
			// 
			this.SplitContainer.Panel1.Controls.Add(this.PropertyGrid);
			// 
			// SplitContainer.Panel2
			// 
			this.SplitContainer.Panel2.Controls.Add(this.LinkEdit);
			this.SplitContainer.Size = new System.Drawing.Size(584, 282);
			this.SplitContainer.SplitterDistance = 253;
			this.SplitContainer.TabIndex = 0;
			// 
			// PropertyGrid
			// 
			this.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PropertyGrid.Location = new System.Drawing.Point(0, 0);
			this.PropertyGrid.Name = "PropertyGrid";
			this.PropertyGrid.Size = new System.Drawing.Size(253, 282);
			this.PropertyGrid.TabIndex = 0;
			// 
			// LinkEdit
			// 
			this.LinkEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LinkEdit.Location = new System.Drawing.Point(0, 0);
			this.LinkEdit.Name = "LinkEdit";
			this.LinkEdit.SelectedLink = null;
			this.LinkEdit.ShowDetails = false;
			this.LinkEdit.Size = new System.Drawing.Size(327, 282);
			this.LinkEdit.TabIndex = 1;
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.linkBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadRobotBtn,
            this.SaveRobotBtn,
            this.toolStripButton3,
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
            this.ReloadModelsBtn,
            this.ResetRobotBtn,
            this.ResetLinkBtn});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 169);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(584, 25);
			this.bindingNavigator1.TabIndex = 2;
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
			// linkBindingSource
			// 
			this.linkBindingSource.DataSource = typeof(WingZero.Robotics.Link);
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
			// ReloadModelsBtn
			// 
			this.ReloadModelsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ReloadModelsBtn.Image = global::WingZero.Properties.Resources.RefreshDocViewHS;
			this.ReloadModelsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ReloadModelsBtn.Name = "ReloadModelsBtn";
			this.ReloadModelsBtn.Size = new System.Drawing.Size(23, 22);
			this.ReloadModelsBtn.Text = "Reload 3D Models";
			this.ReloadModelsBtn.Click += new System.EventHandler(this.ReloadModelsBtn_Click);
			// 
			// ResetRobotBtn
			// 
			this.ResetRobotBtn.Image = global::WingZero.Properties.Resources.RepeatHS;
			this.ResetRobotBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ResetRobotBtn.Name = "ResetRobotBtn";
			this.ResetRobotBtn.Size = new System.Drawing.Size(87, 22);
			this.ResetRobotBtn.Text = "Reset robot";
			this.ResetRobotBtn.Click += new System.EventHandler(this.ResetRobotBtn_Click);
			// 
			// ResetLinkBtn
			// 
			this.ResetLinkBtn.Image = global::WingZero.Properties.Resources.Edit_UndoHS;
			this.ResetLinkBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ResetLinkBtn.Name = "ResetLinkBtn";
			this.ResetLinkBtn.Size = new System.Drawing.Size(77, 22);
			this.ResetLinkBtn.Text = "Reset link";
			this.ResetLinkBtn.Click += new System.EventHandler(this.ResetLinkBtn_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(6, 25);
			// 
			// SaveRobotBtn
			// 
			this.SaveRobotBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveRobotBtn.Image = global::WingZero.Properties.Resources.saveHS;
			this.SaveRobotBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveRobotBtn.Name = "SaveRobotBtn";
			this.SaveRobotBtn.Size = new System.Drawing.Size(23, 22);
			this.SaveRobotBtn.Text = "toolStripButton1";
			this.SaveRobotBtn.Click += new System.EventHandler(this.SaveRobotBtn_Click);
			// 
			// LoadRobotBtn
			// 
			this.LoadRobotBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.LoadRobotBtn.Image = global::WingZero.Properties.Resources.openHS;
			this.LoadRobotBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.LoadRobotBtn.Name = "LoadRobotBtn";
			this.LoadRobotBtn.Size = new System.Drawing.Size(23, 22);
			this.LoadRobotBtn.Text = "toolStripButton2";
			this.LoadRobotBtn.Click += new System.EventHandler(this.LoadRobotBtn_Click);
			// 
			// GridView
			// 
			this.GridView.AutoGenerateColumns = false;
			this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.AngleZ,
            this.DistanceZ,
            this.DistanceX,
            this.AngleX});
			this.GridView.DataSource = this.linkBindingSource;
			this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridView.Location = new System.Drawing.Point(0, 0);
			this.GridView.Name = "GridView";
			this.GridView.Size = new System.Drawing.Size(584, 169);
			this.GridView.TabIndex = 0;
			this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.nameDataGridViewTextBoxColumn.Width = 41;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// AngleZ
			// 
			this.AngleZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.AngleZ.DataPropertyName = "AngleZ";
			this.AngleZ.HeaderText = "Theta (Rz)";
			this.AngleZ.Name = "AngleZ";
			this.AngleZ.Width = 82;
			// 
			// DistanceZ
			// 
			this.DistanceZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.DistanceZ.DataPropertyName = "DistanceZ";
			this.DistanceZ.HeaderText = "d (Tz)";
			this.DistanceZ.Name = "DistanceZ";
			this.DistanceZ.Width = 59;
			// 
			// DistanceX
			// 
			this.DistanceX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.DistanceX.DataPropertyName = "DistanceX";
			this.DistanceX.HeaderText = "a (Tx)";
			this.DistanceX.Name = "DistanceX";
			this.DistanceX.Width = 59;
			// 
			// AngleX
			// 
			this.AngleX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.AngleX.DataPropertyName = "AngleX";
			this.AngleX.HeaderText = "alpha (Rx)";
			this.AngleX.Name = "AngleX";
			this.AngleX.Width = 80;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.GridView);
			this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.SplitContainer);
			this.splitContainer1.Size = new System.Drawing.Size(584, 480);
			this.splitContainer1.SplitterDistance = 194;
			this.splitContainer1.TabIndex = 1;
			// 
			// RobotEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "RobotEdit";
			this.Size = new System.Drawing.Size(584, 480);
			this.Load += new System.EventHandler(this.RobotEdit_Load);
			this.SplitContainer.Panel1.ResumeLayout(false);
			this.SplitContainer.Panel2.ResumeLayout(false);
			this.SplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer SplitContainer;
		private System.Windows.Forms.PropertyGrid PropertyGrid;
		private System.Windows.Forms.DataGridView GridView;
		private System.Windows.Forms.BindingSource linkBindingSource;
		private LinkEdit LinkEdit;
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
		private System.Windows.Forms.ToolStripButton ReloadModelsBtn;
		private System.Windows.Forms.ToolStripButton ResetRobotBtn;
		private System.Windows.Forms.ToolStripButton ResetLinkBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn AngleZ;
		private System.Windows.Forms.DataGridViewTextBoxColumn DistanceZ;
		private System.Windows.Forms.DataGridViewTextBoxColumn DistanceX;
		private System.Windows.Forms.DataGridViewTextBoxColumn AngleX;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripButton SaveRobotBtn;
		private System.Windows.Forms.ToolStripButton LoadRobotBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripButton3;
	}
}
