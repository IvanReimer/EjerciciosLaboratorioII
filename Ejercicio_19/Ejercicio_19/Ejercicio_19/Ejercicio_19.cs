using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Ejercicio_19
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {

            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(3);

            sumador1.Sumar("","");
            sumador1.Sumar(1, 2);
            Console.WriteLine(sumador1.Sumar("hola", "como estas?")) ;

            Console.WriteLine(sumador1 + sumador2);

            Console.WriteLine(sumador1 | sumador2);
            Console.ReadKey();
        }
    }
}
