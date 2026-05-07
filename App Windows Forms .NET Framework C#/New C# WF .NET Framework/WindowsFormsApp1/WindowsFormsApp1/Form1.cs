using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, resultadoSuma;

                n1 = int.Parse(tbxn2.Text);
                n2 = int.Parse(tbxn3.Text);

                resultadoSuma = n1 + n2;

                tbxn1Resultado.Text = resultadoSuma.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                this.Close();
            }
            //Alternativa de Try Catch sera If Else
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Alternativa de this.Close() sera Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxn1Resultado.Clear();
            tbxn2.Clear();
            tbxn3.Clear();
        }
    }
}
