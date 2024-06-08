namespace Cajero.ATM
{
    public class Tarjeta
    {
        public long Numero_Tarjeta { get; set; }
        public int NIP { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public bool Status { get; set; }

        public Tarjeta() { }

        public Tarjeta(long numeroTarjeta, int nip, DateTime fechaVencimiento, bool status)
        {
            this.Numero_Tarjeta = numeroTarjeta;
            this.NIP = nip;
            this.Fecha_Vencimiento = fechaVencimiento;
            this.Status = status;
        }
    }
}
