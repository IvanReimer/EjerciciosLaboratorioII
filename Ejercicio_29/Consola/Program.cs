using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(30,"River");
            Jugador j1 = new Jugador(123, "Juan");
            Jugador j2 = new Jugador(321,"Pepe",10,3);
            Jugador j3 = new Jugador(321,"ASda",10,3);

            if (e + j1)
            {
                Console.WriteLine("Se agrego al equipo{0} ", j1.MostrarDatos());

            }
            else
            {
                Console.WriteLine("Boca es malo");
            }

            if (e + j2)
            {
                Console.WriteLine("Se agrego al equipo {0} ", j2.MostrarDatos());

            }
            else
            {
                Console.WriteLine("Reimer aprueba");
            }if (e + j3)
            {
                Console.WriteLine("Se agrego al equipo {0} ", j2.MostrarDatos());

            }
            else
            {
                Console.WriteLine("Reimer aprueba y boca es malo");
            }

            Console.ReadKey();

        }
    }
}
