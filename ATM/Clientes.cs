namespace Cajero.ATM
{
    public class Cliente
    {
        public int NumeroCliente { get; private set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCorte { get; set; }
        public long Telefono { get; set; }
        public List<Tarjeta> Tarjetas { get; set; }

        public Cliente(int numeroCliente, string nombre, DateTime fechaNacimiento, DateTime fechaCorte, long telefono)
        {
            this.NumeroCliente = numeroCliente;
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
            this.FechaCorte = fechaCorte;
            this.Telefono = telefono;
            Tarjetas = new List<Tarjeta>();
        }
    }
}
