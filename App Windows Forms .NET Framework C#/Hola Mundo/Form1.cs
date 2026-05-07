using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNum1.Text);
            int numero2 = int.Parse(txtNum2.Text);

            int suma = numero1 + numero2;

            if (suma == 7)
            {
                lblSalida.Text = "Hola Mundo";


            }
            else
            {
                lblSalida.Text = "la suma no da 7";
            }
        }
    }
}
