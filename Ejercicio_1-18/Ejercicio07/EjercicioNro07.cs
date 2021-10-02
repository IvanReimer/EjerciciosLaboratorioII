using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class EjercicioNro07
    {
        //Hacer un programa que pida por pantalla
        //la fecha de nacimiento de una persona(día, mes y año)
        //y calcule el número de días vividos por esa persona
        //hasta la fecha actual(tomar la fecha del sistema con DateTime.Now).
        //Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07"

            Console.WriteLine("Ingrese su año de nacimiento:");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su mes de nacimiento:");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su dia de nacimiento:");
            int dia = int.Parse(Console.ReadLine());

            DateTime diaDeHoy = DateTime.Now.Date;

            DateTime diadeNacimiento = new DateTime(año, mes, dia);


            double diasVividos =  (diaDeHoy - diadeNacimiento).TotalDays ;

            Console.WriteLine(diasVividos);


            Console.ReadKey();
        }
    }
}
