namespace Torres_Anibal_Parcial
{
    partial class Form1
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
            this.btnconvertir = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblde = new System.Windows.Forms.Label();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.lbla = new System.Windows.Forms.Label();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.cbde = new System.Windows.Forms.ComboBox();
            this.cba = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconvertir
            // 
            this.btnconvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconvertir.Location = new System.Drawing.Point(75, 228);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(85, 30);
            this.btnconvertir.TabIndex = 0;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.Btnconvertir_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(56, 68);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(137, 16);
            this.lbltipo.TabIndex = 1;
            this.lbltipo.Text = "Tipo de Conversor";
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblde.Location = new System.Drawing.Point(85, 148);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(28, 16);
            this.lblde.TabIndex = 2;
            this.lblde.Text = "De";
            // 
            // cbtipo
            // 
            this.cbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Location = new System.Drawing.Point(212, 65);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(121, 24);
            this.cbtipo.TabIndex = 5;
            this.cbtipo.SelectedIndexChanged += new System.EventHandler(this.Cbtipo_SelectedIndexChanged);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(282, 148);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(18, 16);
            this.lbla.TabIndex = 6;
            this.lbla.Text = "A";
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrar.Location = new System.Drawing.Point(279, 228);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(51, 16);
            this.lblmostrar.TabIndex = 7;
            this.lblmostrar.Text = "label4";
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(100, 21);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(266, 23);
            this.lbltitulo.TabIndex = 8;
            this.lbltitulo.Text = "Conversor de Almacenamiento y Divisas";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbde
            // 
            this.cbde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbde.FormattingEnabled = true;
            this.cbde.Location = new System.Drawing.Point(85, 164);
            this.cbde.Name = "cbde";
            this.cbde.Size = new System.Drawing.Size(121, 24);
            this.cbde.TabIndex = 9;
            // 
            // cba
            // 
            this.cba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cba.FormattingEnabled = true;
            this.cba.Location = new System.Drawing.Point(282, 164);
            this.cba.Name = "cba";
            this.cba.Size = new System.Drawing.Size(121, 24);
            this.cba.TabIndex = 10;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(196, 107);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 11;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.cba);
            this.Controls.Add(this.cbde);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.lblde);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.btnconvertir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Convertidor-Moneda-Almacenamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblmostrar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.ComboBox cbde;
        private System.Windows.Forms.ComboBox cba;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label1;
    }
}

