using System;
using System.Collections.Generic;

namespace Cajero.ATM
{
    public class CajeroBancario
    {
        public int Id { get; set; }
        public CuentaMaestra CuentaMaestra { get; set; }

        public CajeroBancario()
        {
            CuentaMaestra = new CuentaMaestra(1, DateTime.Now);
        }

        public CajeroBancario(int id, CuentaMaestra cuentaMaestra)
        {
            Id = id;
            CuentaMaestra = cuentaMaestra;
        }

        public string MostrarOpciones(int opcion, long numeroTarjeta, int nuevoNip, decimal cantidad = 0, long numeroTarjetaDestino = 0)
        {
            switch (opcion)
            {
                case 1:
                    return ConsultarSaldo(numeroTarjeta);
                case 2:
                    return RetirarDinero(numeroTarjeta, cantidad);
                case 3:
                    return DepositarDinero(numeroTarjeta, cantidad);
                case 4:
                    return Transferir(numeroTarjeta, numeroTarjetaDestino, cantidad);
                case 5:
                    return CambiarNIP(numeroTarjeta, nuevoNip);
                default:
                    return "Opción no válida";
            }
        }

        public string RetirarDinero(long numeroTarjeta, decimal cantidad)
        {
            bool exito = CuentaMaestra.RetirarDinero(numeroTarjeta, cantidad);
            if (exito)
            {
                return $"Se han retirado {cantidad:C}.";
            }
            return "No se pudo realizar el retiro.";
        }

        public string DepositarDinero(long numeroTarjeta, decimal cantidad)
        {
            bool exito = CuentaMaestra.IngresarDinero(numeroTarjeta, cantidad);
            if (exito)
            {
                return $"Se han depositado {cantidad:C} en la cuenta asociada a la tarjeta {numeroTarjeta}.";
            }
            return "No se pudo realizar el depósito.";
        }

        public string Transferir(long numeroTarjetaOrigen, long numeroTarjetaDestino, decimal cantidad)
        {
            bool exito = CuentaMaestra.TransferirDinero(numeroTarjetaOrigen, numeroTarjetaDestino, cantidad);
            if (exito)
            {
                return $"Se han transferido {cantidad:C} de la tarjeta {numeroTarjetaOrigen} a la tarjeta {numeroTarjetaDestino}.";
            }
            return "No se pudo realizar la transferencia.";
        }

        public string ConsultarSaldo(long numeroTarjeta)
        {
            CuentaBancaria cuenta = CuentaMaestra.ConsultarSaldo(numeroTarjeta);
            if (cuenta != null)
            {
                return $"El saldo de la cuenta es {cuenta.Saldo:C}.";
            }
            return "No se pudo consultar el saldo.";
        }

        public string CambiarNIP(long numeroTarjeta, int nuevoNIP)
        {
            if (nuevoNIP.ToString().Length != 4)
            {
                return "El NIP debe tener 4 dígitos.";
            }

            bool exito = CuentaMaestra.CambiarNIP(numeroTarjeta, nuevoNIP);
            if (exito)
            {
                return $"El NIP de la tarjeta {numeroTarjeta} ha sido cambiado exitosamente.";
            }
            return "No se pudo cambiar el NIP.";
        }
    }
}
