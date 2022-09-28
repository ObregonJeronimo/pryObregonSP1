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
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }



        private void btnCrear3_Click(object sender, EventArgs e)
        {

            //Se crea el archivo ("./produccion.txt")
            File.Create("./produccion.txt");
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            
            if (File.Exists("./localidades.txt"))
            {
                //crear variable para poder leer el ADD
                StreamReader readLocalidad = new StreamReader("./localidades.txt");

                // mientras la variable sea diferente de EOF, lee los datos de
                // localidad.txt y agrega items al combobox

                while (!readLocalidad.EndOfStream)
                {
                    cboLocalidad.Items.Add(readLocalidad.ReadLine().ToString());
                }

                readLocalidad.Close();



                StreamReader readCultivos = new StreamReader("./cultivos.txt");

                while (!readCultivos.EndOfStream)
                {
                    cboCultivo.Items.Add(readCultivos.ReadLine().ToString());
                }

                readCultivos.Close();
               
            }
            else
            {
                MessageBox.Show("El archivo donde se almacenan las localidades o cultivos no existe", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


            

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //si la caja de texto es diferente de vacío
            if (txtCantidad.Text != "")
            {

                //crea var para poder leer 
                StreamWriter write = new StreamWriter("./produccion.txt", true);

                //lea produccion.txt, convierte en string porque no se puede conbinar system.io con texto
                write.WriteLine(Convert.ToString("Cantidad:" + txtCantidad.Text) + "\nCultivo:" + cboCultivo.Text + "\nLocalidad:" + cboLocalidad.Text + "\n" + "------------------------------");

                write.Close();//cerrar para evitar que se cierre el programa 

                MessageBox.Show("La produccion se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Indicar cantidad", "Atención", MessageBoxButtons.OK);
            }

            txtCantidad.Text = "";//vaciar caja de texto
        }
    }
}
