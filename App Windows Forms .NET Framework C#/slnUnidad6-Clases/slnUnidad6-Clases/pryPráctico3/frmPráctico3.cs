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
        

        CuentaBancaria cuenta = new CuentaBancaria();

        public frmPráctico3()
        {
            InitializeComponent();
        }

        private void frmPráctico3_Load(object sender, EventArgs e)
        {
            
            txtSaldo.Text = cuenta.Saldo.ToString();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            try
            {
                
                long monto = long.Parse(txtMonto.Text);

                
                cuenta.Retirar(monto);

                
                txtSaldo.Text = cuenta.Saldo.ToString();

                
                txtMonto.Clear();
                txtMonto.Focus();
            }
            catch (ArgumentException ex)
            {
                
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
                
                long monto = long.Parse(txtMonto.Text);

                
                cuenta.Depositar(monto);
                
                txtSaldo.Text = cuenta.Saldo.ToString();

                
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

    

    public class CuentaBancaria 
    {
        

        private long _saldo = 5000000;

        
        public long Saldo
        {
            get { return _saldo; }
            set
            {
                
                if (value < 0)
                {
                    throw new ArgumentException("El saldo es menor al monto a retirar");
                }
                _saldo = value;
            }
        }

        
        public void Depositar(long monto)
        {
            Saldo = Saldo + monto;
        }

        
        public void Retirar(long monto)
        {
            
            Saldo = Saldo - monto;
        }
    }
}
