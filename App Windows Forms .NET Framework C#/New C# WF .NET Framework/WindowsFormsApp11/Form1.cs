using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int clics = 0;

        public void SumaryRestarValor(int contador)
        {
            int valorActual = Convert.ToInt32(label_Contador.Text);

            int nuevoValor = valorActual + contador;

            label_Contador.Text = nuevoValor.ToString();
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {

            SumaryRestarValor(1);

        }

        private void button_Quitar_Click(object sender, EventArgs e)
        {

            if (label_Contador.Text != "0")
            {
                SumaryRestarValor(-1);
            }

            int cantidad = int.Parse(label_Contador.Text);

            if (cantidad == 0)
            {
                clics++;
                if (clics == 10)
                {
                    MessageBox.Show("PARAAAAAAA!");
                    clics = 0;
                }
            }
            else
            {
                cantidad--;
                label_Contador.Text = cantidad.ToString();
                clics = 0;
            }
            
            
        }
    }
}
