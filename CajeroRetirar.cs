using Cajero.ATM;
using System;
using System.Windows.Forms;

namespace Cajero
{
    public partial class CajeroRetirar : Form
    {
        private long numeroTarjeta;
        private CajeroBancario cajeroBancario;

        public CajeroRetirar(long numeroTarjeta, CajeroBancario cajeroBancario)
        {
            InitializeComponent();
            this.numeroTarjeta = numeroTarjeta;
            this.cajeroBancario = cajeroBancario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            CajeroOpciones oCajeroOpciones = new CajeroOpciones(numeroTarjeta);
            oCajeroOpciones.Show();
            this.Hide();
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            RetirarCantidad(1000);
        }

        private void btnDosMil_Click(object sender, EventArgs e)
        {
            RetirarCantidad(2000);
        }

        private void btnCuatroMil_Click(object sender, EventArgs e)
        {
            RetirarCantidad(4000);
        }

        private void btnCincoMil_Click(object sender, EventArgs e)
        {
            RetirarCantidad(5000);
        }

        private void btnSeisMil_Click(object sender, EventArgs e)
        {
            RetirarCantidad(6000);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void RetirarCantidad(decimal cantidad)
        {
            string resultado = cajeroBancario.RetirarDinero(numeroTarjeta, cantidad);
            DialogResult dialogResult = MessageBox.Show(resultado, "Resultado del Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                CajeroOpciones opciones = new CajeroOpciones(numeroTarjeta);
                opciones.Show();
                this.Hide();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidadUsuario.Text, out decimal cantidad))
            {
                RetirarCantidad(cantidad);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidadUsuario_Click(object sender, EventArgs e)
        {
        }

        // BOTONES NUMÉRICOS
        private void lbl0_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "0";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "1";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "2";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "3";
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "4";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "5";
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "6";
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "7";
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "8";
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            txtCantidadUsuario.Text += "9";
        }

        private void lblborrar_Click(object sender, EventArgs e)
        {
            if (txtCantidadUsuario != null && txtCantidadUsuario.Text.Length > 0)
            {
                string lastChar = txtCantidadUsuario.Text.Substring(0, txtCantidadUsuario.Text.Length - 1);
                txtCantidadUsuario.Text = lastChar;
            }
            else
            {
                MessageBox.Show("Nada que borrar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
