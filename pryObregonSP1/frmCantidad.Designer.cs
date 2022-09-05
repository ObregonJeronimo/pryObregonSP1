namespace pryObregonSP1
{
    partial class frmCantidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCantidad));
            this.btnEliminar3 = new System.Windows.Forms.Button();
            this.btnAgregar3 = new System.Windows.Forms.Button();
            this.btnCrear3 = new System.Windows.Forms.Button();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.txtIdentificador3 = new System.Windows.Forms.TextBox();
            this.lblIdentificador3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar3
            // 
            this.btnEliminar3.Location = new System.Drawing.Point(116, 12);
            this.btnEliminar3.Name = "btnEliminar3";
            this.btnEliminar3.Size = new System.Drawing.Size(97, 29);
            this.btnEliminar3.TabIndex = 9;
            this.btnEliminar3.Text = "Eliminar Archivo";
            this.btnEliminar3.UseVisualStyleBackColor = true;
            this.btnEliminar3.Click += new System.EventHandler(this.btnEliminar3_Click);
            // 
            // btnAgregar3
            // 
            this.btnAgregar3.Location = new System.Drawing.Point(59, 139);
            this.btnAgregar3.Name = "btnAgregar3";
            this.btnAgregar3.Size = new System.Drawing.Size(97, 29);
            this.btnAgregar3.TabIndex = 8;
            this.btnAgregar3.Text = "Agregar";
            this.btnAgregar3.UseVisualStyleBackColor = true;
            this.btnAgregar3.Click += new System.EventHandler(this.btnAgregar3_Click);
            // 
            // btnCrear3
            // 
            this.btnCrear3.Location = new System.Drawing.Point(13, 12);
            this.btnCrear3.Name = "btnCrear3";
            this.btnCrear3.Size = new System.Drawing.Size(97, 29);
            this.btnCrear3.TabIndex = 7;
            this.btnCrear3.Text = "Crear Archivo";
            this.btnCrear3.UseVisualStyleBackColor = true;
            this.btnCrear3.Click += new System.EventHandler(this.btnCrear3_Click);
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(41, 70);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(144, 20);
            this.txtCantidad1.TabIndex = 6;
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Location = new System.Drawing.Point(66, 54);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(90, 13);
            this.lblCantidad1.TabIndex = 5;
            this.lblCantidad1.Text = "Ingresar Cantidad";
            // 
            // txtIdentificador3
            // 
            this.txtIdentificador3.Location = new System.Drawing.Point(39, 113);
            this.txtIdentificador3.Name = "txtIdentificador3";
            this.txtIdentificador3.Size = new System.Drawing.Size(144, 20);
            this.txtIdentificador3.TabIndex = 11;
            // 
            // lblIdentificador3
            // 
            this.lblIdentificador3.AutoSize = true;
            this.lblIdentificador3.Location = new System.Drawing.Point(64, 97);
            this.lblIdentificador3.Name = "lblIdentificador3";
            this.lblIdentificador3.Size = new System.Drawing.Size(106, 13);
            this.lblIdentificador3.TabIndex = 10;
            this.lblIdentificador3.Text = "Ingresar Identificador";
            // 
            // frmCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(223, 178);
            this.Controls.Add(this.txtIdentificador3);
            this.Controls.Add(this.lblIdentificador3);
            this.Controls.Add(this.btnEliminar3);
            this.Controls.Add(this.btnAgregar3);
            this.Controls.Add(this.btnCrear3);
            this.Controls.Add(this.txtCantidad1);
            this.Controls.Add(this.lblCantidad1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCantidad";
            this.Text = "Cantidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar3;
        private System.Windows.Forms.Button btnAgregar3;
        private System.Windows.Forms.Button btnCrear3;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.Label lblCantidad1;
        private System.Windows.Forms.TextBox txtIdentificador3;
        private System.Windows.Forms.Label lblIdentificador3;
    }
}