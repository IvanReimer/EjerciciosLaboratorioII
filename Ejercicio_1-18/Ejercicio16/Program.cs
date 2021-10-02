using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Alumno[] alumnos = new Alumno[3];
            byte primerNota;

            #region Ingreso de datos

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Clear();
                alumnos[i] = new Alumno();
                //Console.WriteLine("Ingrese un nombre");

                //alumnos[i].nombre = Console.ReadLine();

                //Console.WriteLine("Ingrese un apellido");

                //alumnos[i].apellido = Console.ReadLine();

                //Console.WriteLine("Ingrese un legajo");

                //alumnos[i].legajo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese primer nota");

                primerNota = byte.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese segunda nota");

                alumnos[i].Estudiar(primerNota,byte.Parse(Console.ReadLine()));

            }
            #endregion

            #region Salida de datos
            Console.Clear();
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine(alumnos[i].Mostrar());
            }
            #endregion
            
            
            Console.ReadKey();
        }
    }
}
