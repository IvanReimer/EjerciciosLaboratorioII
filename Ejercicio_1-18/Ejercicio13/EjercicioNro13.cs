using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class EjercicioNro13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";
            string cadena = "1010100";
            Conversor conv = new Conversor();

            Console.WriteLine(Conversor.EnteroBinario(4));

            Console.WriteLine( Conversor.BinarioEntero( cadena) );

            Console.ReadKey();

        }
    }
}
