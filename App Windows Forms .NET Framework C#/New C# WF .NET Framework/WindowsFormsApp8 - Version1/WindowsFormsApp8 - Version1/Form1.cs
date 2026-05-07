using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double[] PreciosUnidad = { 1250, 3000, 3333, 12000 }; //Por referencia pocision de indice (0, 1, 2, etc)

                //Tipos | Arreglos | Nombre | Elementos
                ComboBox[] cajasItems = { comboBoxItem1, comboBoxItem2, comboBoxItem3, comboBoxItem4 };
                NumericUpDown[] cajasCantidad = { numericUpDownCantidad1, numericUpDownCantidad2, numericUpDownCantidad3, numericUpDownCantidad4 };
                TextBox[] cajasPrecioUnit = { tbxPrecioUnitario1, tbxPrecioUnitario2, tbxPrecioUnitario3, tbxPrecioUnitario4 };
                TextBox[] cajasTotalItem = { tbxTotalItem1, tbxTotalItem2, tbxTotalItem3, tbxTotalItem4 };

                double AcumulacionSubTotalGeneral = 0;

                for (int i = 0; i < cajasItems.Length; i++)
                {
                    int indiceSeleccionado = cajasItems[i].SelectedIndex;

                    if (indiceSeleccionado == -1 || cajasCantidad[i].Value == 0) //valido iguales, puedo mejorarlo, ya que no actualiza nada si cambio cantidades o items despues del primer calculo
                    {
                        cajasPrecioUnit[i].Text = "$ 0";
                        cajasTotalItem[i].Text = "$ 0";
                        continue; //Continue por estar dentro de una iteracion (continue hace que se omita el resto de la iteración actual, pero el for sigue avanzando normalmente al siguiente ciclo, con for no se gasta el contador pero si modifico ese mismo despues del continue fallaria, en ese caso seria mejor un while)
                    }

                    //Puedo hacer control con if para evitar errores de cambio de largo, ej. 4 a 5 (Si indiceSeleccionado < 0 o indiceSeleccionado >= Largo de PreciosUnidad, continuo)
                    double precio = PreciosUnidad[indiceSeleccionado]; //Si el combobox CajasItems (Item) tiene exactamente los mismos items que PreciosUnidad (Precio Unitario)

                    double cantidad = (double)cajasCantidad[i].Value;

                    double totalFila = precio * cantidad; //Primer requisito

                    cajasPrecioUnit[i].Text = precio.ToString("C0");
                    cajasTotalItem[i].Text = totalFila.ToString("C0");

                    AcumulacionSubTotalGeneral = AcumulacionSubTotalGeneral + totalFila; //Segundo requisito


                }

                double valorIVA = AcumulacionSubTotalGeneral * 0.19; //Tercer requisito
                double totalFinal = AcumulacionSubTotalGeneral + valorIVA; //Cuarto requisito

                tbxSubTotal.Text = AcumulacionSubTotalGeneral.ToString("C0");
                tbxIVA.Text = valorIVA.ToString("C0");
                tbxTOTAL.Text = totalFinal.ToString("C0");

            }
            catch (Exception)
            {

                MessageBox.Show("Error algo salio mal");

            }
            
        }
    }
}
