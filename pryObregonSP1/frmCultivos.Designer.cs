namespace pryObregonSP1
{
    partial class frmCultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCultivos));
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.btnCrear2 = new System.Windows.Forms.Button();
            this.txtCultivo1 = new System.Windows.Forms.TextBox();
            this.lblCultivo1 = new System.Windows.Forms.Label();
            this.txtIdentificador2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Location = new System.Drawing.Point(115, 12);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(97, 29);
            this.btnEliminar2.TabIndex = 9;
            this.btnEliminar2.Text = "Eliminar Archivo";
            this.btnEliminar2.UseVisualStyleBackColor = true;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(63, 136);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(97, 29);
            this.btnAgregar2.TabIndex = 8;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // btnCrear2
            // 
            this.btnCrear2.Location = new System.Drawing.Point(12, 12);
            this.btnCrear2.Name = "btnCrear2";
            this.btnCrear2.Size = new System.Drawing.Size(97, 29);
            this.btnCrear2.TabIndex = 7;
            this.btnCrear2.Text = "Crear Archivo";
            this.btnCrear2.UseVisualStyleBackColor = true;
            this.btnCrear2.Click += new System.EventHandler(this.btnCrear2_Click);
            // 
            // txtCultivo1
            // 
            this.txtCultivo1.Location = new System.Drawing.Point(40, 70);
            this.txtCultivo1.Name = "txtCultivo1";
            this.txtCultivo1.Size = new System.Drawing.Size(144, 20);
            this.txtCultivo1.TabIndex = 6;
            // 
            // lblCultivo1
            // 
            this.lblCultivo1.AutoSize = true;
            this.lblCultivo1.Location = new System.Drawing.Point(70, 54);
            this.lblCultivo1.Name = "lblCultivo1";
            this.lblCultivo1.Size = new System.Drawing.Size(80, 13);
            this.lblCultivo1.TabIndex = 5;
            this.lblCultivo1.Text = "Ingresar Cultivo";
            // 
            // txtIdentificador2
            // 
            this.txtIdentificador2.Location = new System.Drawing.Point(39, 110);
            this.txtIdentificador2.Name = "txtIdentificador2";
            this.txtIdentificador2.Size = new System.Drawing.Size(144, 20);
            this.txtIdentificador2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresar Identificador";
            // 
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(223, 171);
            this.Controls.Add(this.txtIdentificador2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.btnCrear2);
            this.Controls.Add(this.txtCultivo1);
            this.Controls.Add(this.lblCultivo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCultivos";
            this.Text = "Cultivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnCrear2;
        private System.Windows.Forms.TextBox txtCultivo1;
        private System.Windows.Forms.Label lblCultivo1;
        private System.Windows.Forms.TextBox txtIdentificador2;
        private System.Windows.Forms.Label label1;
    }
}