using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico2
{
    public partial class frmPráctico2 : Form
    {
        public frmPráctico2()
        {
            InitializeComponent();
        }

        static double CalcularPerimetro(double a, double b)
        {
            double p = 2 * (a + b);
            return p;
        }

        static double CalcularArea(double a, double b) 
        {
            double area = a * b;
            return area;
        }

        private void btnPerímetro_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtA.Text);
                double ladoB = double.Parse(txtB.Text);

                double resultado = CalcularPerimetro(ladoA, ladoB);

                txtPerímetro.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Porfavor revise los datos ingresados", "error");
                txtA.Focus();

            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = double.Parse(txtA.Text);
                double ladoB = double.Parse (txtB.Text);

                double resultado = CalcularArea(ladoA, ladoB);

                txtArea.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("porfavor revise los datos ingresados", "error");
                txtB.Focus();

            }
        }
    }
}
