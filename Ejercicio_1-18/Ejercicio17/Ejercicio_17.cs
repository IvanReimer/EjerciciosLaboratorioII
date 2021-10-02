using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utiles;
namespace Ejercicio17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            string tintura;

            if (boligrafoAzul.Pintar(10,out tintura))
            {
                Console.WriteLine(tintura);
            }
            if (boligrafoRojo.Pintar(25, out tintura))
            {
                Console.WriteLine(tintura);
            }

            Console.ReadKey();
        }
    }
}
