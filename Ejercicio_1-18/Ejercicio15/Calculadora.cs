using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {

        public static float Calcular(float num1, float num2, string operacion)
        {
            float result;
            switch (operacion)
            {
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (Calculadora.Validar(num2))
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error. No se puede dividir sobre 0. Se retornara la suma");
                        result = num1 + num2;
                    }
                    break;
                default:
                    result = num1 + num2;
                    break;
            }
            return result;
        }
        private static bool Validar(float num)
        {
            return num != 0;
        }

    }
}
