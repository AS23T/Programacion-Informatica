using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                labelMensaje.BackColor = Color.Green;
                labelMensaje.Text = "Cliente Ingresado";

            }
            catch (Exception)
            {
                MessageBox.Show("Error, intente denuevo");
                
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                labelMensaje.BackColor = Color.Red;
                labelMensaje.Text = "Operacion Cancelada";

            }
            catch (Exception)
            {
                MessageBox.Show("Error, intente denuevo");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por su cooperacion");
        }

        private void tbxNombre_Click(object sender, EventArgs e)
        {
            tbxNombre.Clear();
        }

        private void tbxApellido_Click(object sender, EventArgs e)
        {
            tbxApellido.Clear();
        }

        private void tbxCalle_Click(object sender, EventArgs e)
        {
            tbxCalle.Clear();
        }

        private void tbxNumero_Click(object sender, EventArgs e)
        {
            tbxNumero.Clear();
        }
    }
}
