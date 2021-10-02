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
            Persona persona = new Persona("Ivan", "Reimer");
            Persona personaSerializada;
            Persona.Guardar(persona);
            personaSerializada = Persona.Leer();
            Console.WriteLine(personaSerializada.ToString());
            Console.ReadKey();
        }
    }
}
