using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryObregonSP1
{
    public partial class frmCantidad : Form
    {
        public frmCantidad()
        {
            InitializeComponent();
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            TextWriter Write = new StreamWriter("./cantidad.txt", true);

            Write.WriteLine(Convert.ToString(txtIdentificador3.Text + " " + txtCantidad1.Text));
            Write.Close();


            MessageBox.Show("Se ha guardado correctamente.", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdentificador3.Text = "";
            txtCantidad1.Text = "";
            txtCantidad1.Focus();
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {

            File.Delete("./cantidad.txt");

        }

        private void btnCrear3_Click(object sender, EventArgs e)
        {

            File.Create("./cantidad.txt");
            
        }
    }
}
