using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico1
{
    public partial class frmPráctico1 : Form
    {
        public frmPráctico1()
        {
            InitializeComponent();
        }
        
        //  Aquí se declara y se programa el método que 
        //  calcula el perímetro de un círculo de radio r
        static double Perímetro(double r)
        {
            double p = 2 * 3.1416 * r;
            return p;

        }

        static double Area(double r)
        {
            double a = Math.PI * Math.Pow(r, 2);
            return a;
        }
        private void btnPerímetro_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtRadio.Text);
                //Aquí se debe llamar al método Perímetro
                double resultado = Perímetro(r);

                txtPerimetro.Text = resultado.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Dato Incorrecto", "ERROR");
                txtRadio.Clear();
                txtRadio.Focus();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(txtRadio.Text);

                double resultado1 = Area(r);

                txtArea.Text = resultado1.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("dato incorrecto", "error");
            }
        }
    }
}
