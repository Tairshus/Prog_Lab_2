using System;
using Cuentas;

namespace Clase3_Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";
            Cuenta c1 = new Cuenta("Charly Walle", 500);
            Console.WriteLine(c1.Mostrar());
            if (!(c1.Ingresar(500)))
                Console.WriteLine("El monto ingresado no es valido");

            Console.WriteLine(c1.Mostrar());
            if (!(c1.Ingresar(-30)))
                Console.WriteLine("El monto ingresado no es valido");

            Console.WriteLine(c1.Mostrar());
            c1.Retirar(50);

            Console.WriteLine(c1.Mostrar());
        }
    }
}
