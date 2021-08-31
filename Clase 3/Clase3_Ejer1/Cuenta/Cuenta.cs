using System;

namespace Cuentas
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            return $"Titular: {GetTitular()}, Cantidad: {GetCantidad()}"; 
        }

        public bool Ingresar(decimal cantidadAcreditar)
        {
            if(cantidadAcreditar > 0)
            {
                cantidad += cantidadAcreditar;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Retirar(decimal cantidadRetirar)
        {
            cantidad -= cantidadRetirar;
        }
    }
}
