using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class EjercicioNro05
    {

        //Un centro numérico es un número que separa una lista de números enteros(comenzando en 1)
        //en dos grupos de números, cuyas sumas son iguales.El primer centro numérico es el 6, el
        //cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas 
        //iguales a 15. El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los
        //grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595. Se pide elaborar una aplicación 
        //que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            Console.WriteLine("Ingrese un numero");
            long numero = int.Parse(Console.ReadLine());
            long acum=0;
            long acum2 = 0;
            for(int i = 1; i < numero; i ++ )
            {
                for (int j = 0; j < i; j++)
                {
                    acum += j;
                }
                for(long k=i+1 ; k<acum ; k ++)
                {
                    acum2 += k;
                    if(acum2 == acum)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                acum = 0;
                acum2 = 0;
            }
            Console.ReadKey();
        }
    }
}
