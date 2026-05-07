using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPráctico5
{
    public partial class frmPráctico5 : Form
    {
        public frmPráctico5()
        {
            InitializeComponent();
        }
        static bool ValidaCorreo(string email)
        {
            if (email.Length == 0) return false;

            if (email.Contains("@") == false) return false;

            if (email.Contains(".") == false) return false;

            if (email.Contains(" ") == true) return false;

            if (char.IsLetter(email[0]) == false) return false;

            if (email != email.ToLower()) return false;

            if (email.Contains(":")) return false;

            string prohibidos = "ñáéíóú";
            foreach (char letra in email)
            {
                if (prohibidos.Contains(letra)) return false;
            }

            return true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ValidaCorreo(txtEmail.Text))
            {
                MessageBox.Show("Email OK", "BIEN");
            }
            else
                MessageBox.Show("Email incorrecto", "MAL");
                txtEmail.Focus();
        }
    }
}
