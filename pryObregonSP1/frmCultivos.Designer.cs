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
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(62, 96);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(97, 29);
            this.btnAgregar2.TabIndex = 8;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            // 
            // btnCrear2
            // 
            this.btnCrear2.Location = new System.Drawing.Point(12, 12);
            this.btnCrear2.Name = "btnCrear2";
            this.btnCrear2.Size = new System.Drawing.Size(97, 29);
            this.btnCrear2.TabIndex = 7;
            this.btnCrear2.Text = "Crear Archivo";
            this.btnCrear2.UseVisualStyleBackColor = true;
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
            // frmCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(223, 140);
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
    }
}