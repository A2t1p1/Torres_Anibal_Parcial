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
            System.Windows.Forms.Label idventaLabel;
            System.Windows.Forms.Label nfvvLabel;
            System.Windows.Forms.Label idusuarioLabel;
            System.Windows.Forms.Label idproductoLabel;
            System.Windows.Forms.Label idtipopagoLabel;
            System.Windows.Forms.Label fechaventaLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Torres_Anibal_Parcial.DBDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipospagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalledeventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.ventasTableAdapter();
            this.tableAdapterManager = new Torres_Anibal_Parcial.DBDataSetTableAdapters.TableAdapterManager();
            this.productosTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.productosTableAdapter();
            this.tipospagosTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.tipospagosTableAdapter();
            this.usuariosTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.usuariosTableAdapter();
            this.detalledeventaTableAdapter = new Torres_Anibal_Parcial.DBDataSetTableAdapters.detalledeventaTableAdapter();
            this.detalledeventaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idventaLabel1 = new System.Windows.Forms.Label();
            this.nfvvLabel1 = new System.Windows.Forms.Label();
            this.idusuarioComboBox = new System.Windows.Forms.ComboBox();
            this.idproductoComboBox = new System.Windows.Forms.ComboBox();
            this.idtipopagoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaventaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            idventaLabel = new System.Windows.Forms.Label();
            nfvvLabel = new System.Windows.Forms.Label();
            idusuarioLabel = new System.Windows.Forms.Label();
            idproductoLabel = new System.Windows.Forms.Label();
            idtipopagoLabel = new System.Windows.Forms.Label();
            fechaventaLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalledeventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalledeventaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblregistroxden);
            this.panel2.Controls.Add(this.btnUltimo);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.btnPrimero);
            this.panel2.Location = new System.Drawing.Point(10, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 49);
            this.panel2.TabIndex = 17;
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
            this.panel1.Location = new System.Drawing.Point(447, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 92);
            this.panel1.TabIndex = 16;
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(142, 61);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(46, 13);
            this.lblTotalVenta.TabIndex = 5;
            this.lblTotalVenta.Text = "0000.00";
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
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dBDataSet;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.dBDataSet;
            // 
            // tipospagosBindingSource
            // 
            this.tipospagosBindingSource.DataMember = "tipospagos";
            this.tipospagosBindingSource.DataSource = this.dBDataSet;
            // 
            // detalledeventaBindingSource
            // 
            this.detalledeventaBindingSource.DataMember = "detalledeventa";
            this.detalledeventaBindingSource.DataSource = this.dBDataSet;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.dventaTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.tipospagosTableAdapter = this.tipospagosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Torres_Anibal_Parcial.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            this.tableAdapterManager.ventasTableAdapter = this.ventasTableAdapter;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tipospagosTableAdapter
            // 
            this.tipospagosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // detalledeventaTableAdapter
            // 
            this.detalledeventaTableAdapter.ClearBeforeFill = true;
            // 
            // detalledeventaDataGridView
            // 
            this.detalledeventaDataGridView.AllowUserToAddRows = false;
            this.detalledeventaDataGridView.AllowUserToDeleteRows = false;
            this.detalledeventaDataGridView.AutoGenerateColumns = false;
            this.detalledeventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalledeventaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idproducto,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.cantidad,
            this.precio,
            this.subtotal});
            this.detalledeventaDataGridView.DataSource = this.detalledeventaBindingSource;
            this.detalledeventaDataGridView.Location = new System.Drawing.Point(10, 193);
            this.detalledeventaDataGridView.Name = "detalledeventaDataGridView";
            this.detalledeventaDataGridView.ReadOnly = true;
            this.detalledeventaDataGridView.Size = new System.Drawing.Size(637, 125);
            this.detalledeventaDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "iddetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "iddetalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "idproducto";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idventa";
            this.dataGridViewTextBoxColumn2.HeaderText = "idventa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idproducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn7.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fechaventa";
            this.dataGridViewTextBoxColumn8.HeaderText = "fechaventa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 70;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 70;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // idventaLabel
            // 
            idventaLabel.AutoSize = true;
            idventaLabel.Location = new System.Drawing.Point(112, 24);
            idventaLabel.Name = "idventaLabel";
            idventaLabel.Size = new System.Drawing.Size(45, 13);
            idventaLabel.TabIndex = 28;
            idventaLabel.Text = "idventa:";
            // 
            // idventaLabel1
            // 
            this.idventaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idventa", true));
            this.idventaLabel1.Location = new System.Drawing.Point(182, 24);
            this.idventaLabel1.Name = "idventaLabel1";
            this.idventaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idventaLabel1.TabIndex = 29;
            this.idventaLabel1.Text = "label1";
            // 
            // nfvvLabel
            // 
            nfvvLabel.AutoSize = true;
            nfvvLabel.Location = new System.Drawing.Point(112, 47);
            nfvvLabel.Name = "nfvvLabel";
            nfvvLabel.Size = new System.Drawing.Size(31, 13);
            nfvvLabel.TabIndex = 30;
            nfvvLabel.Text = "nfvv:";
            // 
            // nfvvLabel1
            // 
            this.nfvvLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "nfvv", true));
            this.nfvvLabel1.Location = new System.Drawing.Point(182, 47);
            this.nfvvLabel1.Name = "nfvvLabel1";
            this.nfvvLabel1.Size = new System.Drawing.Size(200, 23);
            this.nfvvLabel1.TabIndex = 31;
            this.nfvvLabel1.Text = "label1";
            // 
            // idusuarioLabel
            // 
            idusuarioLabel.AutoSize = true;
            idusuarioLabel.Location = new System.Drawing.Point(112, 76);
            idusuarioLabel.Name = "idusuarioLabel";
            idusuarioLabel.Size = new System.Drawing.Size(52, 13);
            idusuarioLabel.TabIndex = 32;
            idusuarioLabel.Text = "idusuario:";
            // 
            // idusuarioComboBox
            // 
            this.idusuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idusuario", true));
            this.idusuarioComboBox.FormattingEnabled = true;
            this.idusuarioComboBox.Location = new System.Drawing.Point(182, 73);
            this.idusuarioComboBox.Name = "idusuarioComboBox";
            this.idusuarioComboBox.Size = new System.Drawing.Size(200, 21);
            this.idusuarioComboBox.TabIndex = 33;
            // 
            // idproductoLabel
            // 
            idproductoLabel.AutoSize = true;
            idproductoLabel.Location = new System.Drawing.Point(112, 103);
            idproductoLabel.Name = "idproductoLabel";
            idproductoLabel.Size = new System.Drawing.Size(60, 13);
            idproductoLabel.TabIndex = 34;
            idproductoLabel.Text = "idproducto:";
            // 
            // idproductoComboBox
            // 
            this.idproductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idproducto", true));
            this.idproductoComboBox.FormattingEnabled = true;
            this.idproductoComboBox.Location = new System.Drawing.Point(182, 100);
            this.idproductoComboBox.Name = "idproductoComboBox";
            this.idproductoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idproductoComboBox.TabIndex = 35;
            // 
            // idtipopagoLabel
            // 
            idtipopagoLabel.AutoSize = true;
            idtipopagoLabel.Location = new System.Drawing.Point(112, 130);
            idtipopagoLabel.Name = "idtipopagoLabel";
            idtipopagoLabel.Size = new System.Drawing.Size(59, 13);
            idtipopagoLabel.TabIndex = 36;
            idtipopagoLabel.Text = "idtipopago:";
            // 
            // idtipopagoComboBox
            // 
            this.idtipopagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idtipopago", true));
            this.idtipopagoComboBox.FormattingEnabled = true;
            this.idtipopagoComboBox.Location = new System.Drawing.Point(182, 127);
            this.idtipopagoComboBox.Name = "idtipopagoComboBox";
            this.idtipopagoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idtipopagoComboBox.TabIndex = 37;
            // 
            // fechaventaLabel
            // 
            fechaventaLabel.AutoSize = true;
            fechaventaLabel.Location = new System.Drawing.Point(112, 158);
            fechaventaLabel.Name = "fechaventaLabel";
            fechaventaLabel.Size = new System.Drawing.Size(64, 13);
            fechaventaLabel.TabIndex = 38;
            fechaventaLabel.Text = "fechaventa:";
            // 
            // fechaventaDateTimePicker
            // 
            this.fechaventaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "fechaventa", true));
            this.fechaventaDateTimePicker.Location = new System.Drawing.Point(182, 154);
            this.fechaventaDateTimePicker.Name = "fechaventaDateTimePicker";
            this.fechaventaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaventaDateTimePicker.TabIndex = 39;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 444);
            this.Controls.Add(idventaLabel);
            this.Controls.Add(this.idventaLabel1);
            this.Controls.Add(nfvvLabel);
            this.Controls.Add(this.nfvvLabel1);
            this.Controls.Add(idusuarioLabel);
            this.Controls.Add(this.idusuarioComboBox);
            this.Controls.Add(idproductoLabel);
            this.Controls.Add(this.idproductoComboBox);
            this.Controls.Add(idtipopagoLabel);
            this.Controls.Add(this.idtipopagoComboBox);
            this.Controls.Add(fechaventaLabel);
            this.Controls.Add(this.fechaventaDateTimePicker);
            this.Controls.Add(this.detalledeventaDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipospagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalledeventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalledeventaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DBDataSetTableAdapters.ventasTableAdapter ventasTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DBDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DBDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DBDataSetTableAdapters.tipospagosTableAdapter tipospagosTableAdapter;
        private System.Windows.Forms.BindingSource tipospagosBindingSource;
        private System.Windows.Forms.BindingSource detalledeventaBindingSource;
        private DBDataSetTableAdapters.detalledeventaTableAdapter detalledeventaTableAdapter;
        private System.Windows.Forms.DataGridView detalledeventaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label idventaLabel1;
        private System.Windows.Forms.Label nfvvLabel1;
        private System.Windows.Forms.ComboBox idusuarioComboBox;
        private System.Windows.Forms.ComboBox idproductoComboBox;
        private System.Windows.Forms.ComboBox idtipopagoComboBox;
        private System.Windows.Forms.DateTimePicker fechaventaDateTimePicker;
    }
}