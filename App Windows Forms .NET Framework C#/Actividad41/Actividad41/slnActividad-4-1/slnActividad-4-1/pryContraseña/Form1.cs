using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //por costumbre
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryContraseña
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string password = txtContraseña.Text.Trim();
            string confirmPassword = txtOtravez.Text.Trim();

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intentelo denuevo.", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAndFocus();
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAndFocus();
                return;
            }

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAndFocus();
                return;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe contener al menos un número.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAndFocus();
                return;
            }

            MessageBox.Show("¡CONTRASEÑA ROBUSTA!", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ClearAndFocus()
        {
            txtContraseña.Clear();
            txtOtravez.Clear();
            txtOtravez.Focus();
        }
    }
}
