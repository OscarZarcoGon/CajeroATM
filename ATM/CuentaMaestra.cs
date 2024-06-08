using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Cajero.ATM
{
    public class CuentaMaestra
    {
        public int ID { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public List<CuentaBancaria> Cuentas { get; set; }
        public decimal Cantidad { get; set; }

        public CuentaMaestra() { }
        public CuentaMaestra(int id, DateTime fechaTransaccion, decimal cantidad = 0)
        {
            this.ID = id;
            this.Fecha_Transaccion = fechaTransaccion;
            this.Cantidad = cantidad;
            Cuentas = new List<CuentaBancaria>();
        }

        public List<CuentaBancaria> CargarCuentas()
        {
            string archivo = "cuentas.json";
            if (File.Exists(archivo))
            {
                string DatosJSON = File.ReadAllText(archivo);
                return JsonConvert.DeserializeObject<List<CuentaBancaria>>(DatosJSON) ?? new List<CuentaBancaria>();
            }
            return new List<CuentaBancaria>();
        }

        public void GuardarCuentas(List<CuentaBancaria> cuentas)
        {
            string archivo = "cuentas.json";
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            string json = JsonConvert.SerializeObject(cuentas, Formatting.Indented, settings);
            File.WriteAllText(archivo, json);
        }

        public void RegistrarCuenta(CuentaBancaria nuevaCuenta)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();
            if (!cuentas.Exists(c => c.Numero_Cuenta == nuevaCuenta.Numero_Cuenta))
            {
                cuentas.Add(nuevaCuenta);
                GuardarCuentas(cuentas);
            }
            else
            {
                throw new InvalidOperationException("La cuenta ya existe.");
            }
        }

        public Tarjeta ObtenerTarjeta(long numeroTarjeta)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();

            foreach (var cuenta in cuentas)
            {
                foreach (var tarjeta in cuenta.TarjetasAsociadas)
                {
                    if (tarjeta.Numero_Tarjeta == numeroTarjeta)
                    {
                        return tarjeta;
                    }
                }
            }
            return null;
        }

        public bool VerificarTarjeta(long numeroTarjeta)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();

            foreach (var cuenta in cuentas)
            {
                foreach (var tarjeta in cuenta.TarjetasAsociadas)
                {
                    if (tarjeta.Numero_Tarjeta == numeroTarjeta)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Tarjeta ValidarTarjeta(long numeroTarjeta, int nip)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();

            foreach (var cuenta in cuentas)
            {
                foreach (var tarjeta in cuenta.TarjetasAsociadas)
                {
                    if (tarjeta.Numero_Tarjeta == numeroTarjeta && tarjeta.NIP == nip)
                    {
                        return tarjeta;
                    }
                }
            }
            return null;
        }

        public CuentaBancaria ConsultarSaldo(long numeroTarjeta)
        {
            if (VerificarTarjeta(numeroTarjeta))
            {
                List<CuentaBancaria> cuentas = CargarCuentas();

                foreach (var cuenta in cuentas)
                {
                    foreach (var tarjeta in cuenta.TarjetasAsociadas)
                    {
                        if (tarjeta.Numero_Tarjeta == numeroTarjeta)
                        {
                            return cuenta;
                        }
                    }
                }
            }

            return null;
        }

        public bool RetirarDinero(long numeroTarjeta, decimal cantidad)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();
            CuentaBancaria cuenta = BuscarCuentaPorTarjeta(numeroTarjeta, cuentas);
            if (cuenta != null && cuenta.Saldo >= cantidad)
            {
                cuenta.Saldo -= cantidad;
                GuardarCuentas(cuentas);
                return true;
            }
            return false;
        }

        public bool IngresarDinero(long numeroTarjeta, decimal cantidad)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();
            CuentaBancaria cuenta = BuscarCuentaPorTarjeta(numeroTarjeta, cuentas);
            if (cuenta != null)
            {
                cuenta.Saldo += cantidad;
                GuardarCuentas(cuentas);
                return true;
            }
            return false;
        }

        public bool TransferirDinero(long numeroTarjetaOrigen, long numeroTarjetaDestino, decimal cantidad)
        {
            if (RetirarDinero(numeroTarjetaOrigen, cantidad))
            {
                if (IngresarDinero(numeroTarjetaDestino, cantidad))
                {
                    return true;
                }
                else
                {
                    IngresarDinero(numeroTarjetaOrigen, cantidad);
                }
            }
            return false;
        }

        private CuentaBancaria BuscarCuentaPorTarjeta(long numeroTarjeta, List<CuentaBancaria> cuentas)
        {
            foreach (var cuenta in cuentas)
            {
                foreach (var tarjeta in cuenta.TarjetasAsociadas)
                {
                    if (tarjeta.Numero_Tarjeta == numeroTarjeta)
                    {
                        return cuenta;
                    }
                }
            }
            return null;
        }

        public bool CambiarNIP(long numeroTarjeta, int nuevoNIP)
        {
            List<CuentaBancaria> cuentas = CargarCuentas();
            Tarjeta tarjeta = BuscarTarjeta(numeroTarjeta, cuentas);

            if (tarjeta != null)
            {
                tarjeta.NIP = nuevoNIP;
                GuardarCuentas(cuentas);
                return true;
            }
            return false;
        }

        private Tarjeta BuscarTarjeta(long numeroTarjeta, List<CuentaBancaria> cuentas)
        {
            foreach (var cuenta in cuentas)
            {
                foreach (var tarjeta in cuenta.TarjetasAsociadas)
                {
                    if (tarjeta.Numero_Tarjeta == numeroTarjeta)
                    {
                        return tarjeta;
                    }
                }
            }
            return null;
        }
    }
}
