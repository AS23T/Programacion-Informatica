using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryConsultasDeUnArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            int contadorDenegados = 0;
            StreamReader archivo = new StreamReader("..\\..\\accesos-2024-2025.txt");
            string linea = archivo.ReadLine();
            linea = archivo.ReadLine();

            while (linea != null)
            {
                string[] campos = linea.Split('\t');
                if (campos.Length >= 2)
                {
                    int tipoAcceso;
                    if (int.TryParse(campos[1], out tipoAcceso))
                    {
                        if (tipoAcceso == 7)
                            contadorDenegados++;

                    }
                }
                linea = archivo.ReadLine();
            }
            archivo.Close();
            lblResultado.Text = "Total de accesos denegados: " + contadorDenegados;

        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            StreamReader entrada = new StreamReader("..\\..\\accesos-2024-2025.txt");
            StreamWriter salida = new StreamWriter("..\\..\\salida.txt");

            string linea1 = entrada.ReadLine();
            linea1 = entrada.ReadLine();

            while (linea1 != null)
            {
                string[] campos1 = linea1.Split('\t');
                if (campos1.Length >= 4)
                {
                    if (campos1[3] == "20140102")
                    {
                        salida.WriteLine(linea1);

                    }
                }
                linea1 = entrada.ReadLine();
            }

            entrada.Close();
            salida.Close();

            MessageBox.Show("Archivo salida.txt generado correctamente");

        }
    }
}
