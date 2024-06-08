namespace Cajero.ATM
{
    public class CuentaBancaria
    {
        public long Numero_Cuenta { get; set; }
        public decimal Saldo { get; set; }
        public int Limite { get; set; }
        public bool Status { get; set; }
        public List<Tarjeta> TarjetasAsociadas { get; set; }
        public Cliente Propietario { get; set; }

        public CuentaBancaria(long numeroCuenta, decimal saldo, int limite, bool status, Cliente propietario, Tarjeta tarjeta)
        {
            this.Numero_Cuenta = numeroCuenta;
            this.Saldo = saldo;
            this.Limite = limite;
            this.Status = status;
            this.Propietario = propietario;
            TarjetasAsociadas = new List<Tarjeta>();
            TarjetasAsociadas.Add(tarjeta);
        }
    }
}

