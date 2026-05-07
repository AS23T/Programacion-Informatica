using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico3
{
    public partial class frmPráctico3 : Form
    {
        public frmPráctico3()
        {
            InitializeComponent();
        }

        static int CalcularMCD(int a,  int b)
        {
            int resto;

            do
            {
                resto = a % b;

                if (resto != 0)
                {
                    a = b;
                    b = resto;
                }
            } while (resto > 0);

            return b;
        }

        private void btnCalcularMCD_Click(object sender, EventArgs e)
        {
            try
            {
                //entrada
                int numA = int.Parse(txbNumA.Text);
                int numB = int.Parse(txbNumB.Text);

                //llamo al metodo
                int resultado = CalcularMCD(numA, numB);

                //salida
                MessageBox.Show("el MCD es: " + resultado.ToString(), "resultado");
            }
            catch (Exception)
            {
                MessageBox.Show("porfavor ingrese numero entero valido", "error");
                txbNumA.Clear();
                txbNumA.Focus();
                txbNumB.Clear();
            }
        }
    }
}
