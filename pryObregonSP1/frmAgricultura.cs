using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryObregonSP1
{
    public partial class frmAgricultura : Form
    {
        public frmAgricultura()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades frmL = new frmLocalidades();
            frmL.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmCul = new frmCultivos();
            frmCul.ShowDialog();
        }

        private void cantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmCan = new frmProduccion();
            frmCan.ShowDialog();
        }




    }
}
