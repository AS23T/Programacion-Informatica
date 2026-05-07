using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            cubo c1 = new cubo();
            c1.lado = int.Parse(tbxLado.Text);
            c1.CalcularArea();
            c1.CalculeVolumen();
            labelResultado.Text = ("El area es " + c1.area + "\nEl volumen es " + c1.volumen);
        }
    }
}
