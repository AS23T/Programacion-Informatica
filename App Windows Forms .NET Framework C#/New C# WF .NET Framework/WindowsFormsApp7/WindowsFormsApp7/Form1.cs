using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ConvertirLasPulgadas_Click(object sender, EventArgs e)
        {
            try
            {
                double pulgadas, cm;

                pulgadas = double.Parse(tbxPulgadas.Text);

                cm = pulgadas * 2.54;

                tbxCM.Text = cm.ToString();

                tbxPulgadas.Focus();
                tbxCM.SelectAll();
                tbxPulgadas.SelectAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, algo mal paso");
            }
        }

        private void button_ConvertirLosCM_Click(object sender, EventArgs e)
        {
            try
            {
                double cm, pulgadas;

                cm = double.Parse(tbxCM.Text);

                pulgadas = cm / 2.54;

                tbxPulgadas.Text = pulgadas.ToString();

                tbxCM.Focus();
                tbxPulgadas.SelectAll();
                tbxCM.SelectAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, algo mal salio");
            }
        }
    }
}
