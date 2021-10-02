using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetenciaCarrera;
namespace TestCarrera
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(1, "escu1");
            AutoF1 a6 = new AutoF1(7, "Escu7");
            AutoF1 a2 = new AutoF1(4, "escu2");
            MotoCross m3 = new MotoCross(5, "escu3", 5);
            AutoF1 a4 = new AutoF1(1, "escu1");
            MotoCross m5 = new MotoCross(2, "escu4");
            Competencia competencia = new Competencia(10, 40, Competencia.TipoCompetencia.F1);
            if (competencia + a6)
            {
                Console.WriteLine("SE AGREGO a6");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO a6");
            }
            if (competencia + a4)
            {
                Console.WriteLine("SE AGREGO a4");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO a4");
            }
            if (competencia + a2)
            {
                Console.WriteLine("SE AGREGO a2");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO a2");
            }
            if (competencia + m3)
            {
                Console.WriteLine("SE AGREGOm3");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO m3");
            }
            if (competencia + a1)
            {
                Console.WriteLine("SE AGREGO a1");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO a1");
            }
            if (competencia + m5)
            {
                Console.WriteLine("SE AGREGO m5");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO m5");
            }
            if (competencia + a6)
            {
                Console.WriteLine("ANDA MAL");
            }
            else
            {
                Console.WriteLine("ANDA BIEN");
            }
            Console.WriteLine(competencia.MostrarDatos());
            Console.ReadKey();
        }
    }
}
