using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            //Lapiz miLapiz1 = new Lapiz(1);
            Boligrafo miBoligrafo = new Boligrafo(2, ConsoleColor.Green);
            //Boligrafo miBoligrafo1 = new Boligrafo(2, ConsoleColor.Red);
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            //Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            //Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miBoligrafo);

            Cartuchera1 c1 = new Cartuchera1();
            Cartuchera2 c2 = new Cartuchera2();

            c1.Utiles.Add(miLapiz);
            //c1.Utiles.Add(miLapiz1);
            c1.Utiles.Add(miBoligrafo);
            //c1.Utiles.Add(miBoligrafo1);

            c2.Lapices.Add(miLapiz);
            //c2.Lapices.Add(miLapiz1);
            c2.Boligrafos.Add(miBoligrafo);
            //c2.Boligrafos.Add(miBoligrafo1);

            Console.WriteLine(c1.ProbarElementos());
            Console.WriteLine(c1.ProbarElementos());
            Console.WriteLine(c1.ProbarElementos());
            Console.WriteLine(c1.ProbarElementos());



            Console.ReadKey();
        }
    }
}
