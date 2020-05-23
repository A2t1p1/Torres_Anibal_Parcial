namespace Torres_Anibal_Parcial
{
    partial class FormVentas
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
            System.Windows.Forms.Label idproductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idusuarioLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label fechapagoLabel;
            System.Windows.Forms.Label idtipopagoLabel;
            System.Windows.Forms.Label nfvLabel;
            System.Windows.Forms.Label idventaLabel;
            System.Windows.Forms.Label totalLabel;
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Torres_Anibal_Parcial.DBDataSet();
            this.facturavventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleventasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.ventasTableAdapter();
            this.tableAdapterManager = new Torres_Anibal_Parcial.DBDataSetTableAdapters.TableAdapterManager();
            this.facturavTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.facturavTableAdapter();
            this.usuariosTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.usuariosTableAdapter();
            this.categoriasTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.categoriasTableAdapter();
            this.productosTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.productosTableAdapter();
            this.detalleventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleventasTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.detalleventasTableAdapter();
            this.idproductoComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.idusuarioComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.fechapagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idtipopagoComboBox = new System.Windows.Forms.ComboBox();
            this.tipospagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet1 = new Torres_Anibal_Parcial.DBDataSet();
            this.tipospagosTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.tipospagosTableAdapter();
            this.nfvTextBox = new System.Windows.Forms.TextBox();
            this.idventaTextBox = new System.Windows.Forms.TextBox();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            idproductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idusuarioLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            fechapagoLabel = new System.Windows.Forms.Label();
            idtipopagoLabel = new System.Windows.Forms.Label();
            nfvLabel = new System.Windows.Forms.Label();
            idventaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturavventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleventasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // idproductoLabel
            // 
            idproductoLabel.AutoSize = true;
            idproductoLabel.Location = new System.Drawing.Point(27, 73);
            idproductoLabel.Name = "idproductoLabel";
            idproductoLabel.Size = new System.Drawing.Size(60, 13);
            idproductoLabel.TabIndex = 23;
            idproductoLabel.Text = "idproducto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(239, 69);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 27;
            descripcionLabel.Text = "descripcion:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(450, 71);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(51, 13);
            cantidadLabel.TabIndex = 29;
            cantidadLabel.Text = "cantidad:";
            // 
            // idusuarioLabel
            // 
            idusuarioLabel.AutoSize = true;
            idusuarioLabel.Location = new System.Drawing.Point(26, 121);
            idusuarioLabel.Name = "idusuarioLabel";
            idusuarioLabel.Size = new System.Drawing.Size(52, 13);
            idusuarioLabel.TabIndex = 31;
            idusuarioLabel.Text = "idusuario:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(239, 124);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 33;
            precioLabel.Text = "precio:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(453, 124);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(47, 13);
            subtotalLabel.TabIndex = 35;
            subtotalLabel.Text = "subtotal:";
            // 
            // fechapagoLabel
            // 
            fechapagoLabel.AutoSize = true;
            fechapagoLabel.Location = new System.Drawing.Point(27, 171);
            fechapagoLabel.Name = "fechapagoLabel";
            fechapagoLabel.Size = new System.Drawing.Size(61, 13);
            fechapagoLabel.TabIndex = 38;
            fechapagoLabel.Text = "fechapago:";
            // 
            // idtipopagoLabel
            // 
            idtipopagoLabel.AutoSize = true;
            idtipopagoLabel.Location = new System.Drawing.Point(309, 166);
            idtipopagoLabel.Name = "idtipopagoLabel";
            idtipopagoLabel.Size = new System.Drawing.Size(59, 13);
            idtipopagoLabel.TabIndex = 42;
            idtipopagoLabel.Text = "idtipopago:";
            // 
            // nfvLabel
            // 
            nfvLabel.AutoSize = true;
            nfvLabel.Location = new System.Drawing.Point(476, 33);
            nfvLabel.Name = "nfvLabel";
            nfvLabel.Size = new System.Drawing.Size(25, 13);
            nfvLabel.TabIndex = 44;
            nfvLabel.Text = "nfv:";
            // 
            // idventaLabel
            // 
            idventaLabel.AutoSize = true;
            idventaLabel.Location = new System.Drawing.Point(42, 36);
            idventaLabel.Name = "idventaLabel";
            idventaLabel.Size = new System.Drawing.Size(45, 13);
            idventaLabel.TabIndex = 45;
            idventaLabel.Text = "idventa:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(564, 315);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(30, 13);
            totalLabel.TabIndex = 46;
            totalLabel.Text = "total:";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturavventasBindingSource
            // 
            this.facturavventasBindingSource.DataMember = "facturav_ventas";
            this.facturavventasBindingSource.DataSource = this.facturavBindingSource;
            // 
            // facturavBindingSource
            // 
            this.facturavBindingSource.DataMember = "facturav";
            this.facturavBindingSource.DataSource = this.dBDataSet;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "FK_productos_categorias";
            this.productosBindingSource.DataSource = this.categoriasBindingSource;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.dBDataSet;
            // 
            // detalleventasDataGridView
            // 
            this.detalleventasDataGridView.AllowUserToAddRows = false;
            this.detalleventasDataGridView.AllowUserToDeleteRows = false;
            this.detalleventasDataGridView.AutoGenerateColumns = false;
            this.detalleventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleventasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.detalleventasDataGridView.DataSource = this.detalleventasBindingSource1;
            this.detalleventasDataGridView.Location = new System.Drawing.Point(12, 204);
            this.detalleventasDataGridView.Name = "detalleventasDataGridView";
            this.detalleventasDataGridView.ReadOnly = true;
            this.detalleventasDataGridView.Size = new System.Drawing.Size(509, 182);
            this.detalleventasDataGridView.TabIndex = 21;
            this.detalleventasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalleventasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idventa";
            this.dataGridViewTextBoxColumn1.HeaderText = "idventa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn12.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn11.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn2.HeaderText = "total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fechapago";
            this.dataGridViewTextBoxColumn3.HeaderText = "fechapago";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // detalleventasBindingSource1
            // 
            this.detalleventasBindingSource1.DataMember = "detalleventas";
            this.detalleventasBindingSource1.DataSource = this.dBDataSet;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dBDataSet;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.empleadosTableAdapter = null;
            this.tableAdapterManager.facturavTableAdapter = this.facturavTableAdapter;
            this.tableAdapterManager.pagosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.tipospagosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Torres_Anibal_Parcial.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.ventasTableAdapter = this.ventasTableAdapter;
            // 
            // facturavTableAdapter
            // 
            this.facturavTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // detalleventasBindingSource
            // 
            this.detalleventasBindingSource.DataSource = this.dBDataSet;
            this.detalleventasBindingSource.Position = 0;
            // 
            // detalleventasTableAdapter
            // 
            this.detalleventasTableAdapter.ClearBeforeFill = true;
            // 
            // idproductoComboBox
            // 
            this.idproductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idproducto", true));
            this.idproductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idproducto", true));
            this.idproductoComboBox.DataSource = this.productosBindingSource;
            this.idproductoComboBox.DisplayMember = "nombre";
            this.idproductoComboBox.FormattingEnabled = true;
            this.idproductoComboBox.Location = new System.Drawing.Point(93, 68);
            this.idproductoComboBox.Name = "idproductoComboBox";
            this.idproductoComboBox.Size = new System.Drawing.Size(121, 21);
            this.idproductoComboBox.TabIndex = 24;
            this.idproductoComboBox.ValueMember = "idproducto";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(309, 66);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descripcionTextBox.TabIndex = 28;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleventasBindingSource1, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(520, 68);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(56, 20);
            this.cantidadTextBox.TabIndex = 30;
            // 
            // idusuarioComboBox
            // 
            this.idusuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idusuario", true));
            this.idusuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idusuario", true));
            this.idusuarioComboBox.DataSource = this.usuariosBindingSource;
            this.idusuarioComboBox.DisplayMember = "nombre";
            this.idusuarioComboBox.FormattingEnabled = true;
            this.idusuarioComboBox.Location = new System.Drawing.Point(96, 118);
            this.idusuarioComboBox.Name = "idusuarioComboBox";
            this.idusuarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.idusuarioComboBox.TabIndex = 32;
            this.idusuarioComboBox.ValueMember = "idusuario";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(309, 121);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(46, 20);
            this.precioTextBox.TabIndex = 34;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(523, 121);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(53, 20);
            this.subtotalTextBox.TabIndex = 36;
            // 
            // fechapagoDateTimePicker
            // 
            this.fechapagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.facturavBindingSource, "fechapago", true));
            this.fechapagoDateTimePicker.Location = new System.Drawing.Point(93, 164);
            this.fechapagoDateTimePicker.Name = "fechapagoDateTimePicker";
            this.fechapagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechapagoDateTimePicker.TabIndex = 39;
            // 
            // idtipopagoComboBox
            // 
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturavBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facturavBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.DataSource = this.tipospagosBindingSource;
            this.idtipopagoComboBox.DisplayMember = "tipopago";
            this.idtipopagoComboBox.FormattingEnabled = true;
            this.idtipopagoComboBox.Location = new System.Drawing.Point(376, 163);
            this.idtipopagoComboBox.Name = "idtipopagoComboBox";
            this.idtipopagoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idtipopagoComboBox.TabIndex = 43;
            this.idtipopagoComboBox.ValueMember = "idtipopago";
            // 
            // tipospagosBindingSource
            // 
            this.tipospagosBindingSource.DataMember = "tipospagos";
            this.tipospagosBindingSource.DataSource = this.dBDataSet1;
            // 
            // dBDataSet1
            // 
            this.dBDataSet1.DataSetName = "DBDataSet";
            this.dBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipospagosTableAdapter
            // 
            this.tipospagosTableAdapter.ClearBeforeFill = true;
            // 
            // nfvTextBox
            // 
            this.nfvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturavventasBindingSource, "nfv", true));
            this.nfvTextBox.Location = new System.Drawing.Point(507, 30);
            this.nfvTextBox.Name = "nfvTextBox";
            this.nfvTextBox.Size = new System.Drawing.Size(48, 20);
            this.nfvTextBox.TabIndex = 45;
            // 
            // idventaTextBox
            // 
            this.idventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idventa", true));
            this.idventaTextBox.Location = new System.Drawing.Point(93, 33);
            this.idventaTextBox.Name = "idventaTextBox";
            this.idventaTextBox.Size = new System.Drawing.Size(37, 20);
            this.idventaTextBox.TabIndex = 46;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturavBindingSource, "total", true));
            this.lblregistroxden.Location = new System.Drawing.Point(566, 388);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(58, 23);
            this.lblregistroxden.TabIndex = 44;
            this.lblregistroxden.Text = "label1";
            // 
            // txttotal
            // 
            this.txttotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturavBindingSource, "total", true));
            this.txttotal.Location = new System.Drawing.Point(600, 312);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(39, 20);
            this.txttotal.TabIndex = 47;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 431);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(idventaLabel);
            this.Controls.Add(this.idventaTextBox);
            this.Controls.Add(nfvLabel);
            this.Controls.Add(this.nfvTextBox);
            this.Controls.Add(this.lblregistroxden);
            this.Controls.Add(fechapagoLabel);
            this.Controls.Add(this.fechapagoDateTimePicker);
            this.Controls.Add(idtipopagoLabel);
            this.Controls.Add(this.idtipopagoComboBox);
            this.Controls.Add(idproductoLabel);
            this.Controls.Add(this.idproductoComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(idusuarioLabel);
            this.Controls.Add(this.idusuarioComboBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.detalleventasDataGridView);
            this.Name = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturavventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleventasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DBDataSetTableAdapters.ventasTableAdapter ventasTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DBDataSetTableAdapters.facturavTableAdapter facturavTableAdapter;
        private System.Windows.Forms.BindingSource facturavBindingSource;
        private System.Windows.Forms.BindingSource facturavventasBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DBDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DBDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DBDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource detalleventasBindingSource;
        private DBDataSetTableAdapters.detalleventasTableAdapter detalleventasTableAdapter;
        private System.Windows.Forms.BindingSource detalleventasBindingSource1;
        private System.Windows.Forms.DataGridView detalleventasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox idproductoComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ComboBox idusuarioComboBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.DateTimePicker fechapagoDateTimePicker;
        private System.Windows.Forms.ComboBox idtipopagoComboBox;
        private DBDataSet dBDataSet1;
        private System.Windows.Forms.BindingSource tipospagosBindingSource;
        private DBDataSetTableAdapters.tipospagosTableAdapter tipospagosTableAdapter;
        private System.Windows.Forms.TextBox nfvTextBox;
        private System.Windows.Forms.TextBox idventaTextBox;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.TextBox txttotal;
    }
}