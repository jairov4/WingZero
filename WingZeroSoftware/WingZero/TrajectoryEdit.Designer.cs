namespace WingZero
{
	partial class TrajectoryEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrajectoryEdit));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownVelocity = new System.Windows.Forms.NumericUpDown();
			this.chkPreview = new System.Windows.Forms.CheckBox();
			this.addPointsBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxPlane = new System.Windows.Forms.ComboBox();
			this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
			this.comboBoxController = new System.Windows.Forms.ComboBox();
			this.openBtn = new System.Windows.Forms.ToolStripButton();
			this.saveBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.playAnimBtn = new System.Windows.Forms.ToolStripButton();
			this.resetAnimBtn = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trajectoryPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trajectoryPointBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.zDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.trajectoryPointBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 46);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(500, 373);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.numericUpDownPoints);
			this.groupBox1.Controls.Add(this.numericUpDownVelocity);
			this.groupBox1.Controls.Add(this.chkPreview);
			this.groupBox1.Controls.Add(this.addPointsBtn);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBoxPlane);
			this.groupBox1.Controls.Add(this.numericUpDownY);
			this.groupBox1.Controls.Add(this.numericUpDownX);
			this.groupBox1.Controls.Add(this.numericUpDownRadius);
			this.groupBox1.Controls.Add(this.numericUpDownZ);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 464);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Circunferencias";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(159, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Puntos";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(312, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Velocidad";
			// 
			// numericUpDownPoints
			// 
			this.numericUpDownPoints.Location = new System.Drawing.Point(200, 71);
			this.numericUpDownPoints.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.numericUpDownPoints.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numericUpDownPoints.Name = "numericUpDownPoints";
			this.numericUpDownPoints.Size = new System.Drawing.Size(106, 20);
			this.numericUpDownPoints.TabIndex = 5;
			this.numericUpDownPoints.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.numericUpDownPoints.ValueChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// numericUpDownVelocity
			// 
			this.numericUpDownVelocity.Location = new System.Drawing.Point(372, 70);
			this.numericUpDownVelocity.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
			this.numericUpDownVelocity.Name = "numericUpDownVelocity";
			this.numericUpDownVelocity.Size = new System.Drawing.Size(111, 20);
			this.numericUpDownVelocity.TabIndex = 5;
			this.numericUpDownVelocity.Value = new decimal(new int[] {
            7000,
            0,
            0,
            0});
			this.numericUpDownVelocity.ValueChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// chkPreview
			// 
			this.chkPreview.AutoSize = true;
			this.chkPreview.Location = new System.Drawing.Point(338, 21);
			this.chkPreview.Name = "chkPreview";
			this.chkPreview.Size = new System.Drawing.Size(64, 17);
			this.chkPreview.TabIndex = 4;
			this.chkPreview.Text = "Preview";
			this.chkPreview.UseVisualStyleBackColor = true;
			this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
			// 
			// addPointsBtn
			// 
			this.addPointsBtn.Location = new System.Drawing.Point(408, 17);
			this.addPointsBtn.Name = "addPointsBtn";
			this.addPointsBtn.Size = new System.Drawing.Size(75, 23);
			this.addPointsBtn.TabIndex = 3;
			this.addPointsBtn.Text = "Add points";
			this.addPointsBtn.UseVisualStyleBackColor = true;
			this.addPointsBtn.Click += new System.EventHandler(this.addPointsBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(159, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Plano";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(331, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Radio";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Origen Z";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Origen Y";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Origen X";
			// 
			// comboBoxPlane
			// 
			this.comboBoxPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPlane.FormattingEnabled = true;
			this.comboBoxPlane.Location = new System.Drawing.Point(200, 19);
			this.comboBoxPlane.Name = "comboBoxPlane";
			this.comboBoxPlane.Size = new System.Drawing.Size(106, 21);
			this.comboBoxPlane.TabIndex = 1;
			this.comboBoxPlane.SelectedIndexChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// numericUpDownY
			// 
			this.numericUpDownY.DecimalPlaces = 2;
			this.numericUpDownY.Location = new System.Drawing.Point(63, 45);
			this.numericUpDownY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numericUpDownY.Name = "numericUpDownY";
			this.numericUpDownY.Size = new System.Drawing.Size(90, 20);
			this.numericUpDownY.TabIndex = 0;
			this.numericUpDownY.ValueChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// numericUpDownX
			// 
			this.numericUpDownX.DecimalPlaces = 2;
			this.numericUpDownX.Location = new System.Drawing.Point(63, 19);
			this.numericUpDownX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numericUpDownX.Name = "numericUpDownX";
			this.numericUpDownX.Size = new System.Drawing.Size(90, 20);
			this.numericUpDownX.TabIndex = 0;
			this.numericUpDownX.ValueChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// numericUpDownRadius
			// 
			this.numericUpDownRadius.DecimalPlaces = 2;
			this.numericUpDownRadius.Location = new System.Drawing.Point(372, 45);
			this.numericUpDownRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numericUpDownRadius.Name = "numericUpDownRadius";
			this.numericUpDownRadius.Size = new System.Drawing.Size(111, 20);
			this.numericUpDownRadius.TabIndex = 0;
			this.numericUpDownRadius.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
			this.numericUpDownRadius.ValueChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// numericUpDownZ
			// 
			this.numericUpDownZ.DecimalPlaces = 2;
			this.numericUpDownZ.Location = new System.Drawing.Point(63, 71);
			this.numericUpDownZ.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownZ.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numericUpDownZ.Name = "numericUpDownZ";
			this.numericUpDownZ.Size = new System.Drawing.Size(90, 20);
			this.numericUpDownZ.TabIndex = 0;
			this.numericUpDownZ.ValueChanged += new System.EventHandler(this.CicleRelatedControl_ValueChanged);
			// 
			// comboBoxController
			// 
			this.comboBoxController.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBoxController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxController.FormattingEnabled = true;
			this.comboBoxController.Items.AddRange(new object[] {
            "Controlar mediante Joystick",
            "Controlar mediante puntos de trayectoria"});
			this.comboBoxController.Location = new System.Drawing.Point(0, 0);
			this.comboBoxController.Name = "comboBoxController";
			this.comboBoxController.Size = new System.Drawing.Size(500, 21);
			this.comboBoxController.TabIndex = 4;
			this.comboBoxController.SelectedIndexChanged += new System.EventHandler(this.comboBoxController_SelectedIndexChanged);
			// 
			// openBtn
			// 
			this.openBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openBtn.Image = global::WingZero.Properties.Resources.openHS;
			this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openBtn.Name = "openBtn";
			this.openBtn.Size = new System.Drawing.Size(23, 22);
			this.openBtn.Text = "Abrir trayectoria";
			this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveBtn.Image = global::WingZero.Properties.Resources.saveHS;
			this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(23, 22);
			this.saveBtn.Text = "Guardar trayectoria";
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
			this.bindingNavigatorCountItem.Text = "de {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// playAnimBtn
			// 
			this.playAnimBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.playAnimBtn.Image = global::WingZero.Properties.Resources.FormRunHS1;
			this.playAnimBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.playAnimBtn.Name = "playAnimBtn";
			this.playAnimBtn.Size = new System.Drawing.Size(23, 22);
			this.playAnimBtn.Text = "Iniciar la secuencia";
			this.playAnimBtn.Click += new System.EventHandler(this.playAnimBtn_Click);
			// 
			// resetAnimBtn
			// 
			this.resetAnimBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.resetAnimBtn.Image = global::WingZero.Properties.Resources.DoubleLeftArrowHS;
			this.resetAnimBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.resetAnimBtn.Name = "resetAnimBtn";
			this.resetAnimBtn.Size = new System.Drawing.Size(23, 22);
			this.resetAnimBtn.Text = "Detener e ir al inicio";
			this.resetAnimBtn.Click += new System.EventHandler(this.resetAnimBtn_Click);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.BindingSource = this.trajectoryPointBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.toolStripSeparator2,
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
            this.toolStripSeparator1,
            this.playAnimBtn,
            this.resetAnimBtn});
			this.bindingNavigator1.Location = new System.Drawing.Point(0, 21);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(500, 25);
			this.bindingNavigator1.TabIndex = 2;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// trackBar1
			// 
			this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.trackBar1.Location = new System.Drawing.Point(0, 419);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(500, 45);
			this.trackBar1.TabIndex = 5;
			this.trackBar1.TickFrequency = 100;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
			// 
			// trajectoryPointBindingSource
			// 
			this.trajectoryPointBindingSource.DataSource = typeof(WingZero.Robotics.TrajectoryPoint);
			// 
			// tDataGridViewTextBoxColumn
			// 
			this.tDataGridViewTextBoxColumn.DataPropertyName = "t";
			this.tDataGridViewTextBoxColumn.HeaderText = "Time";
			this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
			// 
			// xDataGridViewTextBoxColumn
			// 
			this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
			this.xDataGridViewTextBoxColumn.HeaderText = "X";
			this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
			// 
			// yDataGridViewTextBoxColumn
			// 
			this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
			this.yDataGridViewTextBoxColumn.HeaderText = "Y";
			this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
			// 
			// zDataGridViewTextBoxColumn
			// 
			this.zDataGridViewTextBoxColumn.DataPropertyName = "Z";
			this.zDataGridViewTextBoxColumn.HeaderText = "Z";
			this.zDataGridViewTextBoxColumn.Name = "zDataGridViewTextBoxColumn";
			// 
			// TrajectoryEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.comboBoxController);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.groupBox1);
			this.Name = "TrajectoryEdit";
			this.Size = new System.Drawing.Size(500, 564);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trajectoryPointBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource trajectoryPointBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn zDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxPlane;
		private System.Windows.Forms.NumericUpDown numericUpDownY;
		private System.Windows.Forms.NumericUpDown numericUpDownX;
		private System.Windows.Forms.NumericUpDown numericUpDownRadius;
		private System.Windows.Forms.NumericUpDown numericUpDownZ;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addPointsBtn;
		private System.Windows.Forms.CheckBox chkPreview;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownVelocity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDownPoints;
		private System.Windows.Forms.ComboBox comboBoxController;
		private System.Windows.Forms.ToolStripButton openBtn;
		private System.Windows.Forms.ToolStripButton saveBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton playAnimBtn;
		private System.Windows.Forms.ToolStripButton resetAnimBtn;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.TrackBar trackBar1;
	}
}
