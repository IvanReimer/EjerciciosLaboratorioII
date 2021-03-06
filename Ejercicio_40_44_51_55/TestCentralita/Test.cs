using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;
namespace TestCentralita
{
    class Test
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Call Center");
            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f); 
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            c += l1;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();
            c += l2;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();
            c += l3;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();
            try
            {
                c += l4;
            }
            catch (CentralitaExcepcion error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.WriteLine("TERMINO");
            Console.Clear();
            Console.ReadKey();
        }
    }
}
