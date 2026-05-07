using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Método que llena un arreglo de n, con N valores aleatorios entre 1000 y 9999
        static int[] LlenarArreglo(int n)
        {
            int[] arreglo = new int[n];
            Random rnd = new Random(n);
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = rnd.Next(1000 * (n / 100), 9999 - n * 5);
            }
            return arreglo;
        }

        //AQUI CREAR MÉTODO QUE OBTIENE EL ANCHO DE UN ARREGLO
        static int ObtenerAncho(int[] arreglo)
        {
            if (arreglo == null || arreglo.Length == 0)
            {
                return 0;
            }

            int valorMaximo = arreglo.Max();
            int valorMinimo = arreglo.Min();

            return valorMaximo - valorMinimo;
        }


        private void btnObtener_Click(object sender, EventArgs e)
        {
            //INICIO sección permite crear y llenar tres arreglos v1, v2 y v3 con valores aletorios.
            //*** NO MODIFICAR ESTA SECCIÓN ***
            Random rnd = new Random(202704);
            int x=rnd.Next(100,200);
            int[] v1= LlenarArreglo(x);
            int y=rnd.Next(150,250);
            int[] v2 = LlenarArreglo(y);
            int z=rnd.Next(300,400);
            int[] v3 = LlenarArreglo(z);
            //FIN sección que crea y llena los tres arreglos v1, v2 y v3

            //DESDE AQUI AGREGAR EL CÓDIGO NECESARIO
            int[] arregloSeleccionado = null;
            int anchoCalculado = 0;

            if (rdbArreglo1.Checked)
            {
                arregloSeleccionado = v1;
            }
            else if (rdbArreglo2.Checked)
            {
                arregloSeleccionado = v2;
            }
            else if (rdbArreglo3.Checked)
            {
                arregloSeleccionado = v3;
            }

            if (arregloSeleccionado != null)
            {
                anchoCalculado = ObtenerAncho(arregloSeleccionado);

                txtAncho.Text = anchoCalculado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un arreglo.");
            }
        }
    }
}
