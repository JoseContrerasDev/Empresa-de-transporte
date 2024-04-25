namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label aPELLIDOLabel;
            System.Windows.Forms.Label cUITLabel;
            System.Windows.Forms.Label mAILLabel;
            System.Windows.Forms.Label tELEFONOLabel;
            System.Windows.Forms.Label dIRECCIONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.Label dIRECCIONLabel1;
            System.Windows.Forms.Label tELEFONOLabel1;
            System.Windows.Forms.Label mAILLabel1;
            System.Windows.Forms.Label cUITLabel1;
            System.Windows.Forms.Label cONTACTOLabel;
            System.Windows.Forms.Label nOMBRELabel1;
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNTEGRADORNETDataSet = new Presentacion.INTEGRADORNETDataSet();
            this.cLIENTEINDIVIDUOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTEINDIVIDUOTableAdapter = new Presentacion.INTEGRADORNETDataSetTableAdapters.CLIENTEINDIVIDUOTableAdapter();
            this.tableAdapterManager = new Presentacion.INTEGRADORNETDataSetTableAdapters.TableAdapterManager();
            this.cLIENTEINDIVIDUOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbcClienteIndividuo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cLIENTEINDIVIDUODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox = new System.Windows.Forms.TextBox();
            this.aPELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.mAILTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONOTextBox = new System.Windows.Forms.TextBox();
            this.dIRECCIONTextBox = new System.Windows.Forms.TextBox();
            this.tbcClienteEmpresa = new System.Windows.Forms.TabPage();
            this.cLIENTEEMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbcProducto = new System.Windows.Forms.TabPage();
            this.cLIENTEEMPRESATableAdapter = new Presentacion.INTEGRADORNETDataSetTableAdapters.CLIENTEEMPRESATableAdapter();
            this.dIRECCIONTextBox1 = new System.Windows.Forms.TextBox();
            this.tELEFONOTextBox1 = new System.Windows.Forms.TextBox();
            this.mAILTextBox1 = new System.Windows.Forms.TextBox();
            this.cUITTextBox = new System.Windows.Forms.TextBox();
            this.cONTACTOTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRETextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.VER = new System.Windows.Forms.Button();
            this.cLIENTEEMPRESADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            iDLabel = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            aPELLIDOLabel = new System.Windows.Forms.Label();
            cUITLabel = new System.Windows.Forms.Label();
            mAILLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            dIRECCIONLabel1 = new System.Windows.Forms.Label();
            tELEFONOLabel1 = new System.Windows.Forms.Label();
            mAILLabel1 = new System.Windows.Forms.Label();
            cUITLabel1 = new System.Windows.Forms.Label();
            cONTACTOLabel = new System.Windows.Forms.Label();
            nOMBRELabel1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNTEGRADORNETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEINDIVIDUOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEINDIVIDUOBindingNavigator)).BeginInit();
            this.cLIENTEINDIVIDUOBindingNavigator.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tbcClienteIndividuo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEINDIVIDUODataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbcClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEEMPRESABindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEEMPRESADataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(19, 86);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(23, 16);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(19, 114);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(69, 16);
            nOMBRELabel.TabIndex = 2;
            nOMBRELabel.Text = "NOMBRE:";
            // 
            // aPELLIDOLabel
            // 
            aPELLIDOLabel.AutoSize = true;
            aPELLIDOLabel.Location = new System.Drawing.Point(19, 142);
            aPELLIDOLabel.Name = "aPELLIDOLabel";
            aPELLIDOLabel.Size = new System.Drawing.Size(74, 16);
            aPELLIDOLabel.TabIndex = 4;
            aPELLIDOLabel.Text = "APELLIDO:";
            // 
            // cUITLabel
            // 
            cUITLabel.AutoSize = true;
            cUITLabel.Location = new System.Drawing.Point(19, 170);
            cUITLabel.Name = "cUITLabel";
            cUITLabel.Size = new System.Drawing.Size(41, 16);
            cUITLabel.TabIndex = 6;
            cUITLabel.Text = "CUIT:";
            // 
            // mAILLabel
            // 
            mAILLabel.AutoSize = true;
            mAILLabel.Location = new System.Drawing.Point(19, 198);
            mAILLabel.Name = "mAILLabel";
            mAILLabel.Size = new System.Drawing.Size(40, 16);
            mAILLabel.TabIndex = 8;
            mAILLabel.Text = "MAIL:";
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(19, 226);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(82, 16);
            tELEFONOLabel.TabIndex = 10;
            tELEFONOLabel.Text = "TELEFONO:";
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(19, 254);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(83, 16);
            dIRECCIONLabel.TabIndex = 12;
            dIRECCIONLabel.Text = "DIRECCION:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // iNTEGRADORNETDataSet
            // 
            this.iNTEGRADORNETDataSet.DataSetName = "INTEGRADORNETDataSet";
            this.iNTEGRADORNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEINDIVIDUOBindingSource
            // 
            this.cLIENTEINDIVIDUOBindingSource.DataMember = "CLIENTEINDIVIDUO";
            this.cLIENTEINDIVIDUOBindingSource.DataSource = this.iNTEGRADORNETDataSet;
            // 
            // cLIENTEINDIVIDUOTableAdapter
            // 
            this.cLIENTEINDIVIDUOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTEEMPRESATableAdapter = null;
            this.tableAdapterManager.CLIENTEINDIVIDUOTableAdapter = this.cLIENTEINDIVIDUOTableAdapter;
            this.tableAdapterManager.PRODUCTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Presentacion.INTEGRADORNETDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            // 
            // cLIENTEINDIVIDUOBindingNavigator
            // 
            this.cLIENTEINDIVIDUOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLIENTEINDIVIDUOBindingNavigator.BindingSource = this.cLIENTEINDIVIDUOBindingSource;
            this.cLIENTEINDIVIDUOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLIENTEINDIVIDUOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLIENTEINDIVIDUOBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.cLIENTEINDIVIDUOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem});
            this.cLIENTEINDIVIDUOBindingNavigator.Location = new System.Drawing.Point(-6, 30);
            this.cLIENTEINDIVIDUOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLIENTEINDIVIDUOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLIENTEINDIVIDUOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLIENTEINDIVIDUOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLIENTEINDIVIDUOBindingNavigator.Name = "cLIENTEINDIVIDUOBindingNavigator";
            this.cLIENTEINDIVIDUOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLIENTEINDIVIDUOBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.cLIENTEINDIVIDUOBindingNavigator.TabIndex = 1;
            this.cLIENTEINDIVIDUOBindingNavigator.Text = "bindingNavigator1";
            this.cLIENTEINDIVIDUOBindingNavigator.RefreshItems += new System.EventHandler(this.cLIENTEINDIVIDUOBindingNavigator_RefreshItems);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // cLIENTEINDIVIDUOBindingNavigatorSaveItem
            // 
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLIENTEINDIVIDUOBindingNavigatorSaveItem.Image")));
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem.Name = "cLIENTEINDIVIDUOBindingNavigatorSaveItem";
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.cLIENTEINDIVIDUOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLIENTEINDIVIDUOBindingNavigatorSaveItem_Click);
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbcClienteIndividuo);
            this.tbcPrincipal.Controls.Add(this.tbcClienteEmpresa);
            this.tbcPrincipal.Controls.Add(this.tbcProducto);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1031, 608);
            this.tbcPrincipal.TabIndex = 2;
            // 
            // tbcClienteIndividuo
            // 
            this.tbcClienteIndividuo.BackColor = System.Drawing.Color.Red;
            this.tbcClienteIndividuo.Controls.Add(this.groupBox2);
            this.tbcClienteIndividuo.Controls.Add(this.groupBox1);
            this.tbcClienteIndividuo.Location = new System.Drawing.Point(4, 25);
            this.tbcClienteIndividuo.Name = "tbcClienteIndividuo";
            this.tbcClienteIndividuo.Padding = new System.Windows.Forms.Padding(3);
            this.tbcClienteIndividuo.Size = new System.Drawing.Size(1023, 579);
            this.tbcClienteIndividuo.TabIndex = 0;
            this.tbcClienteIndividuo.Text = "Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cLIENTEINDIVIDUODataGridView);
            this.groupBox2.Location = new System.Drawing.Point(282, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Clientes";
            // 
            // cLIENTEINDIVIDUODataGridView
            // 
            this.cLIENTEINDIVIDUODataGridView.AutoGenerateColumns = false;
            this.cLIENTEINDIVIDUODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTEINDIVIDUODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cLIENTEINDIVIDUODataGridView.DataSource = this.cLIENTEINDIVIDUOBindingSource;
            this.cLIENTEINDIVIDUODataGridView.Location = new System.Drawing.Point(34, 48);
            this.cLIENTEINDIVIDUODataGridView.Name = "cLIENTEINDIVIDUODataGridView";
            this.cLIENTEINDIVIDUODataGridView.Size = new System.Drawing.Size(414, 220);
            this.cLIENTEINDIVIDUODataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CUIT";
            this.dataGridViewTextBoxColumn4.HeaderText = "CUIT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MAIL";
            this.dataGridViewTextBoxColumn5.HeaderText = "MAIL";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn6.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn7.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.cLIENTEINDIVIDUOBindingNavigator);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(nOMBRELabel);
            this.groupBox1.Controls.Add(this.nOMBRETextBox);
            this.groupBox1.Controls.Add(aPELLIDOLabel);
            this.groupBox1.Controls.Add(this.aPELLIDOTextBox);
            this.groupBox1.Controls.Add(cUITLabel);
            this.groupBox1.Controls.Add(mAILLabel);
            this.groupBox1.Controls.Add(this.mAILTextBox);
            this.groupBox1.Controls.Add(tELEFONOLabel);
            this.groupBox1.Controls.Add(this.tELEFONOTextBox);
            this.groupBox1.Controls.Add(dIRECCIONLabel);
            this.groupBox1.Controls.Add(this.dIRECCIONTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTES";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "CUIT", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(108, 167);
            this.maskedTextBox1.Mask = "99-99999999-9";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(108, 83);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDTextBox.TabIndex = 1;
            this.iDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iDTextBox_KeyPress);
            // 
            // nOMBRETextBox
            // 
            this.nOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "NOMBRE", true));
            this.nOMBRETextBox.Location = new System.Drawing.Point(108, 111);
            this.nOMBRETextBox.Name = "nOMBRETextBox";
            this.nOMBRETextBox.Size = new System.Drawing.Size(100, 22);
            this.nOMBRETextBox.TabIndex = 3;
            this.nOMBRETextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nOMBRETextBox_KeyPress);
            // 
            // aPELLIDOTextBox
            // 
            this.aPELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "APELLIDO", true));
            this.aPELLIDOTextBox.Location = new System.Drawing.Point(108, 139);
            this.aPELLIDOTextBox.Name = "aPELLIDOTextBox";
            this.aPELLIDOTextBox.Size = new System.Drawing.Size(100, 22);
            this.aPELLIDOTextBox.TabIndex = 5;
            this.aPELLIDOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aPELLIDOTextBox_KeyPress);
            // 
            // mAILTextBox
            // 
            this.mAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "MAIL", true));
            this.mAILTextBox.Location = new System.Drawing.Point(108, 195);
            this.mAILTextBox.Name = "mAILTextBox";
            this.mAILTextBox.Size = new System.Drawing.Size(100, 22);
            this.mAILTextBox.TabIndex = 9;
            this.mAILTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mAILTextBox_KeyPress);
            // 
            // tELEFONOTextBox
            // 
            this.tELEFONOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "TELEFONO", true));
            this.tELEFONOTextBox.Location = new System.Drawing.Point(108, 223);
            this.tELEFONOTextBox.Name = "tELEFONOTextBox";
            this.tELEFONOTextBox.Size = new System.Drawing.Size(100, 22);
            this.tELEFONOTextBox.TabIndex = 11;
            this.tELEFONOTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tELEFONOTextBox_KeyPress);
            // 
            // dIRECCIONTextBox
            // 
            this.dIRECCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEINDIVIDUOBindingSource, "DIRECCION", true));
            this.dIRECCIONTextBox.Location = new System.Drawing.Point(108, 251);
            this.dIRECCIONTextBox.Name = "dIRECCIONTextBox";
            this.dIRECCIONTextBox.Size = new System.Drawing.Size(100, 22);
            this.dIRECCIONTextBox.TabIndex = 13;
            this.dIRECCIONTextBox.TextChanged += new System.EventHandler(this.dIRECCIONTextBox_TextChanged);
            this.dIRECCIONTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dIRECCIONTextBox_KeyPress);
            // 
            // tbcClienteEmpresa
            // 
            this.tbcClienteEmpresa.AutoScroll = true;
            this.tbcClienteEmpresa.Controls.Add(this.groupBox4);
            this.tbcClienteEmpresa.Controls.Add(this.groupBox3);
            this.tbcClienteEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbcClienteEmpresa.Name = "tbcClienteEmpresa";
            this.tbcClienteEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbcClienteEmpresa.Size = new System.Drawing.Size(1023, 579);
            this.tbcClienteEmpresa.TabIndex = 1;
            this.tbcClienteEmpresa.Text = "Empresas";
            this.tbcClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // cLIENTEEMPRESABindingSource
            // 
            this.cLIENTEEMPRESABindingSource.DataMember = "CLIENTEEMPRESA";
            this.cLIENTEEMPRESABindingSource.DataSource = this.iNTEGRADORNETDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(8, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 181);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbcProducto
            // 
            this.tbcProducto.Location = new System.Drawing.Point(4, 25);
            this.tbcProducto.Name = "tbcProducto";
            this.tbcProducto.Size = new System.Drawing.Size(978, 397);
            this.tbcProducto.TabIndex = 2;
            this.tbcProducto.Text = "Productos";
            this.tbcProducto.UseVisualStyleBackColor = true;
            // 
            // cLIENTEEMPRESATableAdapter
            // 
            this.cLIENTEEMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // dIRECCIONTextBox1
            // 
            this.dIRECCIONTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEEMPRESABindingSource, "DIRECCION", true));
            this.dIRECCIONTextBox1.Location = new System.Drawing.Point(107, 234);
            this.dIRECCIONTextBox1.Name = "dIRECCIONTextBox1";
            this.dIRECCIONTextBox1.Size = new System.Drawing.Size(100, 22);
            this.dIRECCIONTextBox1.TabIndex = 13;
            // 
            // dIRECCIONLabel1
            // 
            dIRECCIONLabel1.AutoSize = true;
            dIRECCIONLabel1.Location = new System.Drawing.Point(16, 237);
            dIRECCIONLabel1.Name = "dIRECCIONLabel1";
            dIRECCIONLabel1.Size = new System.Drawing.Size(83, 16);
            dIRECCIONLabel1.TabIndex = 12;
            dIRECCIONLabel1.Text = "DIRECCION:";
            // 
            // tELEFONOTextBox1
            // 
            this.tELEFONOTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEEMPRESABindingSource, "TELEFONO", true));
            this.tELEFONOTextBox1.Location = new System.Drawing.Point(107, 206);
            this.tELEFONOTextBox1.Name = "tELEFONOTextBox1";
            this.tELEFONOTextBox1.Size = new System.Drawing.Size(100, 22);
            this.tELEFONOTextBox1.TabIndex = 11;
            // 
            // tELEFONOLabel1
            // 
            tELEFONOLabel1.AutoSize = true;
            tELEFONOLabel1.Location = new System.Drawing.Point(16, 209);
            tELEFONOLabel1.Name = "tELEFONOLabel1";
            tELEFONOLabel1.Size = new System.Drawing.Size(82, 16);
            tELEFONOLabel1.TabIndex = 10;
            tELEFONOLabel1.Text = "TELEFONO:";
            // 
            // mAILTextBox1
            // 
            this.mAILTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEEMPRESABindingSource, "MAIL", true));
            this.mAILTextBox1.Location = new System.Drawing.Point(107, 178);
            this.mAILTextBox1.Name = "mAILTextBox1";
            this.mAILTextBox1.Size = new System.Drawing.Size(100, 22);
            this.mAILTextBox1.TabIndex = 9;
            // 
            // mAILLabel1
            // 
            mAILLabel1.AutoSize = true;
            mAILLabel1.Location = new System.Drawing.Point(16, 181);
            mAILLabel1.Name = "mAILLabel1";
            mAILLabel1.Size = new System.Drawing.Size(40, 16);
            mAILLabel1.TabIndex = 8;
            mAILLabel1.Text = "MAIL:";
            // 
            // cUITTextBox
            // 
            this.cUITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEEMPRESABindingSource, "CUIT", true));
            this.cUITTextBox.Location = new System.Drawing.Point(107, 147);
            this.cUITTextBox.Name = "cUITTextBox";
            this.cUITTextBox.Size = new System.Drawing.Size(100, 22);
            this.cUITTextBox.TabIndex = 7;
            // 
            // cUITLabel1
            // 
            cUITLabel1.AutoSize = true;
            cUITLabel1.Location = new System.Drawing.Point(16, 153);
            cUITLabel1.Name = "cUITLabel1";
            cUITLabel1.Size = new System.Drawing.Size(41, 16);
            cUITLabel1.TabIndex = 6;
            cUITLabel1.Text = "CUIT:";
            // 
            // cONTACTOTextBox
            // 
            this.cONTACTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEEMPRESABindingSource, "CONTACTO", true));
            this.cONTACTOTextBox.Location = new System.Drawing.Point(107, 119);
            this.cONTACTOTextBox.Name = "cONTACTOTextBox";
            this.cONTACTOTextBox.Size = new System.Drawing.Size(100, 22);
            this.cONTACTOTextBox.TabIndex = 5;
            this.cONTACTOTextBox.TextChanged += new System.EventHandler(this.cONTACTOTextBox_TextChanged);
            // 
            // cONTACTOLabel
            // 
            cONTACTOLabel.AutoSize = true;
            cONTACTOLabel.Location = new System.Drawing.Point(16, 125);
            cONTACTOLabel.Name = "cONTACTOLabel";
            cONTACTOLabel.Size = new System.Drawing.Size(85, 16);
            cONTACTOLabel.TabIndex = 4;
            cONTACTOLabel.Text = "CONTACTO:";
            // 
            // nOMBRETextBox1
            // 
            this.nOMBRETextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEEMPRESABindingSource, "NOMBRE", true));
            this.nOMBRETextBox1.Location = new System.Drawing.Point(107, 94);
            this.nOMBRETextBox1.Name = "nOMBRETextBox1";
            this.nOMBRETextBox1.Size = new System.Drawing.Size(100, 22);
            this.nOMBRETextBox1.TabIndex = 3;
            this.nOMBRETextBox1.TextChanged += new System.EventHandler(this.nOMBRETextBox1_TextChanged);
            // 
            // nOMBRELabel1
            // 
            nOMBRELabel1.AutoSize = true;
            nOMBRELabel1.Location = new System.Drawing.Point(16, 97);
            nOMBRELabel1.Name = "nOMBRELabel1";
            nOMBRELabel1.Size = new System.Drawing.Size(69, 16);
            nOMBRELabel1.TabIndex = 2;
            nOMBRELabel1.Text = "NOMBRE:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBusqueda);
            this.groupBox5.Location = new System.Drawing.Point(6, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(248, 90);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BUSQUEDA";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(97, 12);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(133, 22);
            this.textBusqueda.TabIndex = 2;
            this.textBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBusqueda_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar/Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(579, 33);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // VER
            // 
            this.VER.Location = new System.Drawing.Point(285, 33);
            this.VER.Name = "VER";
            this.VER.Size = new System.Drawing.Size(156, 23);
            this.VER.TabIndex = 18;
            this.VER.Text = "LISTA DE EMPRESAS";
            this.VER.UseVisualStyleBackColor = true;
            this.VER.Click += new System.EventHandler(this.VER_Click);
            // 
            // cLIENTEEMPRESADataGridView
            // 
            this.cLIENTEEMPRESADataGridView.AutoGenerateColumns = false;
            this.cLIENTEEMPRESADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTEEMPRESADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.cLIENTEEMPRESADataGridView.DataSource = this.cLIENTEEMPRESABindingSource;
            this.cLIENTEEMPRESADataGridView.Location = new System.Drawing.Point(275, 62);
            this.cLIENTEEMPRESADataGridView.Name = "cLIENTEEMPRESADataGridView";
            this.cLIENTEEMPRESADataGridView.Size = new System.Drawing.Size(740, 220);
            this.cLIENTEEMPRESADataGridView.TabIndex = 0;
            this.cLIENTEEMPRESADataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cLIENTEEMPRESADataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn14.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn13.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MAIL";
            this.dataGridViewTextBoxColumn12.HeaderText = "MAIL";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CUIT";
            this.dataGridViewTextBoxColumn11.HeaderText = "CUIT";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CONTACTO";
            this.dataGridViewTextBoxColumn10.HeaderText = "CONTACTO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn9.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(44, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 41);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "AGREGAR EMPRESA";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.cLIENTEEMPRESADataGridView);
            this.groupBox4.Controls.Add(this.VER);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(nOMBRELabel1);
            this.groupBox4.Controls.Add(this.nOMBRETextBox1);
            this.groupBox4.Controls.Add(cONTACTOLabel);
            this.groupBox4.Controls.Add(this.cONTACTOTextBox);
            this.groupBox4.Controls.Add(cUITLabel1);
            this.groupBox4.Controls.Add(this.cUITTextBox);
            this.groupBox4.Controls.Add(mAILLabel1);
            this.groupBox4.Controls.Add(this.mAILTextBox1);
            this.groupBox4.Controls.Add(tELEFONOLabel1);
            this.groupBox4.Controls.Add(this.tELEFONOTextBox1);
            this.groupBox4.Controls.Add(dIRECCIONLabel1);
            this.groupBox4.Controls.Add(this.dIRECCIONTextBox1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1015, 387);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de las Empresas";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 632);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNTEGRADORNETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEINDIVIDUOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEINDIVIDUOBindingNavigator)).EndInit();
            this.cLIENTEINDIVIDUOBindingNavigator.ResumeLayout(false);
            this.cLIENTEINDIVIDUOBindingNavigator.PerformLayout();
            this.tbcPrincipal.ResumeLayout(false);
            this.tbcClienteIndividuo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEINDIVIDUODataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcClienteEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEEMPRESABindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEEMPRESADataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private INTEGRADORNETDataSet iNTEGRADORNETDataSet;
        private System.Windows.Forms.BindingSource cLIENTEINDIVIDUOBindingSource;
        private INTEGRADORNETDataSetTableAdapters.CLIENTEINDIVIDUOTableAdapter cLIENTEINDIVIDUOTableAdapter;
        private INTEGRADORNETDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLIENTEINDIVIDUOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cLIENTEINDIVIDUOBindingNavigatorSaveItem;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbcClienteIndividuo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tbcProducto;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nOMBRETextBox;
        private System.Windows.Forms.TextBox aPELLIDOTextBox;
        private System.Windows.Forms.TextBox mAILTextBox;
        private System.Windows.Forms.TextBox tELEFONOTextBox;
        private System.Windows.Forms.TextBox dIRECCIONTextBox;
        private System.Windows.Forms.DataGridView cLIENTEINDIVIDUODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TabPage tbcClienteEmpresa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource cLIENTEEMPRESABindingSource;
        private INTEGRADORNETDataSetTableAdapters.CLIENTEEMPRESATableAdapter cLIENTEEMPRESATableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView cLIENTEEMPRESADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button VER;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.TextBox nOMBRETextBox1;
        private System.Windows.Forms.TextBox cONTACTOTextBox;
        private System.Windows.Forms.TextBox cUITTextBox;
        private System.Windows.Forms.TextBox mAILTextBox1;
        private System.Windows.Forms.TextBox tELEFONOTextBox1;
        private System.Windows.Forms.TextBox dIRECCIONTextBox1;
    }
}

