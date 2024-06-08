using Cajero.ATM;
using System;
using System.Windows.Forms;

namespace Cajero
{
    public partial class CajeroATM : Form
    {
        private TextBox activeTextBox;
        private CajeroBancario cajeroBancario;

        public CajeroATM()
        {
            InitializeComponent();
            txtNumTar.Enter += TextBox_Enter;
            txtPassword.Enter += TextBox_Enter;

            cajeroBancario = new CajeroBancario();
            cajeroBancario.CuentaMaestra.Cuentas = cajeroBancario.CuentaMaestra.CargarCuentas();
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // componentes
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Titulo(object sender, EventArgs e)
        {
        }

        // PANTALLA
        private void lblNumTar_Click(object sender, EventArgs e)
        {
        }

        private void txtNumTar_Click(object sender, EventArgs e)
        {
        }

        private void lblNIP_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
        }

        // botones numéricos
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

        //private void lblmenos_Click(object sender, EventArgs e)
        //{
        //    if (activeTextBox != null && activeTextBox.Text.Length > 0)
        //        activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
        //}
        private void lblmenos_Click(object sender, EventArgs e)
        {
            //if (activeTextBox != null && activeTextBox.Text.Length > 0)
            //{
            //    char lastChar = activeTextBox.Text[activeTextBox.Text.Length - 1];
            //    if (char.IsDigit(lastChar))
            //    {
            //        int lastDigit = int.Parse(lastChar.ToString());
            //        lastDigit = (lastDigit - 1 + 10) % 10;
            //        activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1) + lastDigit.ToString();
            //    }
            //}
        }

        private void lblmas_Click(object sender, EventArgs e)
        {
            //if (activeTextBox != null && activeTextBox.Text.Length > 0)
            //{
            //    char lastChar = activeTextBox.Text[activeTextBox.Text.Length - 1];
            //    if (char.IsDigit(lastChar))
            //    {
            //        int lastDigit = int.Parse(lastChar.ToString());
            //        lastDigit = (lastDigit + 1) % 10;
            //        activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1) + lastDigit.ToString();
            //    }
            //}
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

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                return;
            }
        }

        private void lblAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                long numTarjeta = long.Parse(txtNumTar.Text);
                int nip = int.Parse(txtPassword.Text);

                Tarjeta tarjeta = cajeroBancario.CuentaMaestra.ValidarTarjeta(numTarjeta, nip);
                if (tarjeta != null)
                {
                    MessageBox.Show("¡Tarjeta válida!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CajeroOpciones cajeroOpciones = new CajeroOpciones(numTarjeta);
                    cajeroOpciones.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Número de tarjeta o NIP incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumTar.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número de tarjeta y NIP válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTar.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarCliente = new RegistrarCliente();
            registrarCliente.Show();
            this.Hide();
        }
    }
}
