using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class EjercicioNro03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            bool flag=true;
            for (int i = 2; i <= numero; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0 && i != 2 )
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    Console.WriteLine(i);
                }
                flag = true;
            }
            Console.ReadKey();

        }
    }
    
}
