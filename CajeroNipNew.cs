using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cajero.ATM;

namespace Cajero
{
    public partial class CajeroNipNew : Form
    {
        private long numerCuenta;
        private TextBox activeTextBox;
        private CajeroBancario cajeroBancario;

        public CajeroNipNew(long numerCuenta, CajeroBancario cajeroBancario)
        {
            InitializeComponent();
            this.numerCuenta = numerCuenta;
            this.cajeroBancario = cajeroBancario;
            txtNumTar.Enter += TextBox_Enter;
            txtNuevoNip.Enter += TextBox_Enter;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }
        private void txtNumTar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevoNip_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTONES NUMÉRICOS
        private void lbl0_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "0";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "1";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "2";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "3";
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "4";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "5";
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "6";
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "7";
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "8";
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
                activeTextBox.Text += "9";
        }

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            CajeroOpciones opciones = new CajeroOpciones(numerCuenta);
            opciones.Show();
            this.Hide();
        }

        private void lblborrar_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && activeTextBox.Text.Length > 0)
            {
                string lastChar = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
                activeTextBox.Text = lastChar;
            }
            else
            {
                MessageBox.Show("Nada que borrar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void lblaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumTar.Text) || string.IsNullOrWhiteSpace(txtNuevoNip.Text))
            {
                MessageBox.Show("Por favor, introduzca tanto el número de tarjeta como el nuevo NIP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtNumTar.Text, out long numeroTarjeta))
            {
                MessageBox.Show("Número de tarjeta no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTar.Text = string.Empty;
                return;
            }

            if (!int.TryParse(txtNuevoNip.Text, out int nuevoNIP) || nuevoNIP.ToString().Length != 4)
            {
                MessageBox.Show("El NIP debe ser un número de 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevoNip.Text = string.Empty;
                return;
            }

            string resultado = cajeroBancario.CambiarNIP(numeroTarjeta, nuevoNIP);
            DialogResult dialogResult = MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                CajeroATM principal = new CajeroATM();
                principal.Show();
                this.Hide();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
