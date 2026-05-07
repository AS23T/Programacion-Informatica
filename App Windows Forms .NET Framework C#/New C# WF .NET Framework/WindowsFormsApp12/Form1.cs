using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lboxDestino.Items.Add("Arica"); //Se podria hacer con un For
            lboxDestino.Items.Add("Antofagasta");
            lboxDestino.Items.Add("La Serena");
            lboxDestino.Items.Add("Santiago");
            lboxDestino.Items.Add("Concepcion");
            lboxDestino.Items.Add("Temuco");
            lboxDestino.Items.Add("Osorno");
            lboxDestino.Items.Add("Puerto Montt");
            lboxDestino.Items.Add("Punta Arenas");

        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Asignar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox_TipoAsiento.Text) || string.IsNullOrWhiteSpace(lboxDestino.Text))
            {

                MessageBox.Show("Faltan datos.\n" + "Por favor selecciona algo en ambas listas.", "Error de Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {

                string datoLista = lboxDestino.SelectedItem.ToString();
                string datoCombo = comboBox_TipoAsiento.SelectedItem.ToString();

                string mensajeFinal = "Seleccionaste:\n" + "Destino: " + datoLista + "\n" + "Tipo de asiento: " + datoCombo;

                MessageBox.Show(mensajeFinal, "Resultados");

            }

            /*
            try
            {

                string datoLista = lboxDestino.SelectedItem.ToString();
                string datoCombo = comboBox_TipoAsiento.SelectedItem.ToString();

                string mensajeFinal = "Seleccionaste:\n" + "Destino: " + datoLista + "\n" + "Tipo de asiento: " + datoCombo;

                MessageBox.Show(mensajeFinal, "Resultados");

            }
            catch (Exception error)
            {

                MessageBox.Show("Faltan datos.\n" + "Por favor selecciona algo en ambas listas.", "Error de Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            */
        }
    }
}
