    using Cajero.ATM;
    using System;
    using System.Windows.Forms;

    namespace Cajero
    {
    public partial class ConsultarSaldo_ : Form
    {
        private long numeroCuenta;
        private CajeroBancario CajeroBancario;

        public ConsultarSaldo_(long numeroCuenta, CajeroBancario cajeroBancario)
        {
            InitializeComponent();
            this.numeroCuenta = numeroCuenta;
            this.CajeroBancario = cajeroBancario;
        }

        private void ConsultarSaldo__Load(object sender, EventArgs e)
        {
            string resultado = CajeroBancario.ConsultarSaldo(numeroCuenta);
            ActualizarSaldo(resultado);
        }

        public void ActualizarSaldo(string saldo)
        {
            lblSuSaldoEs.Text = saldo;
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblcancelar_Click(object sender, EventArgs e)
        {
            CajeroOpciones oCajeroOpciones = new CajeroOpciones(numeroCuenta);
            oCajeroOpciones.Show();
            this.Hide();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
