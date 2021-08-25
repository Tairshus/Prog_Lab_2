using System;
using System.Text;
using Validadores;

namespace Clase_02_Ejer1
{
    class Program
    {
        private static int valor;
        private static int minimo = 100;
        private static int maximo = -100;
        private static bool validarEntero;
        private static bool rangoValidado;
        private static int contarValidados = 0;
        private static int promedio = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entero: ");
                validarEntero = int.TryParse(Console.ReadLine(), out valor);
                if (validarEntero)
                {
                    rangoValidado = Validador.Validar(valor, -100, 100);
                    if(rangoValidado)
                    {
                        if(valor >= maximo)
                        {
                            maximo = valor;
                        }
                        else if(valor <= minimo)
                        {
                            minimo = valor;
                        }
                    }
                    promedio += valor;
                    contarValidados++;
                }
                else
                {
                    Console.WriteLine("Eso no fue un entero.");
                }
            }

            //StringBuilder stringBuilder = new StringBuilder();
            //Anexa un nuevo texto sin generar saltos de linea
            //stringBuilder.AppendLine("Resultados:");
            //stringBuilder.AppendFormat()

            if (contarValidados > 0)
            {
                promedio = promedio / contarValidados;
                Console.WriteLine("El valor minimo es {0}", minimo);
                Console.WriteLine("El valor maximo es {0}", maximo);
                Console.WriteLine("El promedio ingresado es {0}", promedio);
            }
        }
    }
}
