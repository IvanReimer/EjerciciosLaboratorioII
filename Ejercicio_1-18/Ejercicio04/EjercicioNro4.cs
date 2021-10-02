using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class EjercicioNro4
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            Console.WriteLine("Ingrese un numero");
            long numero = int.Parse(Console.ReadLine());
            long acum = 0;
            for (long j = 1; j < numero; j++)
            {
                for (long i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        acum += i;
                    }
                }
                if (acum == j)
                {
                    Console.WriteLine(acum);
                }
                acum = 0;

            }

            Console.ReadKey();
        }
    }
}
