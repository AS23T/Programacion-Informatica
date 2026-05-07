using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico4
{

    public partial class frmPráctico4 : Form
    {
        public frmPráctico4()
        {
            InitializeComponent();
        }
        


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                int n1 = int.Parse(txtNumA.Text);
                int d1 = int.Parse(txtDenA.Text);
                int n2 = int.Parse(txtNumB.Text);
                int d2 = int.Parse(txtDenB.Text);

                
                Fraccion f1 = new Fraccion(n1, d1);
                Fraccion f2 = new Fraccion(n2, d2);

                
                Fraccion suma = Fraccion.Sumar(f1, f2);
                suma.Simplificar(); 

                
                Fraccion multiplicacion = Fraccion.Multiplicar(f1, f2);

                
                multiplicacion.Simplificar();

                
                txtNumSuma.Text = suma.Numerador.ToString();
                txtDenSuma.Text = suma.Denominador.ToString();

                
                txtNumMult.Text = multiplicacion.Numerador.ToString();
                txtDenMult.Text = multiplicacion.Denominador.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Porfavor, ingresa numeros enteros validos", "error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void txtNumA_TextChanged(object sender, EventArgs e)
        {
            txtNAm.Text = txtNumA.Text;
            txtNAs.Text = txtNumA.Text;
        }

        private void txtDenA_TextChanged(object sender, EventArgs e)
        {
            txtDAs.Text = txtDenA.Text;
            txtDAm.Text = txtDenA.Text;
        }

        private void txtNumB_TextChanged(object sender, EventArgs e)
        {
            txtNBm.Text = txtNumB.Text;
            txtNBs.Text = txtNumB.Text;
        }

        private void txtDenB_TextChanged(object sender, EventArgs e)
        {
            txtDBm.Text = txtDenB.Text;
            txtDBs.Text = txtDenB.Text;
        }
    }
    internal class Fraccion
    {
        
        public int Numerador { get; set; }
        private int _denominador;

        public int Denominador
        {
            get { return _denominador; }
            set
            {
                
                if (value == 0)
                    throw new ArgumentException("El denominador no puede ser cero.");
                _denominador = value;
            }
        }

        
        public Fraccion() { }

        
        public Fraccion(int a, int b)
        {
            Numerador = a;
            Denominador = b;
            
        }

        
        public static Fraccion Sumar(Fraccion f1, Fraccion f2)
        {
            Fraccion resultado = new Fraccion();
            resultado.Numerador = (f1.Numerador * f2.Denominador) + (f2.Numerador * f1.Denominador);
            resultado.Denominador = f1.Denominador * f2.Denominador;
            return resultado;
        }

        public static Fraccion Multiplicar(Fraccion f1, Fraccion f2)
        {
            Fraccion resultado = new Fraccion();
            resultado.Numerador = f1.Numerador * f2.Numerador;
            resultado.Denominador = f1.Denominador * f2.Denominador;
            return resultado;
        }

        
        private int CalcularMCD(int a, int b)
        {
            int resto;
            do
            {
                resto = a % b;
                if (resto != 0)
                {
                    a = b;
                    b = resto;
                }
            } while (resto > 0);
            return b;
        }

        public void Simplificar()
        {
            int mcd = CalcularMCD(Numerador, Denominador);
            Numerador = Numerador / mcd;
            Denominador = Denominador / mcd;
        }
    }
}
