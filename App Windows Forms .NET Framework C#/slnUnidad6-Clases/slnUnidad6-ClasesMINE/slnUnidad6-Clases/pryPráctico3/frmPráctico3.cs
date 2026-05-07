using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico3
{
    public partial class frmPráctico3 : Form
    {
        // Variables globales de la clase CuentaBancaria
        //se inicializa con el saldo por defecto de 5000000

        CuentaBancaria cuenta = new CuentaBancaria();

        public frmPráctico3()
        {
            InitializeComponent();
        }

        private void frmPráctico3_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario, se muestra el saldo inicial
            txtSaldo.Text = cuenta.Saldo.ToString();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            try
            {
                //capturo la wea
                long monto = long.Parse(txtMonto.Text);

                //metodo retirar y la wea, si el monto es mayor al saldo, la clase lanzara una excepcion
                cuenta.Retirar(monto);

                //actualizo la wea
                txtSaldo.Text = cuenta.Saldo.ToString();

                //limpio la wea
                txtMonto.Clear();
                txtMonto.Focus();
            }
            catch (ArgumentException ex)
            {
                //esta wea captura la excepcion de la validacion y "El saldo es menor al monto a retirar"
                MessageBox.Show(ex.Message, "Error de retiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Porfavor, ingrese un numero valido", "Error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error por la shusha: " + ex.Message);
            }
        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            try
            {
                //capturo la wea de monto
                long monto = long.Parse(txtMonto.Text);

                // metodo depositar y la wea
                cuenta.Depositar(monto);
                //actualizo la wea
                txtSaldo.Text = cuenta.Saldo.ToString();

                //limpio la wea
                txtMonto.Clear();
                txtMonto.Focus();

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error por la shusha: " + ex.Message);
            }
        }
    }

    //vamo con la clase CuentaBancaria

    public class CuentaBancaria //(podria ser con static pero bueh)
    {
        //lugar privado con saldo inicial de 5000000

        private long _saldo = 5000000;

        //Propiedad publica con validacion
        public long Saldo
        {
            get { return _saldo; }
            set
            {
                //Validacion para que el saldo no sea negativo
                if (value < 0)
                {
                    throw new ArgumentException("El saldo es menor al monto a retirar");
                }
                //TODO: "if" para textBox txtMonto que no acepte numeros negativos
                _saldo = value;
            }
        }

        //Metodo depositar y la wea
        public void Depositar(long monto)
        {
            Saldo = Saldo + monto;
        }

        //Metodo retirar y la wea
        public void Retirar(long monto)
        {
            //Al restar, y la wea se invoca el set de saldo, donde se comprueba si es negativo
            Saldo = Saldo - monto;
        }
    }
}
