using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtencionAlCliente;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1);
            cliente1.Nombre = "";
            Cliente cliente2 = new Cliente(2, "Nicolas");
            Cliente cliente3 = new Cliente(3, "Laura");
            Cliente cliente4= new Cliente(4, "Violeta");
            Cliente cliente5 = new Cliente(5, "Haydee");
            PuestoAtencion caja1 = new PuestoAtencion(Puesto.Caja1);
            PuestoAtencion caja2 = new PuestoAtencion(Puesto.Caja2);
            Negocio constantino = new Negocio("Constantino");

            if (constantino + cliente1)
            {
                Console.WriteLine("Agregado :"+cliente1.Nombre);
            }
            if (constantino + cliente2)
            {
                Console.WriteLine("Agregado: "+ cliente2.Nombre);
            }
            if (constantino + cliente3)
            {
                Console.WriteLine("Agregado: "+ cliente3.Nombre);
            }
            if (constantino + cliente4)
            {
                Console.WriteLine("Agregado: "+ cliente4.Nombre);
            }
            if (constantino + cliente5)
            {
                Console.WriteLine("Agregado: "+ cliente5.Nombre);
            }

            if (constantino + cliente3)
            {
                Console.WriteLine("Agregado: "+ cliente3.Nombre);
            }
            else
            {
                Console.WriteLine("Repetido "+cliente3.Nombre);
            }
            Console.WriteLine("Proximo cliente a atender: " + constantino.Cliente.Nombre);
            Console.WriteLine("Clientes pendientes:");
            foreach (Cliente cliente in constantino.ClientesPendientes)
            {
                Console.WriteLine(cliente.Nombre);
            }
            if (~constantino)
            {
                Console.WriteLine("Se atendio exitosamente. "+ constantino.Cliente.Nombre + ". Proximo a atender" );
            }
            Console.WriteLine("Clientes pendientes:");
            foreach (Cliente cliente in constantino.ClientesPendientes)
            {
                Console.WriteLine(cliente.Nombre);
            }
            Console.ReadKey();
        }
    }
}
