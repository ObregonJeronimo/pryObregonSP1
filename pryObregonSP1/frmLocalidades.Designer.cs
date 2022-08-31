namespace pryObregonSP1
{
    partial class frmLocalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidades));
            this.lblLocalidad1 = new System.Windows.Forms.Label();
            this.txtLocalidad1 = new System.Windows.Forms.TextBox();
            this.btnCrear1 = new System.Windows.Forms.Button();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLocalidad1
            // 
            this.lblLocalidad1.AutoSize = true;
            this.lblLocalidad1.Location = new System.Drawing.Point(65, 54);
            this.lblLocalidad1.Name = "lblLocalidad1";
            this.lblLocalidad1.Size = new System.Drawing.Size(94, 13);
            this.lblLocalidad1.TabIndex = 0;
            this.lblLocalidad1.Text = "Ingresar Localidad";
            // 
            // txtLocalidad1
            // 
            this.txtLocalidad1.Location = new System.Drawing.Point(40, 70);
            this.txtLocalidad1.Name = "txtLocalidad1";
            this.txtLocalidad1.Size = new System.Drawing.Size(144, 20);
            this.txtLocalidad1.TabIndex = 1;
            // 
            // btnCrear1
            // 
            this.btnCrear1.Location = new System.Drawing.Point(12, 12);
            this.btnCrear1.Name = "btnCrear1";
            this.btnCrear1.Size = new System.Drawing.Size(97, 29);
            this.btnCrear1.TabIndex = 2;
            this.btnCrear1.Text = "Crear Archivo";
            this.btnCrear1.UseVisualStyleBackColor = true;
            this.btnCrear1.Click += new System.EventHandler(this.btnCrear1_Click);
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Location = new System.Drawing.Point(62, 96);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(97, 29);
            this.btnAgregar1.TabIndex = 3;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Location = new System.Drawing.Point(115, 12);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(97, 29);
            this.btnEliminar1.TabIndex = 4;
            this.btnEliminar1.Text = "Eliminar Archivo";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(223, 140);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.btnCrear1);
            this.Controls.Add(this.txtLocalidad1);
            this.Controls.Add(this.lblLocalidad1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalidades";
            this.Text = "Localidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocalidad1;
        private System.Windows.Forms.TextBox txtLocalidad1;
        private System.Windows.Forms.Button btnCrear1;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.Button btnEliminar1;
    }
}