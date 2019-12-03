namespace SistemaNavideño
{
    partial class Administracion
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
=======
            System.Windows.Forms.Label cod_EmpleadoLabel;
            System.Windows.Forms.Label cILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label cargoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yOtroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.empleadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.empleadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cod_EmpleadoLabel = new System.Windows.Forms.Label();
            this.cod_EmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.cILabel = new System.Windows.Forms.Label();
            this.cITextBox = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.cargoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarjetaVentaDataSet = new SistemaNavideño.TarjetaVentaDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoTableAdapter = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
=======
            cod_EmpleadoLabel = new System.Windows.Forms.Label();
            cILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).BeginInit();
            this.empleadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaVentaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_EmpleadoLabel
            // 
            cod_EmpleadoLabel.AutoSize = true;
            cod_EmpleadoLabel.BackColor = System.Drawing.Color.Transparent;
            cod_EmpleadoLabel.Location = new System.Drawing.Point(40, 112);
            cod_EmpleadoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            cod_EmpleadoLabel.Name = "cod_EmpleadoLabel";
            cod_EmpleadoLabel.Size = new System.Drawing.Size(131, 21);
            cod_EmpleadoLabel.TabIndex = 15;
            cod_EmpleadoLabel.Text = "Cod Empleado:";
            // 
            // cILabel
            // 
            cILabel.AutoSize = true;
            cILabel.BackColor = System.Drawing.Color.Transparent;
            cILabel.Location = new System.Drawing.Point(136, 154);
            cILabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            cILabel.Name = "cILabel";
            cILabel.Size = new System.Drawing.Size(37, 21);
            cILabel.TabIndex = 16;
            cILabel.Text = "CI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(83, 212);
            nombreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(79, 21);
            nombreLabel.TabIndex = 17;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.BackColor = System.Drawing.Color.Transparent;
            apellidoLabel.Location = new System.Drawing.Point(86, 272);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(79, 21);
            apellidoLabel.TabIndex = 18;
            apellidoLabel.Text = "Apellido:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.BackColor = System.Drawing.Color.Transparent;
            cargoLabel.Location = new System.Drawing.Point(103, 329);
            cargoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(63, 21);
            cargoLabel.TabIndex = 19;
            cargoLabel.Text = "Cargo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientesToolStripMenuItem,
            this.otroCasoToolStripMenuItem,
            this.yOtroCasoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(158, 18);
            this.listaClientesToolStripMenuItem.Text = "Gestionar Empleados";
            this.listaClientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientesToolStripMenuItem_Click);
            // 
            // otroCasoToolStripMenuItem
            // 
            this.otroCasoToolStripMenuItem.Name = "otroCasoToolStripMenuItem";
            this.otroCasoToolStripMenuItem.Size = new System.Drawing.Size(177, 18);
            this.otroCasoToolStripMenuItem.Text = "Generar Reporte Ventas";
            // 
            // yOtroCasoToolStripMenuItem
            // 
            this.yOtroCasoToolStripMenuItem.Name = "yOtroCasoToolStripMenuItem";
            this.yOtroCasoToolStripMenuItem.Size = new System.Drawing.Size(116, 18);
            this.yOtroCasoToolStripMenuItem.Text = "Verificar Stock";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(1199, 588);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 71);
            this.button2.TabIndex = 13;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // empleadoBindingNavigator
            // 
            this.empleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadoBindingNavigator.BindingSource = this.empleadoBindingSource;
            this.empleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empleadoBindingNavigatorSaveItem});
            this.empleadoBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.empleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadoBindingNavigator.Name = "empleadoBindingNavigator";
            this.empleadoBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.empleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadoBindingNavigator.Size = new System.Drawing.Size(985, 25);
            this.empleadoBindingNavigator.TabIndex = 14;
            this.empleadoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(88, 23);
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
            // empleadoBindingNavigatorSaveItem
            // 
            this.empleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoBindingNavigatorSaveItem.Image")));
            this.empleadoBindingNavigatorSaveItem.Name = "empleadoBindingNavigatorSaveItem";
            this.empleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empleadoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.empleadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadoBindingNavigatorSaveItem_Click);
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(406, 107);
            this.empleadoDataGridView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.Size = new System.Drawing.Size(543, 355);
            this.empleadoDataGridView.TabIndex = 14;
            this.empleadoDataGridView.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(339, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "REGISTRO DE EMPLEADOS";
            this.label1.Visible = false;
            // 
<<<<<<< HEAD
            // cod_EmpleadoLabel
            // 
            this.cod_EmpleadoLabel.AutoSize = true;
            this.cod_EmpleadoLabel.Location = new System.Drawing.Point(40, 112);
            this.cod_EmpleadoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cod_EmpleadoLabel.Name = "cod_EmpleadoLabel";
            this.cod_EmpleadoLabel.Size = new System.Drawing.Size(131, 21);
            this.cod_EmpleadoLabel.TabIndex = 15;
            this.cod_EmpleadoLabel.Text = "Cod Empleado:";
            this.cod_EmpleadoLabel.Visible = false;
            // 
=======
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            // cod_EmpleadoTextBox
            // 
            this.cod_EmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Cod_Empleado", true));
            this.cod_EmpleadoTextBox.Location = new System.Drawing.Point(183, 107);
            this.cod_EmpleadoTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cod_EmpleadoTextBox.Name = "cod_EmpleadoTextBox";
            this.cod_EmpleadoTextBox.Size = new System.Drawing.Size(180, 28);
            this.cod_EmpleadoTextBox.TabIndex = 16;
            this.cod_EmpleadoTextBox.Visible = false;
            // 
<<<<<<< HEAD
            // cILabel
            // 
            this.cILabel.AutoSize = true;
            this.cILabel.Location = new System.Drawing.Point(136, 154);
            this.cILabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cILabel.Name = "cILabel";
            this.cILabel.Size = new System.Drawing.Size(37, 21);
            this.cILabel.TabIndex = 16;
            this.cILabel.Text = "CI:";
            this.cILabel.Visible = false;
            // 
=======
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            // cITextBox
            // 
            this.cITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "CI", true));
            this.cITextBox.Location = new System.Drawing.Point(183, 149);
            this.cITextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cITextBox.Name = "cITextBox";
            this.cITextBox.Size = new System.Drawing.Size(180, 28);
            this.cITextBox.TabIndex = 17;
            this.cITextBox.Visible = false;
            // 
<<<<<<< HEAD
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(83, 212);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(79, 21);
            this.nombreLabel.TabIndex = 17;
            this.nombreLabel.Text = "Nombre:";
            this.nombreLabel.Visible = false;
            // 
=======
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(182, 206);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(180, 28);
            this.nombreTextBox.TabIndex = 18;
            this.nombreTextBox.Visible = false;
            // 
<<<<<<< HEAD
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(86, 272);
            this.apellidoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(79, 21);
            this.apellidoLabel.TabIndex = 18;
            this.apellidoLabel.Text = "Apellido:";
            this.apellidoLabel.Visible = false;
            // 
=======
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(182, 267);
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(180, 28);
            this.apellidoTextBox.TabIndex = 19;
            this.apellidoTextBox.Visible = false;
            // 
<<<<<<< HEAD
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Location = new System.Drawing.Point(103, 329);
            this.cargoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(63, 21);
            this.cargoLabel.TabIndex = 19;
            this.cargoLabel.Text = "Cargo:";
            this.cargoLabel.Visible = false;
            // 
=======
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            // cargoTextBox
            // 
            this.cargoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Cargo", true));
            this.cargoTextBox.Location = new System.Drawing.Point(182, 324);
            this.cargoTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cargoTextBox.Name = "cargoTextBox";
            this.cargoTextBox.Size = new System.Drawing.Size(180, 28);
            this.cargoTextBox.TabIndex = 20;
            this.cargoTextBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "NUEVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 32);
            this.button3.TabIndex = 22;
            this.button3.Text = "REGISTRAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 32);
            this.button4.TabIndex = 23;
            this.button4.Text = "MODIFICAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 32);
            this.button5.TabIndex = 24;
            this.button5.Text = "ELIMINAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.tarjetaVentaDataSet;
            // 
            // tarjetaVentaDataSet
            // 
            this.tarjetaVentaDataSet.DataSetName = "TarjetaVentaDataSet";
            this.tarjetaVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CI";
            this.dataGridViewTextBoxColumn2.HeaderText = "CI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CatálogoTableAdapter = null;
            this.tableAdapterManager.Cliente_EmpresaTableAdapter = null;
            this.tableAdapterManager.Detalle_pedidoTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaNavideño.TarjetaVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 485);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cargoLabel);
            this.Controls.Add(this.cargoTextBox);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.cILabel);
            this.Controls.Add(this.cITextBox);
            this.Controls.Add(this.cod_EmpleadoLabel);
            this.Controls.Add(this.cod_EmpleadoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(this.empleadoBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Administracion";
            this.Text = "Adminsitración";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
>>>>>>> c737bf17e48f58e7c72951ccb3854e7e0ed4b72f
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).EndInit();
            this.empleadoBindingNavigator.ResumeLayout(false);
            this.empleadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaVentaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroCasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yOtroCasoToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private TarjetaVentaDataSet tarjetaVentaDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private TarjetaVentaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private TarjetaVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empleadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empleadoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cod_EmpleadoTextBox;
        private System.Windows.Forms.TextBox cITextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox cargoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label cod_EmpleadoLabel;
        private System.Windows.Forms.Label cILabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label cargoLabel;
    }
}