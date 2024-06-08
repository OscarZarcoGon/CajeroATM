using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cajero.ATM;

namespace Cajero
{
    public partial class RegistrarCliente : Form
    {
        private CuentaMaestra CuentaMaestra;

        public RegistrarCliente()
        {
            InitializeComponent();
            CuentaMaestra = new CuentaMaestra();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void txtNumCliente_TextChanged(object sender, EventArgs e) { }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CajeroATM oCajero = new CajeroATM();
            oCajero.Show();
            this.Hide();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void btnCargar_Click(object sender, EventArgs e) { }
        private void txtTelefono_Click(object sender, EventArgs e) { }
        private void RegistrarCliente_Load(object sender, EventArgs e) { }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                long numeroTarjeta = long.Parse(txtNumTar.Text);
                long numeroCuenta = long.Parse(txtNumCuenta.Text);
                int numeroCliente = int.Parse(txtNumCliente.Text);
                DateTime fechaNacimiento = dateFechaNac.Value;
                DateTime fechaCorte = dateFechaCorte.Value;
                decimal saldo = decimal.Parse(txtSaldoApertura.Text);
                int limite = int.Parse(txtLimite.Text);
                int nip = int.Parse(txtNip.Text);
                long telefono = long.Parse(txtTelefono.Text);

                Cliente nuevoCliente = new Cliente(numeroCliente, nombre, fechaNacimiento, fechaCorte, telefono);
                Tarjeta nuevaTarjeta = new Tarjeta(numeroTarjeta, nip, DateTime.Now.AddYears(5), true);
                CuentaBancaria nuevaCuenta = new CuentaBancaria(numeroCuenta, saldo, limite, true, nuevoCliente, nuevaTarjeta);

                nuevoCliente.Tarjetas.Add(nuevaTarjeta);

                CuentaMaestra.RegistrarCuenta(nuevaCuenta);

                MessageBox.Show("Usuario Registrado");
                CajeroATM principal = new CajeroATM();
                principal.Show();
                this.Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de entrada no válido: " + ex.Message, "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
