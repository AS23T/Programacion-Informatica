using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//

namespace WindowsFormsApp_Trabajo_Evaluacion_3
{
    public partial class Form2 : Form
    {
        // VARIABLE PARA GUARDAR LOS DATOS QUE VIENEN DEL FORM1
        private Cliente clienteActual;

        // CONSTRUCTOR MODIFICADO: AHORA PIDE UN CLIENTE
        public Form2(Cliente clienteRecibido)
        {
            InitializeComponent();

            // Guardamos el cliente en nuestra variable local
            this.clienteActual = clienteRecibido;

            // Mostramos los datos en la barra de titulo de la ventana
            // Accedemos a clienteActual hacia SuMascota hacia Tipo
            this.Text = "Atendiendo a: " + clienteActual.SuMascota.Tipo +
                        " (Edad: " + clienteActual.SuMascota.Edad + ") - Dueño: " + clienteActual.Rut;

            // Llamamos al metodo que llena los ComboBoxes automaticamente
            CargarServicios();
        }

        // Constructor vacio por seguridad (Usamos el de arriba)
        public Form2()
        {
            InitializeComponent();
            CargarServicios();//ahora se inicio con el metodo CargarServicios
        }

        //

        // METODO PARA CARGAR LOS 3 SERVICIOS
        private void CargarServicios()
        {
            string[] listaServicios = { "Cirugia", "Vacunacion", "Analisis clinico" };

            // Arrays de controles para hacerlo rapido
            ComboBox[] combos = { comboBox_Servicio1, comboBox_Servicio2, comboBox_Servicio3 };

            foreach (var combo in combos)
            { //Agregar un metodo de arreglo con comboBox
                combo.Items.Clear();
                combo.Items.AddRange(listaServicios);
            }
        }

        //

        // METODO PARA ASIGNAR PRECIOS (SIMULACION BD)
        private double ObtenerPrecio(string nombreServicio)
        {
            switch (nombreServicio)
            {
                case "Cirugia": return 80000;          // Ejemplo: $80.000
                case "Vacunacion": return 15000;       // Ejemplo: $15.000
                case "Analisis clinico": return 25000; // Ejemplo: $25.000
                default: return 0;
            }
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                // PREPARAMOS LOS ARRAYS DE CONTROLES (Para recorrer las 3 filas)
                ComboBox[] combos = { comboBox_Servicio1, comboBox_Servicio2, comboBox_Servicio3 };
                NumericUpDown[] cantidades = { numericUpDown_Cantidad1, numericUpDown_Cantidad2, numericUpDown_Cantidad3 };
                TextBox[] txtPrecios = { tbx_Precio1, tbx_Precio2, tbx_Precio3 };
                TextBox[] txtTotales = { tbx_Total1, tbx_Total2, tbx_Total3 };

                double subtotalAcumulado = 0;

                // RECORREMOS LAS 3 FILAS
                for (int i = 0; i < 3; i++)
                {
                    // Verificamos si hay un servicio seleccionado y cantidad > 0
                    if (combos[i].SelectedIndex != -1 && cantidades[i].Value > 0)
                    {
                        // CAPTURAR DATOS CRUDOS
                        string nombreServicio = combos[i].Text;
                        int cantidad = (int)cantidades[i].Value;

                        // BUSCAR PRECIO
                        double precioUnitario = ObtenerPrecio(nombreServicio);

                        // MOSTRAR PRECIO UNITARIO
                        txtPrecios[i].Text = precioUnitario.ToString("C0"); // Formato moneda

                        //AQUI USAMOS LA CLASE SERVICIO
                        Servicio nuevoServicio = new Servicio(nombreServicio, precioUnitario, cantidad);

                        // USAMOS EL METODO DE LA CLASE PARA CALCULAR
                        double totalLinea = nuevoServicio.CalcularTotalLinea();

                        // MOSTRAR TOTAL FILA Y ACUMULAR
                        txtTotales[i].Text = totalLinea.ToString("C0");
                        subtotalAcumulado = subtotalAcumulado + totalLinea;
                    }
                    else
                    {
                        // Si la fila esta vacia o incompleta, limpiamos sus textos de dinero
                        txtPrecios[i].Text = "$ 0";
                        txtTotales[i].Text = "$ 0";
                    }
                }

                // CALCULOS FINALES (IVA y TOTAL)
                double iva = subtotalAcumulado * 0.19; // 19%
                double totalFinal = subtotalAcumulado + iva;

                // MOSTRAR RESULTADOS FINALES
                tbx_Subtotal.Text = subtotalAcumulado.ToString("C0");
                tbx_IVA.Text = iva.ToString("C0");
                tbx_Total_Del_Total.Text = totalFinal.ToString("C0");

            }
            catch (Exception ex)
            { //Error de Calculo en mensaje
                MessageBox.Show("Error al calcular: " + ex.Message);
            }
        }

        private void button_Limpiar2_Click(object sender, EventArgs e)
        {
            // Usamos arrays tambien aqui para limpiar todo rapido y ordenado
            ComboBox[] combos = { comboBox_Servicio1, comboBox_Servicio2, comboBox_Servicio3 };
            NumericUpDown[] cantidades = { numericUpDown_Cantidad1, numericUpDown_Cantidad2, numericUpDown_Cantidad3 };
            TextBox[] textos = { tbx_Precio1, tbx_Precio2, tbx_Precio3, tbx_Total1, tbx_Total2, tbx_Total3 };

            foreach (var c in combos) c.SelectedIndex = -1;
            foreach (var n in cantidades) n.Value = 0;
            foreach (var t in textos) t.Clear();

            // Limpiar totales
            tbx_Subtotal.Clear();
            tbx_IVA.Clear();
            tbx_Total_Del_Total.Clear();

            comboBox_Servicio1.Focus();
        }

        private void button_Salir2_Click(object sender, EventArgs e)
        {//Salir de la interfaz del Formulario 2
            Application.Exit();
        }
    }
}