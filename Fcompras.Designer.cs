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
            System.Windows.Forms.Label idcompraLabel1;
            this.dBDataSetcompras = new Torres_Anibal_Parcial.DBDataSetcompras();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.comprasTableAdapter();
            this.tableAdapterManager = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.TableAdapterManager();
            this.idproveedorComboBox = new System.Windows.Forms.ComboBox();
            this.idtipopagoComboBox = new System.Windows.Forms.ComboBox();
            this.nfacturacComboBox = new System.Windows.Forms.ComboBox();
            this.fechapagoComboBox = new System.Windows.Forms.ComboBox();
            this.idtipoComboBox = new System.Windows.Forms.ComboBox();
            this.detallescomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallescomprasTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.detallescomprasTableAdapter();
            this.detallescomprasDataGridView = new System.Windows.Forms.DataGridView();
            this.idcompraLabel2 = new System.Windows.Forms.Label();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.proveedoresTableAdapter();
            this.tipospagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipospagosTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.tipospagosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBDataSetcompras1 = new Torres_Anibal_Parcial.DBDataSetcompras();
            this.tipodocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            idproveedorLabel = new System.Windows.Forms.Label();
            idtipopagoLabel = new System.Windows.Forms.Label();
            nfacturacLabel = new System.Windows.Forms.Label();
            fechapagoLabel = new System.Windows.Forms.Label();
            idtipoLabel = new System.Windows.Forms.Label();
            idcompraLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // idproveedorLabel
            // 
            idproveedorLabel.AutoSize = true;
            idproveedorLabel.Location = new System.Drawing.Point(23, 66);
            idproveedorLabel.Name = "idproveedorLabel";
            idproveedorLabel.Size = new System.Drawing.Size(66, 13);
            idproveedorLabel.TabIndex = 3;
            idproveedorLabel.Text = "idproveedor:";
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
            // idtipopagoLabel
            // 
            idtipopagoLabel.AutoSize = true;
            idtipopagoLabel.Location = new System.Drawing.Point(491, 69);
            idtipopagoLabel.Name = "idtipopagoLabel";
            idtipopagoLabel.Size = new System.Drawing.Size(59, 13);
            idtipopagoLabel.TabIndex = 5;
            idtipopagoLabel.Text = "idtipopago:";
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
            // nfacturacLabel
            // 
            nfacturacLabel.AutoSize = true;
            nfacturacLabel.Location = new System.Drawing.Point(139, 10);
            nfacturacLabel.Name = "nfacturacLabel";
            nfacturacLabel.Size = new System.Drawing.Size(55, 13);
            nfacturacLabel.TabIndex = 7;
            nfacturacLabel.Text = "nfacturac:";
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
            // fechapagoLabel
            // 
            fechapagoLabel.AutoSize = true;
            fechapagoLabel.Location = new System.Drawing.Point(491, 15);
            fechapagoLabel.Name = "fechapagoLabel";
            fechapagoLabel.Size = new System.Drawing.Size(61, 13);
            fechapagoLabel.TabIndex = 9;
            fechapagoLabel.Text = "fechapago:";
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
            // idtipoLabel
            // 
            idtipoLabel.AutoSize = true;
            idtipoLabel.Location = new System.Drawing.Point(244, 72);
            idtipoLabel.Name = "idtipoLabel";
            idtipoLabel.Size = new System.Drawing.Size(35, 13);
            idtipoLabel.TabIndex = 11;
            idtipoLabel.Text = "idtipo:";
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
            this.dataGridViewTextBoxColumn3,
            this.cantidad,
            this.descuento,
            this.precio,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.detallescomprasDataGridView.DataSource = this.detallescomprasBindingSource;
            this.detallescomprasDataGridView.Location = new System.Drawing.Point(12, 114);
            this.detallescomprasDataGridView.Name = "detallescomprasDataGridView";
            this.detallescomprasDataGridView.ReadOnly = true;
            this.detallescomprasDataGridView.Size = new System.Drawing.Size(672, 220);
            this.detallescomprasDataGridView.TabIndex = 12;
            // 
            // idcompraLabel1
            // 
            idcompraLabel1.AutoSize = true;
            idcompraLabel1.Location = new System.Drawing.Point(14, 9);
            idcompraLabel1.Name = "idcompraLabel1";
            idcompraLabel1.Size = new System.Drawing.Size(53, 13);
            idcompraLabel1.TabIndex = 12;
            idcompraLabel1.Text = "idcompra:";
            // 
            // idcompraLabel2
            // 
            this.idcompraLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idcompra", true));
            this.idcompraLabel2.Location = new System.Drawing.Point(73, 9);
            this.idcompraLabel2.Name = "idcompraLabel2";
            this.idcompraLabel2.Size = new System.Drawing.Size(46, 23);
            this.idcompraLabel2.TabIndex = 13;
            this.idcompraLabel2.Text = "label1";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "proveedores";
            this.proveedoresBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tipospagosBindingSource
            // 
            this.tipospagosBindingSource.DataMember = "tipospagos";
            this.tipospagosBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // tipospagosTableAdapter
            // 
            this.tipospagosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idcompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "idcompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "iddetallec";
            this.dataGridViewTextBoxColumn2.HeaderText = "iddetallec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idproducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "idproducto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn9.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn10.HeaderText = "subtotal";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dBDataSetcompras1
            // 
            this.dBDataSetcompras1.DataSetName = "DBDataSetcompras";
            this.dBDataSetcompras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipodocumentoBindingSource
            // 
            this.tipodocumentoBindingSource.DataMember = "tipodocumento";
            this.tipodocumentoBindingSource.DataSource = this.dBDataSetcompras1;
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
            this.panel2.Location = new System.Drawing.Point(12, 375);
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
            // Fcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(idcompraLabel1);
            this.Controls.Add(this.idcompraLabel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallescomprasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentoBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label idcompraLabel2;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DBDataSetcomprasTableAdapters.tipospagosTableAdapter tipospagosTableAdapter;
        private System.Windows.Forms.BindingSource tipospagosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
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
    }
}