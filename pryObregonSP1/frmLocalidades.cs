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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnCrear1_Click(object sender, EventArgs e)
        {

            File.Create("./localidades.txt");
            
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            File.Delete("./localidades.txt");
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {

            TextWriter Write = new StreamWriter("./localidades.txt", true);

            Write.WriteLine(Convert.ToString(txtIdentificador1.Text + " " + txtLocalidad1.Text));
            Write.Close();


            MessageBox.Show("Se ha guardado correctamente.", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdentificador1.Text = "";
            txtLocalidad1.Text = "";
            txtLocalidad1.Focus();

        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            if (txtLocalidad1.Text != "")
            {
                btnEliminar1.Enabled = true;
                btnAgregar1.Enabled = true;
            }
            
        }
    }
}
