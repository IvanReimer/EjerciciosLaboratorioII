using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class EjercicioNro06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            Console.WriteLine("Ingrese un año");
            int numero = int.Parse(Console.ReadLine());
            if(numero % 4 == 0 && (numero % 100 != 0 || numero % 400 == 0))
            {
                Console.WriteLine("El año es biciesto");
            }
            else
            {
                Console.WriteLine("El año no es biciesto");
            }
            Console.ReadKey();
        }
    }
}
