using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerDatos
{
    public partial class Form1 : Form
    {
        private List<int> valores = new List<int>();
        private const string NombreArchivo = "valores.txt";

        public Form1()
        {
            InitializeComponent();

            ConfigurarDiseno();

            CargarDatosDelArchivo();
        }

        private void ConfigurarDiseno()
        {
            this.Text = "Actividad 31: Lectura de Datos";
            this.Size = new Size(500, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10);
            this.BackColor = Color.WhiteSmoke;

            Label lbl_Titulo = new Label
            {
                Text = "Datos del Archivo",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(lbl_Titulo);

            lbl_EstadoArchivo = new Label
            {
                Text = "Esperando lectura de " + NombreArchivo + "...",
                Location = new Point(20, 60),
                AutoSize = true,
                ForeColor = Color.DarkGray
            };
            this.Controls.Add(lbl_EstadoArchivo);

            Panel pnl_Resultados = new Panel
            {
                Location = new Point(20, 100),
                Size = new Size(440, 150),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray
            };
            this.Controls.Add(pnl_Resultados);

            Label lbl_SubTitulo = new Label
            {
                Text = "Resultados Generales:",
                Font = new Font("Segoe UI", 12, FontStyle.Underline),
                Location = new Point(10, 10),
                AutoSize = true
            };
            pnl_Resultados.Controls.Add(lbl_SubTitulo);

            Label lbl_Cantidad = new Label { Text = "1. Cantidad de registros:", Location = new Point(10, 40), AutoSize = true };
            lbl_ResultadoCantidad = new Label { Text = "---", Location = new Point(250, 40), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            pnl_Resultados.Controls.Add(lbl_Cantidad);
            pnl_Resultados.Controls.Add(lbl_ResultadoCantidad);

            Label lbl_Promedio = new Label { Text = "2. Promedio de los numeros:", Location = new Point(10, 70), AutoSize = true };
            lbl_ResultadoPromedio = new Label { Text = "---", Location = new Point(250, 70), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            pnl_Resultados.Controls.Add(lbl_Promedio);
            pnl_Resultados.Controls.Add(lbl_ResultadoPromedio);

            btn_CalcularPromedio = new Button
            {
                Text = "Calcular (1 y 2)",
                Location = new Point(320, 90),
                Size = new Size(110, 30),
                Enabled = false,
                BackColor = Color.FromArgb(100, 149, 237),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btn_CalcularPromedio.FlatAppearance.BorderSize = 0;
            btn_CalcularPromedio.Click += new EventHandler(btn_CalcularPromedio_Click);
            pnl_Resultados.Controls.Add(btn_CalcularPromedio);

            Panel pnl_Controles = new Panel
            {
                Location = new Point(20, 270),
                Size = new Size(440, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };
            this.Controls.Add(pnl_Controles);

            Label lbl_MayoresN = new Label { Text = "3. Cantidad de numeros > N:", Location = new Point(10, 10), AutoSize = true, Font = new Font("Segoe UI", 12, FontStyle.Underline) };
            pnl_Controles.Controls.Add(lbl_MayoresN);

            lbl_N = new Label { Text = "Valor de N (80-110):", Location = new Point(10, 40), AutoSize = true };
            txt_N = new TextBox { Location = new Point(150, 37), Size = new Size(50, 20), Text = "80" };
            pnl_Controles.Controls.Add(lbl_N);
            pnl_Controles.Controls.Add(txt_N);

            btn_ContarMayoresN = new Button
            {
                Text = "Contar Mayores a N",
                Location = new Point(210, 35),
                Size = new Size(140, 25),
                Enabled = false,
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btn_ContarMayoresN.FlatAppearance.BorderSize = 0;
            btn_ContarMayoresN.Click += new EventHandler(btn_ContarMayoresN_Click);
            pnl_Controles.Controls.Add(btn_ContarMayoresN);

            lbl_ResultadoMayoresN = new Label { Text = "Resultado: ---", Location = new Point(10, 70), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            pnl_Controles.Controls.Add(lbl_ResultadoMayoresN);

        }

        private Label lbl_EstadoArchivo;
        private Label lbl_ResultadoCantidad;
        private Label lbl_ResultadoPromedio;
        private Label lbl_ResultadoMayoresN;
        private Label lbl_N;
        private TextBox txt_N;
        private Button btn_CalcularPromedio;
        private Button btn_ContarMayoresN;


        private void CargarDatosDelArchivo()
        {
            valores.Clear();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NombreArchivo);

            try
            {
                if (!File.Exists(filePath))
                {
                    lbl_EstadoArchivo.Text = $"ERROR: Archivo no encontrado en: {filePath}";
                    lbl_EstadoArchivo.ForeColor = Color.Red;
                    return;
                }

                string[] lineas = File.ReadAllLines(filePath);

                foreach (string line in lineas)
                {
                    if (int.TryParse(line.Trim(), out int numero))
                    {
                        valores.Add(numero);
                    }
                }
                if (valores.Count > 0)
                {
                    lbl_EstadoArchivo.Text = $"Archivo '{NombreArchivo}' cargado exitosamente. Se leyeron {valores.Count} valores.";
                    lbl_EstadoArchivo.ForeColor = Color.Green;

                    btn_CalcularPromedio.Enabled = true;
                    btn_ContarMayoresN.Enabled = true;

                    CalcularResultadosGenerales();
                }
                else
                {
                    lbl_EstadoArchivo.Text = $"Advertencia: Archivo '{NombreArchivo}' cargado, pero no se encontraron números válidos.";
                    lbl_EstadoArchivo.ForeColor = Color.Orange;
                }
            }
            catch (Exception ex)
            {
                lbl_EstadoArchivo.Text = $"ERROR DE LECTURA: {ex.Message}";
                lbl_EstadoArchivo.ForeColor = Color.Red;
                btn_CalcularPromedio.Enabled = false;
                btn_ContarMayoresN.Enabled = false;
            }
        }

        private void CalcularResultadosGenerales()
        {
            if (valores.Count == 0)
            {
                lbl_ResultadoCantidad.Text = "0";
                lbl_ResultadoPromedio.Text = "No Aplica";
                return;
            }

            int cantidad = valores.Count;
            lbl_ResultadoCantidad.Text = cantidad.ToString();

            double promedio = valores.Average();
            lbl_ResultadoPromedio.Text = promedio.ToString("N2");
        }

        private void btn_CalcularPromedio_Click(object sender, EventArgs e)
        {
            CalcularResultadosGenerales();
        }

        private void ContarMayoresAN()
        {
            if (!int.TryParse(txt_N.Text, out int nValue))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico entero válido para N.", "Error de Entrada", MessageBoxButtons.OK);
                lbl_ResultadoMayoresN.Text = "Error de valor N";
                return;
            }

            if (nValue < 80 || nValue > 110)
            {
                MessageBox.Show("El valor de N debe estar en el rango de 80 a 110 (ambos inclusive).", "Error de Rango", MessageBoxButtons.OK);
                lbl_ResultadoMayoresN.Text = "Error de rango N";
                return;
            }

            if (valores.Count == 0)
            {
                lbl_ResultadoMayoresN.Text = "Resultado: 0 (No hay datos cargados)";
                return;
            }

            int count = valores.Count(numero => numero > nValue);

            lbl_ResultadoMayoresN.Text = $"Resultado: {count} numeros mayores a {nValue}.";

        }

        private void btn_ContarMayoresN_Click(object sender, EventArgs e)
        {
            ContarMayoresAN();
        }
    }
}
