using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio12
{
    class EjercicioNro12
    {

        //Realizar un programa que sume números 
        //enteros hasta que el usuario lo determine,
        //por medio de un mensaje "¿Continuar? (S/N)".
        //En el método estático ValidaS_N(char c) de la clase
        //ValidarRespuesta, se validará el ingreso de opciones.
        //El método devolverá un valor de tipo booleano, TRUE si se ingresó 
        //una 'S' y FALSE si se ingresó cualquier otro valor.
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12"; 
            char rta ='n';
            int sumatoria = 0,numero=0;
            bool flag = true;
            do
            {
                Console.WriteLine("Ingrese número: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    sumatoria += numero;
                }
                else
                {
                    int i;
                    for (i = 3; i > 0; i--)
                    {
                        Console.WriteLine("ERROR, se le pidio un NUMERO. Reingrese. Le quedan {0} oportunidades", i);
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            sumatoria += numero;
                            break;
                        }
                    }
                    if (i == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("¿Continuar? S/N");
                    rta = Console.ReadKey().KeyChar;
                }

            } while (ValidarRespuesta.ValidaS_N(rta) && flag);
            if (flag)
            {
                Console.WriteLine("La sumatoria es: {0}", sumatoria);
            }
            Console.ReadKey();
        }
    }
}
