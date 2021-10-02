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
			try
			{
				OtraClase clase = new OtraClase();
			}
			catch (MiExcepcion a)
			{
				Exception excepcion = a;
				while (excepcion != null)
				{
					Console.WriteLine(excepcion.Message);
					
					excepcion = excepcion.InnerException;
				}
				//Console.WriteLine(a.InnerException.InnerException.Message);
				//Console.WriteLine(a.InnerException.Message);
				//Console.WriteLine(a.Message);
			}
			Console.ReadLine();


        }
    }
}
