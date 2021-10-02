using System;

namespace Ejercicio01
{
    class EjercicioNro01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            Console.WriteLine("Ingresa un número:");
            int maximo = int.Parse(Console.ReadLine());
            int minimo = maximo;
            int aux, acum=0;
            for(byte i=0;i<4;i++)
            {
                Console.WriteLine("Ingrese un numero");
                
                aux = int.Parse(Console.ReadLine());
                if (aux > maximo)
                {
                    maximo = aux;
                }
                if(aux< minimo)
                {
                    aux = minimo;
                }
                acum+=aux;
            }
            Console.WriteLine("El maximo es {0}, el minimo es {1}, el promedio es {2}",maximo,minimo,acum/5);
        }
    }
}
