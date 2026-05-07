using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCertamen2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOtroCalculo_Click(object sender, EventArgs e)
        {
            tbxNota1.Clear();
            tbxNota2.Clear();
            tbxNota3.Clear();
            tbxPromedio.Clear();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalcularProm_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, prom;

            n1 = double.Parse(tbxNota1.Text);
            n2 = double.Parse(tbxNota2.Text);
            n3 = double.Parse(tbxNota3.Text);

            prom = n1 * 0.2 + n2 * 0.35 + n3 * 0.45;

            tbxPromedio.Text = prom.ToString();

            tbxPromedio.Visible = true;

            if (prom > 4)
            {
                labelSituacion.Text = "Aprobado";
            }
            else
            {
                labelSituacion.Text = "Reprobado";
            }
        }
    }
}
