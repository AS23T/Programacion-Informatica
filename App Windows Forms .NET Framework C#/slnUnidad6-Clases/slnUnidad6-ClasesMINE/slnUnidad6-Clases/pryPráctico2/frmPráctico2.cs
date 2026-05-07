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

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Capturar los datos ndea del usuario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string calle = txtCalle.Text;
            string numero = txtNumero.Text;

            //validar que la wea no este vacia
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(calle) || string.IsNullOrWhiteSpace(numero))
            {
                //la advertencia kla
                MessageBox.Show("Porfa, complete todo los campos antes de continuar", "datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // si todo esta piola 
                string mensajeSalida = $"Datos validados correctamente:\n\n" + $"Cliente: {nombre} {apellido}\n" + $"Direccion: {calle} #{numero}";

                //Mostramos el mensaje final
                MessageBox.Show(mensajeSalida, "exito ctm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
