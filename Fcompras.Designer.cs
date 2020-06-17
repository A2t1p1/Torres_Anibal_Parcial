namespace Torres_Anibal_Parcial
{
    partial class Fcompras
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
            System.Windows.Forms.Label idproveedorLabel;
            System.Windows.Forms.Label idtipopagoLabel;
            System.Windows.Forms.Label nfacturacLabel;
            System.Windows.Forms.Label fechapagoLabel;
            System.Windows.Forms.Label idtipoLabel;
            System.Windows.Forms.Label idcompraLabel;
            this.dBDataSetcompras = new Torres_Anibal_Parcial.DBDataSetcompras();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.comprasTableAdapter();
            this.tableAdapterManager = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.TableAdapterManager();
            this.proveedoresTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.proveedoresTableAdapter();
            this.tipospagosTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.tipospagosTableAdapter();
            this.idproveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtipopagoComboBox = new System.Windows.Forms.ComboBox();
            this.tipospagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nfacturacComboBox = new System.Windows.Forms.ComboBox();
            this.fechapagoComboBox = new System.Windows.Forms.ComboBox();
            this.idtipoComboBox = new System.Windows.Forms.ComboBox();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetcompras1 = new Torres_Anibal_Parcial.DBDataSetcompras();
            this.detallescomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallescomprasTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.detallescomprasTableAdapter();
            this.detallescomprasDataGridView = new System.Windows.Forms.DataGridView();
            this.tipodocumentoTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.tipodocumentoTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalcompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIvacompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumacompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlComprasGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            this.idcompraTextBox = new System.Windows.Forms.TextBox();
            this.dcompraTableAdapter1 = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.dcompraTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idproveedorLabel = new System.Windows.Forms.Label();
            idtipopagoLabel = new System.Windows.Forms.Label();
            nfacturacLabel = new System.Windows.Forms.Label();
            fechapagoLabel = new System.Windows.Forms.Label();
            idtipoLabel = new System.Windows.Forms.Label();
            idcompraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.pnlComprasGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // idproveedorLabel
            // 
            idproveedorLabel.AutoSize = true;
            idproveedorLabel.Location = new System.Drawing.Point(23, 66);
            idproveedorLabel.Name = "idproveedorLabel";
            idproveedorLabel.Size = new System.Drawing.Size(66, 13);
            idproveedorLabel.TabIndex = 3;
            idproveedorLabel.Text = "idproveedor:";
            // 
            // idtipopagoLabel
            // 
            idtipopagoLabel.AutoSize = true;
            idtipopagoLabel.Location = new System.Drawing.Point(491, 69);
            idtipopagoLabel.Name = "idtipopagoLabel";
            idtipopagoLabel.Size = new System.Drawing.Size(59, 13);
            idtipopagoLabel.TabIndex = 5;
            idtipopagoLabel.Text = "idtipopago:";
            // 
            // nfacturacLabel
            // 
            nfacturacLabel.AutoSize = true;
            nfacturacLabel.Location = new System.Drawing.Point(139, 10);
            nfacturacLabel.Name = "nfacturacLabel";
            nfacturacLabel.Size = new System.Drawing.Size(55, 13);
            nfacturacLabel.TabIndex = 7;
            nfacturacLabel.Text = "nfacturac:";
            // 
            // fechapagoLabel
            // 
            fechapagoLabel.AutoSize = true;
            fechapagoLabel.Location = new System.Drawing.Point(491, 15);
            fechapagoLabel.Name = "fechapagoLabel";
            fechapagoLabel.Size = new System.Drawing.Size(61, 13);
            fechapagoLabel.TabIndex = 9;
            fechapagoLabel.Text = "fechapago:";
            // 
            // idtipoLabel
            // 
            idtipoLabel.AutoSize = true;
            idtipoLabel.Location = new System.Drawing.Point(244, 72);
            idtipoLabel.Name = "idtipoLabel";
            idtipoLabel.Size = new System.Drawing.Size(35, 13);
            idtipoLabel.TabIndex = 11;
            idtipoLabel.Text = "idtipo:";
            // 
            // idcompraLabel
            // 
            idcompraLabel.AutoSize = true;
            idcompraLabel.Location = new System.Drawing.Point(23, 10);
            idcompraLabel.Name = "idcompraLabel";
            idcompraLabel.Size = new System.Drawing.Size(53, 13);
            idcompraLabel.TabIndex = 48;
            idcompraLabel.Text = "idcompra:";
            // 
            // dBDataSetcompras
            // 
            this.dBDataSetcompras.DataSetName = "DBDataSetcompras";
            this.dBDataSetcompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "compras";
            this.comprasBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.comprasTableAdapter = this.comprasTableAdapter;
            this.tableAdapterManager.dcompraTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.tipodocumentoTableAdapter = null;
            this.tableAdapterManager.tipospagosTableAdapter = this.tipospagosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tipospagosTableAdapter
            // 
            this.tipospagosTableAdapter.ClearBeforeFill = true;
            // 
            // idproveedorComboBox
            // 
            this.idproveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idproveedor", true));
            this.idproveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idproveedor", true));
            this.idproveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idproveedorComboBox.DisplayMember = "nombrep";
            this.idproveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idproveedorComboBox.FormattingEnabled = true;
            this.idproveedorComboBox.Location = new System.Drawing.Point(95, 63);
            this.idproveedorComboBox.Name = "idproveedorComboBox";
            this.idproveedorComboBox.Size = new System.Drawing.Size(121, 21);
            this.idproveedorComboBox.TabIndex = 4;
            this.idproveedorComboBox.ValueMember = "idproveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // idtipopagoComboBox
            // 
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.DataSource = this.tipospagosBindingSource;
            this.idtipopagoComboBox.DisplayMember = "tipopago";
            this.idtipopagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idtipopagoComboBox.FormattingEnabled = true;
            this.idtipopagoComboBox.Location = new System.Drawing.Point(563, 66);
            this.idtipopagoComboBox.Name = "idtipopagoComboBox";
            this.idtipopagoComboBox.Size = new System.Drawing.Size(121, 21);
            this.idtipopagoComboBox.TabIndex = 6;
            this.idtipopagoComboBox.ValueMember = "idtipopago";
            // 
            // tipospagosBindingSource
            // 
            this.tipospagosBindingSource.DataMember = "tipospagos";
            this.tipospagosBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // nfacturacComboBox
            // 
            this.nfacturacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "nfacturac", true));
            this.nfacturacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idcompra", true));
            this.nfacturacComboBox.DataSource = this.comprasBindingSource;
            this.nfacturacComboBox.DisplayMember = "nfacturac";
            this.nfacturacComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nfacturacComboBox.FormattingEnabled = true;
            this.nfacturacComboBox.Location = new System.Drawing.Point(211, 7);
            this.nfacturacComboBox.Name = "nfacturacComboBox";
            this.nfacturacComboBox.Size = new System.Drawing.Size(121, 21);
            this.nfacturacComboBox.TabIndex = 8;
            this.nfacturacComboBox.ValueMember = "idcompra";
            // 
            // fechapagoComboBox
            // 
            this.fechapagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "fechapago", true));
            this.fechapagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "fechapago", true));
            this.fechapagoComboBox.DataSource = this.comprasBindingSource;
            this.fechapagoComboBox.DisplayMember = "fechapago";
            this.fechapagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fechapagoComboBox.FormattingEnabled = true;
            this.fechapagoComboBox.Location = new System.Drawing.Point(563, 12);
            this.fechapagoComboBox.Name = "fechapagoComboBox";
            this.fechapagoComboBox.Size = new System.Drawing.Size(121, 21);
            this.fechapagoComboBox.TabIndex = 10;
            this.fechapagoComboBox.ValueMember = "fechapago";
            // 
            // idtipoComboBox
            // 
            this.idtipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idtipo", true));
            this.idtipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idtipo", true));
            this.idtipoComboBox.DataSource = this.tipodocumentoBindingSource;
            this.idtipoComboBox.DisplayMember = "tipo";
            this.idtipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idtipoComboBox.FormattingEnabled = true;
            this.idtipoComboBox.Location = new System.Drawing.Point(316, 69);
            this.idtipoComboBox.Name = "idtipoComboBox";
            this.idtipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.idtipoComboBox.TabIndex = 12;
            this.idtipoComboBox.ValueMember = "idtipo";
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "tipodocumento";
            this.tipodocumentoBindingSource.DataSource = this.dBDataSetcompras1;
            // 
            // dBDataSetcompras1
            // 
            this.dBDataSetcompras1.DataSetName = "DBDataSetcompras";
            this.dBDataSetcompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallescomprasBindingSource
            // 
            this.detallescomprasBindingSource.DataMember = "FK_dcompra_idcompra1";
            this.detallescomprasBindingSource.DataSource = this.comprasBindingSource;
            // 
            // detallescomprasTableAdapter
            // 
            this.detallescomprasTableAdapter.ClearBeforeFill = true;
            // 
            // detallescomprasDataGridView
            // 
            this.detallescomprasDataGridView.AllowUserToAddRows = false;
            this.detallescomprasDataGridView.AllowUserToDeleteRows = false;
            this.detallescomprasDataGridView.AutoGenerateColumns = false;
            this.detallescomprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallescomprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.idproducto,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.cantidad,
            this.precio,
            this.descuento,
            this.dataGridViewTextBoxColumn10});
            this.detallescomprasDataGridView.DataSource = this.detallescomprasBindingSource;
            this.detallescomprasDataGridView.Location = new System.Drawing.Point(12, 114);
            this.detallescomprasDataGridView.Name = "detallescomprasDataGridView";
            this.detallescomprasDataGridView.ReadOnly = true;
            this.detallescomprasDataGridView.Size = new System.Drawing.Size(672, 220);
            this.detallescomprasDataGridView.TabIndex = 12;
            this.detallescomprasDataGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.detallescomprasDataGridView_RowLeave);
            // 
            // tipodocumentoTableAdapter
            // 
            this.tipodocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(12, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 23;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(71, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(167, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(129, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(38, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(7, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalcompra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblIvacompra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSumacompra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(494, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 22;
            // 
            // lblTotalcompra
            // 
            this.lblTotalcompra.AutoSize = true;
            this.lblTotalcompra.Location = new System.Drawing.Point(142, 61);
            this.lblTotalcompra.Name = "lblTotalcompra";
            this.lblTotalcompra.Size = new System.Drawing.Size(46, 13);
            this.lblTotalcompra.TabIndex = 5;
            this.lblTotalcompra.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
            // 
            // lblIvacompra
            // 
            this.lblIvacompra.AutoSize = true;
            this.lblIvacompra.Location = new System.Drawing.Point(154, 36);
            this.lblIvacompra.Name = "lblIvacompra";
            this.lblIvacompra.Size = new System.Drawing.Size(34, 13);
            this.lblIvacompra.TabIndex = 3;
            this.lblIvacompra.Text = "00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IVA:";
            // 
            // lblSumacompra
            // 
            this.lblSumacompra.AutoSize = true;
            this.lblSumacompra.Location = new System.Drawing.Point(142, 12);
            this.lblSumacompra.Name = "lblSumacompra";
            this.lblSumacompra.Size = new System.Drawing.Size(46, 13);
            this.lblSumacompra.TabIndex = 1;
            this.lblSumacompra.Text = "0000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA:";
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Location = new System.Drawing.Point(228, 425);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(260, 49);
            this.pnlEdicion.TabIndex = 47;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(73, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlComprasGrid
            // 
            this.pnlComprasGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlComprasGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlComprasGrid.Location = new System.Drawing.Point(37, 362);
            this.pnlComprasGrid.Name = "pnlComprasGrid";
            this.pnlComprasGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlComprasGrid.TabIndex = 48;
            this.pnlComprasGrid.Visible = false;
            // 
            // btnQuitarProductosGrid
            // 
            this.btnQuitarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosGrid.Location = new System.Drawing.Point(52, 4);
            this.btnQuitarProductosGrid.Name = "btnQuitarProductosGrid";
            this.btnQuitarProductosGrid.Size = new System.Drawing.Size(31, 38);
            this.btnQuitarProductosGrid.TabIndex = 1;
            this.btnQuitarProductosGrid.Text = "-";
            this.btnQuitarProductosGrid.UseVisualStyleBackColor = true;
            this.btnQuitarProductosGrid.Click += new System.EventHandler(this.btnQuitarProductosGrid_Click);
            // 
            // btnAgregarProductosGrid
            // 
            this.btnAgregarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductosGrid.Location = new System.Drawing.Point(5, 4);
            this.btnAgregarProductosGrid.Name = "btnAgregarProductosGrid";
            this.btnAgregarProductosGrid.Size = new System.Drawing.Size(47, 38);
            this.btnAgregarProductosGrid.TabIndex = 0;
            this.btnAgregarProductosGrid.Text = "+";
            this.btnAgregarProductosGrid.UseVisualStyleBackColor = true;
            this.btnAgregarProductosGrid.Click += new System.EventHandler(this.btnAgregarProductosGrid_Click);
            // 
            // idcompraTextBox
            // 
            this.idcompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idcompra", true));
            this.idcompraTextBox.Location = new System.Drawing.Point(82, 7);
            this.idcompraTextBox.Name = "idcompraTextBox";
            this.idcompraTextBox.Size = new System.Drawing.Size(37, 20);
            this.idcompraTextBox.TabIndex = 49;
            // 
            // dcompraTableAdapter1
            // 
            this.dcompraTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idcompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "idcompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "iddetallec";
            this.dataGridViewTextBoxColumn2.HeaderText = "iddetallec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "idproducto";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn9.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn7.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn10.HeaderText = "subtotal";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Fcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 494);
            this.Controls.Add(idcompraLabel);
            this.Controls.Add(this.idcompraTextBox);
            this.Controls.Add(this.pnlComprasGrid);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detallescomprasDataGridView);
            this.Controls.Add(idproveedorLabel);
            this.Controls.Add(this.idproveedorComboBox);
            this.Controls.Add(idtipopagoLabel);
            this.Controls.Add(this.idtipopagoComboBox);
            this.Controls.Add(nfacturacLabel);
            this.Controls.Add(this.nfacturacComboBox);
            this.Controls.Add(fechapagoLabel);
            this.Controls.Add(this.fechapagoComboBox);
            this.Controls.Add(idtipoLabel);
            this.Controls.Add(this.idtipoComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Fcompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Fcompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlComprasGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSetcompras dBDataSetcompras;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private DBDataSetcomprasTableAdapters.comprasTableAdapter comprasTableAdapter;
        private DBDataSetcomprasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox idproveedorComboBox;
        private System.Windows.Forms.ComboBox idtipopagoComboBox;
        private System.Windows.Forms.ComboBox nfacturacComboBox;
        private System.Windows.Forms.ComboBox fechapagoComboBox;
        private System.Windows.Forms.ComboBox idtipoComboBox;
        private System.Windows.Forms.BindingSource detallescomprasBindingSource;
        private DBDataSetcomprasTableAdapters.detallescomprasTableAdapter detallescomprasTableAdapter;
        private DBDataSetcomprasTableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridView detallescomprasDataGridView;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DBDataSetcomprasTableAdapters.tipospagosTableAdapter tipospagosTableAdapter;
        private System.Windows.Forms.BindingSource tipospagosBindingSource;
        private DBDataSetcompras dBDataSetcompras1;
        private System.Windows.Forms.BindingSource tipodocumentoBindingSource;
        private DBDataSetcomprasTableAdapters.tipodocumentoTableAdapter tipodocumentoTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalcompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIvacompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumacompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlComprasGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
        private System.Windows.Forms.TextBox idcompraTextBox;
        private DBDataSetcomprasTableAdapters.dcompraTableAdapter dcompraTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}