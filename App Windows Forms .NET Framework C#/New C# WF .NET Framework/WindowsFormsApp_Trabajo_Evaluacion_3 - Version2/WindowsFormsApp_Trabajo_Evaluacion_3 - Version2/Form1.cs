using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp_Trabajo_Evaluacion_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //

        // VALIDACION DE RUT
        private bool ValidarRutDueño(string rut)
        {
            rut = rut?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(rut))
            { 
                MessageBox.Show("Ingrese el RUT del dueño."); //Pedir al dueño que ingrese su rut
                tbx_RUT_Dueño.Focus();
                return false;
            }

            var rx = new Regex(@"^\d{1,10}-[\dkK]$");//Validación de los espacios del Rut
            if (!rx.IsMatch(rut))
            {
                MessageBox.Show("RUT invalido. Ejemplo: 12345678-9");//Hacer que el rut sea invalido sin guion 
                tbx_RUT_Dueño.Focus();
                return false;
            }
            return true;
        }

        // METODO CLAVE: AHORA DEVUELVO UN OBJETO 'CLIENTE'
        private Cliente LeerDatos()
        {
            // Validar RUT 
            string rut = tbx_RUT_Dueño.Text?.Trim() ?? string.Empty;
            if (!ValidarRutDueño(rut))
            {
                throw new Exception("RUT invalido o faltante.");
            }

            //Validar Tipo Mascota
            string tipo = comboBox_Tipo_Mascota.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(tipo))
            {
                comboBox_Tipo_Mascota.Focus();
                throw new Exception("Seleccione el tipo de mascota.");
            }

            //Validar Edad
            int edad = (int)numericUpDown_Mascota_Edad.Value;
            if (edad < 1 || edad > 30)
            {
                numericUpDown_Mascota_Edad.Focus();
                throw new Exception("La edad debe estar entre 1 y 30 años.");
            }

            //

            // AQUI CONECTAMOS LAS CLASES

            //Creamos el objeto Paciente primero
            Paciente nuevoPaciente = new Paciente(tipo, edad);

            //Creamos el objeto Cliente y le metemos el Paciente dentro
            Cliente nuevoCliente = new Cliente(rut, nuevoPaciente);

            //Devolvemos el OBJETO completo
            return nuevoCliente;
        }

        //

        private void button_Siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamamos al metodo que crea las instancias de las clases
                Cliente clienteCreado = LeerDatos();

                // Pasamos el OBJETO al Form2
                // (Nota: Asegurarse de que el constructor de Form2 acepte un Cliente)
                Form2 form2 = new Form2(clienteCreado);

                form2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Solo mostramos el mensaje si es un error de validacion controlado
                if (ex.Message != "RUT invalido o faltante.") // Evitamos doble alerta si ya salio en ValidarRut
                {
                    MessageBox.Show("Atencion: " + ex.Message);
                }
            }
        }

        private void button_Limpiar1_Click(object sender, EventArgs e)
        {
            //Limpiar datos del Dueño y de la Mascota
            tbx_RUT_Dueño.Clear();
            comboBox_Tipo_Mascota.SelectedIndex = -1;
            comboBox_Tipo_Mascota.Text = "";
            numericUpDown_Mascota_Edad.Value = 0; //El minimo configurado

            tbx_RUT_Dueño.Focus();
        }

        private void button_Salir1_Click(object sender, EventArgs e)
        { //Salir de la interfaz del Formulario 1
            Application.Exit();
        }
    }
}