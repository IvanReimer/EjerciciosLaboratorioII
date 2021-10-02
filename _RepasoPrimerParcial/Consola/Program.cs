using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,String> cadenas = new SortedList<int,string>();
            Dictionary<int, String> diccionario = new Dictionary<int, string>();
            diccionario.Add(0,"Ivan");
            diccionario.Add(1,"Nicolas");
            diccionario.Add(2,"Laura");
            diccionario.Add(3,"Haydee");
            cadenas.Add(1, "Hola");
            Console.WriteLine(cadenas[1]);
            Console.WriteLine(diccionario[1]);
            Console.ReadLine();
        }
    }
}
