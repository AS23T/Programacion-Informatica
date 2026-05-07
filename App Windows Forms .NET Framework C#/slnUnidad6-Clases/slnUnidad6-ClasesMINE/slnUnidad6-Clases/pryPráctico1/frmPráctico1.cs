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
            //Captura los datos ingresados en los TextBox
            //y guardamos la wea en variables locales
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;

            //valido si la wea no este vacia o null
            if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
            {
                MessageBox.Show("Porfavor, complete la marca y el modelo del vehiculo.", "faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //salgo de esta wea si no es asi ya que no hay else, podria usar break
            }

            //la logica de procesamiento, como es un año asignado
            //de forma automatica actual del año

            int añoCalculado = DateTime.Now.Year;

            //Mostrar la salida en la wea transformando el tipo de dato
            txtAño.Text = añoCalculado.ToString();

            //mensaje para debug y exito
            MessageBox.Show($"vehiculo {marca} {modelo} del año {añoCalculado} registrado con exito!", "registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
