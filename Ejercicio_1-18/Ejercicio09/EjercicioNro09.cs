using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class EjercicioNro09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 9";
            
            Console.WriteLine("Ingrese un numero");

            int numero = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i*2-1 ; j++)
                { 
                   Console.Write("*");       
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
