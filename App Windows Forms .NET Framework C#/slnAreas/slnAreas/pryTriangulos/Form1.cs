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

namespace pryTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener los lados del triángulo desde los TextBox
                double la = double.Parse(txtLadoA.Text);
                double lb = double.Parse(txtLadoB.Text);
                double lc = double.Parse(txtLadoC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MENSAJE:" + ex.Message, "ERROR");
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            //Leer los datos del archivo de texto
            StreamReader archivo = new StreamReader("..\\..\\Triángulos.txt");
            string registro= archivo.ReadLine();
            while (registro != null)
            {
                //Dividir los lados del triángulo
                string[] lados = registro.Split(';');
                double a = double.Parse(lados[0]);
                double b = double.Parse(lados[1]);
                double c = double.Parse(lados[2]);
                //Leer siguiente registro
                registro = archivo.ReadLine();
            }
            archivo.Close();
        }
    }
}
