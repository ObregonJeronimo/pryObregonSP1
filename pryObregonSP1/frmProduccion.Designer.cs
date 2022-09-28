namespace pryObregonSP1
{
    partial class frmProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccion));
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCrear3 = new System.Windows.Forms.Button();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.lblIdentificador3 = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.cboCultivo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(115, 139);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 29);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCrear3
            // 
            this.btnCrear3.Location = new System.Drawing.Point(12, 139);
            this.btnCrear3.Name = "btnCrear3";
            this.btnCrear3.Size = new System.Drawing.Size(97, 29);
            this.btnCrear3.TabIndex = 7;
            this.btnCrear3.Text = "Crear Archivo";
            this.btnCrear3.UseVisualStyleBackColor = true;
            this.btnCrear3.Click += new System.EventHandler(this.btnCrear3_Click);
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Location = new System.Drawing.Point(42, 58);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(39, 13);
            this.lblCantidad1.TabIndex = 5;
            this.lblCantidad1.Text = "Cultivo";
            // 
            // lblIdentificador3
            // 
            this.lblIdentificador3.AutoSize = true;
            this.lblIdentificador3.Location = new System.Drawing.Point(28, 18);
            this.lblIdentificador3.Name = "lblIdentificador3";
            this.lblIdentificador3.Size = new System.Drawing.Size(53, 13);
            this.lblIdentificador3.TabIndex = 10;
            this.lblIdentificador3.Text = "Localidad";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(87, 12);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(87, 21);
            this.cboLocalidad.TabIndex = 11;
            // 
            // cboCultivo
            // 
            this.cboCultivo.FormattingEnabled = true;
            this.cboCultivo.Location = new System.Drawing.Point(87, 55);
            this.cboCultivo.Name = "cboCultivo";
            this.cboCultivo.Size = new System.Drawing.Size(87, 21);
            this.cboCultivo.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(87, 98);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cantidad";
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(223, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboCultivo);
            this.Controls.Add(this.cboLocalidad);
            this.Controls.Add(this.lblIdentificador3);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCrear3);
            this.Controls.Add(this.lblCantidad1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduccion";
            this.Text = "Producción";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCrear3;
        private System.Windows.Forms.Label lblCantidad1;
        private System.Windows.Forms.Label lblIdentificador3;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.ComboBox cboCultivo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
    }
}