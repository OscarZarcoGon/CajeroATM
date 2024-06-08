using Cajero.ATM;
using System;
using System.Windows.Forms;

namespace Cajero
{
    public partial class CajeroTransferir : Form
    {
        private TextBox activeTextBox;
        private long numeroCuenta;
        private CajeroBancario cajeroBancario;

        public CajeroTransferir(long numeroCuenta, CajeroBancario cajeroBancario)
        {
            InitializeComponent();
            this.numeroCuenta = numeroCuenta;
            this.cajeroBancario = cajeroBancario;
            txtNumeroTarjeta.Enter += TextBox_Enter;
            txtCantidadUsuario.Enter += TextBox_Enter;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }

        private void txtCantidadUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumeroTarjeta_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            CajeroOpciones opciones = new CajeroOpciones(numeroCuenta);
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
            }
        }

        private void lblaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroTarjeta.Text) || string.IsNullOrEmpty(txtCantidadUsuario.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtNumeroTarjeta.Text, out long numeroTarjetaDestino))
            {
                MessageBox.Show("Número de tarjeta no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtCantidadUsuario.Text, out decimal cantidad))
            {
                MessageBox.Show("Cantidad no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = cajeroBancario.Transferir(numeroCuenta, numeroTarjetaDestino, cantidad);
            DialogResult dialogResult = MessageBox.Show(resultado, "Resultado de la Transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                CajeroOpciones opciones = new CajeroOpciones(numeroCuenta);
                opciones.Show();
                this.Hide();
            }
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
