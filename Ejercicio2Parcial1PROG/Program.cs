using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Parcial1PROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Suma de los dos primeros y el producto del tercero y el cuarto.";


            Double n1, n2, totalsuma, n3, n4, totalmult;

            Console.Write("Ingrese el primer número a calcular: ");
            n1 = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número a calcular: ");
            n2 = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número a calcular: ");
            n3 = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número a calcular: ");
            n4 = Double.Parse(Console.ReadLine());

            totalsuma = n1 + n2;

            totalmult = n3 * n4;
            
            Console.WriteLine("La suma de los dos primeros números es: " + totalsuma + ".");

            Console.WriteLine("El producto del tercer número con el cuarto número es: " + totalmult + ".");



            Console.ReadKey();
        }
    }
}
