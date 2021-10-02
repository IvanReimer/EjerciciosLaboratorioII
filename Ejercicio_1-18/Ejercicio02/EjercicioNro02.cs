using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class EjercicioNro02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int numero;
            bool ingresoBien, flag = false;
            do
            {
                if (flag)
                {
                    Console.WriteLine("ERROR. ¡Reingresar numero!");
                }
                else
                {
                    Console.WriteLine("Ingrese un numero");
                    flag = true;
                }
                ingresoBien = int.TryParse(Console.ReadLine(), out numero);
            }
            while (!ingresoBien);

            Console.WriteLine("El cuadrado del mismo es: {0}, y el cubo del mismo es: {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));

            /*
            string[] cualquierNombre = {"Fede","Mau","Lucas"}
            for (int i = 0; i < cualquierNombre.Length; i++)
            {
                string elem = cualquierNombre[i];
                Console.WriteLine(elem);
            }*/
            Console.ReadKey();
        }
    }
}
