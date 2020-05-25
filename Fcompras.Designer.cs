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
            System.Windows.Forms.Label idcompraLabel;
            System.Windows.Forms.Label idproveedorLabel;
            System.Windows.Forms.Label idtipopagoLabel;
            System.Windows.Forms.Label nfacturacLabel;
            System.Windows.Forms.Label fechapagoLabel;
            this.detallecomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetcompras = new Torres_Anibal_Parcial.DBDataSetcompras();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.comprasTableAdapter();
            this.tableAdapterManager = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.TableAdapterManager();
            this.detallecomprasTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.detallecomprasTableAdapter();
            this.idcompraLabel1 = new System.Windows.Forms.Label();
            this.idproveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtipopagoComboBox = new System.Windows.Forms.ComboBox();
            this.tipospagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nfacturacLabel1 = new System.Windows.Forms.Label();
            this.fechapagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.proveedoresTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.proveedoresTableAdapter();
            this.tipospagosTableAdapter = new Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.tipospagosTableAdapter();
            this.detallecomprasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detallecomprasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            idcompraLabel = new System.Windows.Forms.Label();
            idproveedorLabel = new System.Windows.Forms.Label();
            idtipopagoLabel = new System.Windows.Forms.Label();
            nfacturacLabel = new System.Windows.Forms.Label();
            fechapagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detallecomprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecomprasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecomprasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idcompraLabel
            // 
            idcompraLabel.AutoSize = true;
            idcompraLabel.Location = new System.Drawing.Point(47, 9);
            idcompraLabel.Name = "idcompraLabel";
            idcompraLabel.Size = new System.Drawing.Size(58, 13);
            idcompraLabel.TabIndex = 17;
            idcompraLabel.Text = "Nº Compra";
            // 
            // idproveedorLabel
            // 
            idproveedorLabel.AutoSize = true;
            idproveedorLabel.Location = new System.Drawing.Point(50, 67);
            idproveedorLabel.Name = "idproveedorLabel";
            idproveedorLabel.Size = new System.Drawing.Size(56, 13);
            idproveedorLabel.TabIndex = 19;
            idproveedorLabel.Text = "Proveedor";
            // 
            // idtipopagoLabel
            // 
            idtipopagoLabel.AutoSize = true;
            idtipopagoLabel.Location = new System.Drawing.Point(457, 70);
            idtipopagoLabel.Name = "idtipopagoLabel";
            idtipopagoLabel.Size = new System.Drawing.Size(71, 13);
            idtipopagoLabel.TabIndex = 21;
            idtipopagoLabel.Text = "Tipo de Pago";
            // 
            // nfacturacLabel
            // 
            nfacturacLabel.AutoSize = true;
            nfacturacLabel.Location = new System.Drawing.Point(255, 9);
            nfacturacLabel.Name = "nfacturacLabel";
            nfacturacLabel.Size = new System.Drawing.Size(97, 13);
            nfacturacLabel.TabIndex = 23;
            nfacturacLabel.Text = "Nº Factura Compra";
            // 
            // fechapagoLabel
            // 
            fechapagoLabel.AutoSize = true;
            fechapagoLabel.Location = new System.Drawing.Point(456, 8);
            fechapagoLabel.Name = "fechapagoLabel";
            fechapagoLabel.Size = new System.Drawing.Size(91, 13);
            fechapagoLabel.TabIndex = 25;
            fechapagoLabel.Text = "Fecha de Compra";
            // 
            // detallecomprasBindingSource
            // 
            this.detallecomprasBindingSource.DataMember = "detallecompras";
            this.detallecomprasBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // dBDataSetcompras
            // 
            this.dBDataSetcompras.DataSetName = "DBDataSetcompras";
            this.dBDataSetcompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(149, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 47);
            this.panel2.TabIndex = 17;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(89, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(19, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "de";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(160, 3);
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
            this.panel1.Controls.Add(this.lblTotalVenta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(553, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 43);
            this.panel1.TabIndex = 16;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(140, 17);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(46, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL:";
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
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.comprasTableAdapter = this.comprasTableAdapter;
            this.tableAdapterManager.dcompraTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.tipospagosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Torres_Anibal_Parcial.DBDataSetcomprasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detallecomprasTableAdapter
            // 
            this.detallecomprasTableAdapter.ClearBeforeFill = true;
            // 
            // idcompraLabel1
            // 
            this.idcompraLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idcompra", true));
            this.idcompraLabel1.Location = new System.Drawing.Point(119, 9);
            this.idcompraLabel1.Name = "idcompraLabel1";
            this.idcompraLabel1.Size = new System.Drawing.Size(92, 23);
            this.idcompraLabel1.TabIndex = 18;
            // 
            // idproveedorComboBox
            // 
            this.idproveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idproveedor", true));
            this.idproveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idproveedor", true));
            this.idproveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idproveedorComboBox.DisplayMember = "nombrep";
            this.idproveedorComboBox.FormattingEnabled = true;
            this.idproveedorComboBox.Location = new System.Drawing.Point(122, 64);
            this.idproveedorComboBox.Name = "idproveedorComboBox";
            this.idproveedorComboBox.Size = new System.Drawing.Size(200, 21);
            this.idproveedorComboBox.TabIndex = 20;
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
            this.idtipopagoComboBox.FormattingEnabled = true;
            this.idtipopagoComboBox.Location = new System.Drawing.Point(529, 67);
            this.idtipopagoComboBox.Name = "idtipopagoComboBox";
            this.idtipopagoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idtipopagoComboBox.TabIndex = 22;
            this.idtipopagoComboBox.ValueMember = "idtipopago";
            // 
            // tipospagosBindingSource
            // 
            this.tipospagosBindingSource.DataMember = "tipospagos";
            this.tipospagosBindingSource.DataSource = this.dBDataSetcompras;
            // 
            // nfacturacLabel1
            // 
            this.nfacturacLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "nfacturac", true));
            this.nfacturacLabel1.Location = new System.Drawing.Point(358, 9);
            this.nfacturacLabel1.Name = "nfacturacLabel1";
            this.nfacturacLabel1.Size = new System.Drawing.Size(46, 23);
            this.nfacturacLabel1.TabIndex = 24;
            // 
            // fechapagoDateTimePicker
            // 
            this.fechapagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.comprasBindingSource, "fechapago", true));
            this.fechapagoDateTimePicker.Location = new System.Drawing.Point(553, 2);
            this.fechapagoDateTimePicker.Name = "fechapagoDateTimePicker";
            this.fechapagoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechapagoDateTimePicker.TabIndex = 26;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tipospagosTableAdapter
            // 
            this.tipospagosTableAdapter.ClearBeforeFill = true;
            // 
            // detallecomprasBindingSource1
            // 
            this.detallecomprasBindingSource1.DataMember = "FK_dcompra_idcompra1";
            this.detallecomprasBindingSource1.DataSource = this.comprasBindingSource;
            // 
            // detallecomprasDataGridView
            // 
            this.detallecomprasDataGridView.AllowUserToAddRows = false;
            this.detallecomprasDataGridView.AllowUserToDeleteRows = false;
            this.detallecomprasDataGridView.AutoGenerateColumns = false;
            this.detallecomprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallecomprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.cantidad,
            this.precio,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.detallecomprasDataGridView.DataSource = this.detallecomprasBindingSource1;
            this.detallecomprasDataGridView.Location = new System.Drawing.Point(19, 106);
            this.detallecomprasDataGridView.Name = "detallecomprasDataGridView";
            this.detallecomprasDataGridView.ReadOnly = true;
            this.detallecomprasDataGridView.Size = new System.Drawing.Size(741, 255);
            this.detallecomprasDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idproducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "subtotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iddetallec";
            this.dataGridViewTextBoxColumn1.HeaderText = "iddetallec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idcompra";
            this.dataGridViewTextBoxColumn2.HeaderText = "idcompra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.Location = new System.Drawing.Point(19, 427);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 23);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Fcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 471);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.detallecomprasDataGridView);
            this.Controls.Add(idcompraLabel);
            this.Controls.Add(this.idcompraLabel1);
            this.Controls.Add(idproveedorLabel);
            this.Controls.Add(this.idproveedorComboBox);
            this.Controls.Add(idtipopagoLabel);
            this.Controls.Add(this.idtipopagoComboBox);
            this.Controls.Add(nfacturacLabel);
            this.Controls.Add(this.nfacturacLabel1);
            this.Controls.Add(fechapagoLabel);
            this.Controls.Add(this.fechapagoDateTimePicker);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fcompras";
            this.Text = "Fcompras";
            this.Load += new System.EventHandler(this.Fcompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detallecomprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetcompras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecomprasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallecomprasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSetcompras dBDataSetcompras;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private DBDataSetcomprasTableAdapters.comprasTableAdapter comprasTableAdapter;
        private DBDataSetcomprasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource detallecomprasBindingSource;
        private DBDataSetcomprasTableAdapters.detallecomprasTableAdapter detallecomprasTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idcompraLabel1;
        private System.Windows.Forms.ComboBox idproveedorComboBox;
        private System.Windows.Forms.ComboBox idtipopagoComboBox;
        private System.Windows.Forms.Label nfacturacLabel1;
        private System.Windows.Forms.DateTimePicker fechapagoDateTimePicker;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DBDataSetcomprasTableAdapters.proveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.BindingSource tipospagosBindingSource;
        private DBDataSetcomprasTableAdapters.tipospagosTableAdapter tipospagosTableAdapter;
        private System.Windows.Forms.BindingSource detallecomprasBindingSource1;
        private System.Windows.Forms.DataGridView detallecomprasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnVolver;
    }
}