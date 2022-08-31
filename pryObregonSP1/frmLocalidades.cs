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
            
            using (FileStream fs = File.Create("./localidades.txt"))
            {
                
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            File.Delete("./localidades.txt");
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
        }
    }
}
