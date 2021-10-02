using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas;
namespace Ejercicio_21
{
    class Ejercicio_21
    {
        static void Main(string[] args)
        {
            Fahrenheit f = 32;
            Kelvin k = 0;
            Celsius c = 0;


            Console.WriteLine(((Celsius)f).GetCantidad());



            Console.ReadKey();

        }
    }
}
