using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class EjercicioNro10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            Console.WriteLine("Ingrese un numero");

            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                for (int k = 1; k <= numero-i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
