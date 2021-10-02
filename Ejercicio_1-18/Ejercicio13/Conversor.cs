using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string EnteroBinario(int numero)
        {
            string cadena = "";
            while (numero / 2 != 0) 
            {
                cadena = cadena + Math.Abs(numero) % 2;
                numero /= 2;
            }
            cadena = cadena + Math.Abs(numero);
            return Conversor.InvertirCadena(cadena);
        }
        
        public static int BinarioEntero(string cadena)
        {
            int numero=0;
            string cadenaInvertida = Conversor.InvertirCadena(cadena);
            for (int i = cadenaInvertida.Length-1; i >= 0 ; i--)
            {
                numero += (int)Math.Pow(2,i) * int.Parse(cadenaInvertida[i].ToString());
            }
            return numero;
        }
        private static string InvertirCadena(string cadena)
        {
            string cadenaInvertida = "";
            for (int j = cadena.Length - 1; j >= 0; j--)
            {
                cadenaInvertida = cadenaInvertida + cadena[j];
            }
            return cadenaInvertida;
        }
    }
}
