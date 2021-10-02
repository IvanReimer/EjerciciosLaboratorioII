using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pila p = new Pila();
            Random r = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    p.AgregarElemento(r.Next(-10,10));
            //}
            //Pila.MostrarElementos(p);
            //Console.WriteLine("----------------------");
            //p = Pila.OrdenarNegativosAsc(p);
            //Pila.MostrarElementos(p);

            //Cola c = new Cola();
            //for (int i = 0; i < 10; i++)
            //{
            //    c.AgregarElemento(r.Next(-10, 10));
            //}
            //Cola.MostrarElementos(c);
            //Console.WriteLine("--------");
            //Cola.MostrarElementos(c.OrdenarNegativosDesc(c));
            Lista l = new Lista();
            for (int i = 0; i < 10; i++)
            {
                l.AgregarElemento(r.Next(-10,10));
            }
            Lista.MostrarElementos(l);
            Console.WriteLine("------------");
            l = l.OrdenarNegativosDesc(l);

            Lista.MostrarElementos(l);


            Console.ReadKey();
        }
    }
}
