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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;

            
            if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
            {
                MessageBox.Show("Porfavor, complete la marca y el modelo del vehiculo.", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            

            int añoCalculado = DateTime.Now.Year;

            
            txtAño.Text = añoCalculado.ToString();

            
            MessageBox.Show($"vehiculo {marca} {modelo} del año {añoCalculado} registrado con exito!", "registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
