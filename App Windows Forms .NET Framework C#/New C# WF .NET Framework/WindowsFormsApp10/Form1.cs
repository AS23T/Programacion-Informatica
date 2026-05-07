using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] LeerDatos()
        {
            double[] valores = new double[3];

            valores[0] = Convert.ToDouble(tbx_Valor1.Text);
            valores[1] = Convert.ToDouble(tbx_Valor2.Text);
            valores[2] = Convert.ToDouble(tbx_Valor3.Text);

            return valores;

        }

        public double CalcularPromedio(double[] N)
        {
            double resultado_SUMA = 0;


            for (int i = 0; i < N.Length; i++)
            {
                resultado_SUMA = resultado_SUMA + N[i];
            }

            double resultado_Prom = resultado_SUMA / N.Length; //paso de arreglo a variable

            return resultado_Prom;

            //return resultado_SUMA / N.Length;
        }

        public void ImprimirDatos(double resultadoFinal)
        {

            tbx_Promedio.Text = resultadoFinal.ToString();

        }

        private void button_Calcular_Prom_Click(object sender, EventArgs e)
        {
            //double[] valores = new double[3];

            double[] misN = LeerDatos();

            double resultado = CalcularPromedio(misN);

            ImprimirDatos(resultado);
        }
    }
}
