using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class EjercicioNro14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double ladoCuadrado = 0, baseTriangulo= 0, alturaTriangulo = 0, radioCirculo =0;
            int i = 3;
            Console.WriteLine("Ingrese el lado de un cuadrado (3 intentos)");
            while (i >= 1 && (!double.TryParse(Console.ReadLine(), out ladoCuadrado) || ladoCuadrado <= 0))
            {
                i--;
                if (i > 0)
                {
                    Console.WriteLine("Error, reingrese. Le quedan {0} intentos", i);
                }
            }
            i = 3;
            Console.WriteLine("Ingrese la base de un triangulo (3 intentos)");
            while (i >= 1 && (!double.TryParse(Console.ReadLine(), out baseTriangulo) || baseTriangulo <= 0))
            {
                i--;
                if (i > 0)
                {
                    Console.WriteLine("Error, reingrese. Le quedan {0} intentos", i);
                }
            }
            if (i > 0)
            {
                i = 3;
                Console.WriteLine("Ingrese la altura del triángulo ({0} intentos)", i);
            }
            while (i >= 1 && (!double.TryParse(Console.ReadLine(), out alturaTriangulo) || alturaTriangulo <= 0))
            {
                i--;
                if (i > 0)
                {
                    Console.WriteLine("Error, reingrese. Le quedan {0} intentos", i);
                }
            }
            i = 3;
            Console.WriteLine("Ingrese el radio de un circulo (3 intentos)");
            while (i >= 1 && (!double.TryParse(Console.ReadLine(), out radioCirculo) || radioCirculo <= 0))
            {
                i--;
                if (i > 0)
                {
                    Console.WriteLine("Error, reingrese. Le quedan {0} intentos", i);
                }
            }
            if (radioCirculo != 0 && alturaTriangulo != 0 && baseTriangulo != 0 && ladoCuadrado != 0)
            {
                Console.WriteLine("Area cuadrado: {0}", CalculoDeArea.CalcularCuadrado(ladoCuadrado));
                Console.WriteLine("Area triángulo: {0}", CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo));
                Console.WriteLine("Area círculo: {0:#,###.00}", CalculoDeArea.CalcularCirculo(radioCirculo));
                //Console.WriteLine("Area círculo: {0:0.00}", CalculoDeArea.CalcularCirculo(radioCirculo));
            }
            Console.ReadKey();
        }
    }
}
