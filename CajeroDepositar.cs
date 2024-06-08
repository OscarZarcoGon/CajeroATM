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
    public partial class CajeroDepositar : Form
    {
        private long numeroCuenta;
        private CajeroBancario cajeroBancario;

        public CajeroDepositar(long numeroCuenta, CajeroBancario cajeroBancario)
        {
            InitializeComponent();
            this.numeroCuenta = numeroCuenta;
            this.cajeroBancario = cajeroBancario;
        }

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            CajeroOpciones opciones = new CajeroOpciones(numeroCuenta);
            opciones.Show();
            this.Hide();
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            DepositarCantidad(1000);
        }

        private void btnDosMil_Click(object sender, EventArgs e)
        {
            DepositarCantidad(2000);
        }

        private void btnCuatroMil_Click(object sender, EventArgs e)
        {
            DepositarCantidad(4000);
        }

        private void btnCincoMil_Click(object sender, EventArgs e)
        {
            DepositarCantidad(5000);
        }

        private void btnSeisMil_Click(object sender, EventArgs e)
        {
            DepositarCantidad(6000);
        }

        private void txtCantidadUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblaceptar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidadUsuario.Text, out decimal cantidad))
            {
                DepositarCantidad(cantidad);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DepositarCantidad(decimal cantidad)
        {
            string resultado = cajeroBancario.DepositarDinero(numeroCuenta, cantidad);
            DialogResult dialogResult = MessageBox.Show(resultado, "Resultado de Depósito", MessageBoxButtons.OK);

            if (dialogResult == DialogResult.OK)
            {
                CajeroOpciones opciones = new CajeroOpciones(numeroCuenta);
                opciones.Show();
                this.Hide();
            }
        }




        //BOTONES NUMÉRICOS
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
                return;
            }
        }
    }
}
