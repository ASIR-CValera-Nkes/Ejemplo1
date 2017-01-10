using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        private static int resultado = 0, tabla = 2, iteraciones = 10;
        private static bool firstStep;

        static void Main(string[] args)
        {
            Console.Write("Introduzca el numero que quiere multiplicar: ");
            string r = Console.ReadLine();
            if (firstStep || !string.IsNullOrWhiteSpace(r) && int.TryParse(r, out tabla))
            {
                if (firstStep) firstStep = false;
                Console.Write("Introduzca el numero de iteraciones: ");
                r = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(r) && int.TryParse(r, out iteraciones))
                {
                    if (string.IsNullOrWhiteSpace(r)) Console.WriteLine("No has cambiado el numero.");
                    Console.Clear();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Vamos a calcular la tabla de multiplicar del {0} unas {1} veces en 3 segundos.", tabla, iteraciones);
                    Console.WriteLine("-------------------------");
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    for (int i = 0; i < iteraciones; ++i)
                    {
                        if (i > 0 && i % 100000 == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("PARANDO LA CONSOLA CADA 100K ITERACIONES UNOS 5 SEGUNDOS.");
                            Console.WriteLine();
                            Thread.Sleep(5000);
                        }
                        resultado = tabla * i;
                        Console.WriteLine("Iteración {0}: ({1} * {2}) = {3}", i, tabla, i, resultado);
                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Programa creado por Álvaro Rodríguez García en {0}.", DateTime.Today.Year);
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Pulse cualquier tecla para salir...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número entero.");
                    firstStep = true;
                    Main(null);
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero.");
                Main(null);
            }
        }
    }
}