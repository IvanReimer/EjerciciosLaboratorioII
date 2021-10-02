using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;
namespace PruebaGeometria
{
    class Ejercicio_18
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Punto punto1 = new Punto(-1,-3);
            //Punto punto2 = new Punto(-1,4);
            Punto punto3 = new Punto(2,4);
            //Punto punto4 = new Punto(2,-3);
            Rectangulo rect;
            rect = new Rectangulo(punto1, punto3);
            Console.WriteLine(Rectangulo.MostrarRectangulo(rect));
            Console.ReadKey();
        }

    }
}
