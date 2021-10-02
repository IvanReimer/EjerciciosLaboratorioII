using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversor;
namespace Ejercicio_22
{
    class EjercicioNro22
    {
        static void Main(string[] args)
        {
            NumeroBinario binario = "1010";

            NumeroDecimal entero = 6;

            Console.WriteLine(binario - entero);
            Console.ReadKey();
        }
    }
}
