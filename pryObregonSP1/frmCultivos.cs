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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {

            TextWriter Write = new StreamWriter("./cultivos.txt", true);

            Write.WriteLine(Convert.ToString(txtIdentificador2.Text + " " + txtCultivo1.Text));
            Write.Close();


            MessageBox.Show("Se ha guardado correctamente.", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdentificador2.Text = "";
            txtCultivo1.Text = "";
            txtCultivo1.Focus();

        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {

            File.Create("./cultivos.txt");
            
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {

            File.Delete("./cultivos.txt");

        }


    }
}
