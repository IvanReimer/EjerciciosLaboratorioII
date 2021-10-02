using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libros;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();
            String[] pagina = new string[4];
            pagina[0] = "Erase una vez";
            pagina[1] = " un lobito bueno";
            pagina[2] = " al que matrataban";
            pagina[3] = " todos los corderos.";
            for (int i = 0; i < 4; i++)
            {
                l[i] = pagina[i];
            }
            //l[0] = "Había una vez";
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(l[i]);
            }

            Console.ReadKey();



        }
    }
}
