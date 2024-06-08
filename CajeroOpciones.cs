using Cajero.ATM;

namespace Cajero
{
    public partial class CajeroOpciones : Form
    {
        private long numeroCuenta;
        private CajeroBancario cajeroBancario;


        public CajeroOpciones(long numeroCuenta)
        {
            InitializeComponent();
            this.numeroCuenta = numeroCuenta;
            cajeroBancario = new CajeroBancario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        //Opciones
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            ConsultarSaldo_ oConsultarSaldo = new ConsultarSaldo_(numeroCuenta, cajeroBancario);
            oConsultarSaldo.Show();
            this.Hide();
        }
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            CajeroTransferir cajeroTransferir = new CajeroTransferir(numeroCuenta, cajeroBancario);
            cajeroTransferir.Show();
            this.Hide();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            CajeroRetirar cajeroRetirar = new CajeroRetirar(numeroCuenta, cajeroBancario);
            cajeroRetirar.Show();
            this.Hide();
        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            CajeroDepositar cajeroDepositar = new CajeroDepositar(numeroCuenta, cajeroBancario);
            cajeroDepositar.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Salir a la pantalla principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CajeroATM principal = new CajeroATM();
                principal.Show();
                this.Hide();
                return;
            }
        }
        private void btnCambiarNip_Click(object sender, EventArgs e)
        {
            CajeroNipNew cajeroNipNew = new CajeroNipNew(numeroCuenta, cajeroBancario);
            cajeroNipNew.Show();
            this.Hide();
        }


        private void lblcancelar_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("¿Salir a la pantalla principal?", "Verificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                CajeroATM cajeroATM = new CajeroATM();
                cajeroATM.Show();
                this.Hide();
            }
        }
    }
}
