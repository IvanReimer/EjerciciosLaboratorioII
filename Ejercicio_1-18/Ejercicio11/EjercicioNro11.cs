using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class EjercicioNro11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int max=int.MinValue, min=int.MaxValue, acum = 0, cont= 0, numero;
            while(cont < 10)
            { 
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                if (int.TryParse(Console.ReadLine(), out numero) && Validacion.Validar(numero, -100, 100))
                {
                    if (max < numero)
                    {
                        max = numero;
                    }
                    if (min > numero)
                    {
                        min= numero;
                    }
                    acum = acum + numero;
                    cont++;
                }
                else
                {
                    Console.WriteLine("Error ingrese un NUMERO entre -100 y 100");
                }
            }
            Console.WriteLine("Maximo: {0}, Minimo: {1}, Promedio: {2}",max,min,acum/cont);
            Console.ReadKey();
        }
    }
}
