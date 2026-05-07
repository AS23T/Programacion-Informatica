using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeAhorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Crear un array con frases
        string[] frases = { "\"Ahorra para invertir, no para gastar.\" - Anonimo",
                            "\"El ahorro es la base de la riqueza.\" - Benjamin Franklin",
                            "\"No ahorres lo que queda después de gastar, gasta lo que queda después de ahorrar.\" - Warren Buffett",
                            "\"El dinero ahorrado es dinero ganado.\" - Anonimo",
                            "\"Ahorra hoy para un mejor mañana.\" - Anonimo" };

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables con transformacion string(cadena) a int(numerico)
            int dinero = int.Parse(txtCantidad.Text);
            int nMeses = (int)nudMeses.Value;
            int total = dinero * nMeses;

            //Mostrar resultado con transformacion a string
            lblSalida.Text = "Ahorraras " + total.ToString() + " durante " + nMeses + " meses.";

            //Generar numero aleatorio para seleccionar frase
            Random objetoRandom = new Random();

            //Poner una frase aleatoria en la salida label
            lblFrase.Text = frases[objetoRandom.Next(1, 5)];
        }
    }
}
