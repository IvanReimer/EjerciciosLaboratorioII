using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arrays;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Arreglo array = new Arreglo(20);
            Random random = new Random();
            for (int i = 0; i < array.Lenght; i++)
            {
                array.CargarNumero(random.Next(-10,10),i);
            }

            array.MostrarVector();
            Console.WriteLine("-------------------");
            int [] negativos = array.GetNegativosCreciente();

            for (int i = 0; i < negativos.Length; i++)
            {
                Console.WriteLine(negativos[i]);
            }



            Console.ReadKey();
        }
    }
}
