using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLeerDatos_Ver1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Selecciona el archivo valores.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    int cantidadRegistros = 0;
                    double sumaTotal = 0;
                    int numerosMayoresN = 0;

                    int valorN = (int)numValorN.Value;

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string linea;

                        while ((linea = sr.ReadLine())!= null)
                        {
                            cantidadRegistros++;

                            if (int.TryParse(linea, out int numeroActual))
                            {
                                sumaTotal += numeroActual;

                                if (numeroActual > valorN)
                                {
                                    numerosMayoresN++;
                                }
                            }
                        }
                    }

                    double promedio = (cantidadRegistros > 0) ? sumaTotal / cantidadRegistros : 0;

                    lblCantidad.Text = cantidadRegistros.ToString();

                    lblPromedio.Text = promedio.ToString("F2");

                    lblMayoresN.Text = numerosMayoresN.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
