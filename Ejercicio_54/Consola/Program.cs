using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using IO;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
			String path = DateTime.Now.ToString(@"yyyyMMdd-HHmm")+ ".txt";
			try
			{
				OtraClase clase = new OtraClase();
			}
			catch (MiExcepcion a)
			{
				Exception excepcion = a;
				String textoAGuardar = String.Empty;
				
				while (excepcion != null)
				{
					textoAGuardar += excepcion.Message + "\n";
					//Console.WriteLine(excepcion.Message);
					excepcion = excepcion.InnerException;
				}
				if (ArchivoTexto.Guardar(path,textoAGuardar))
				{
					Console.WriteLine("Se guardo el archivo exitosamente");
				}
			}
			Console.WriteLine(ArchivoTexto.Leer(path));
			Console.ReadLine();


        }
    }
}
