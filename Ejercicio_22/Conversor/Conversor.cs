using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Conversor
    {
        public static string DecimalBinario(NumeroDecimal numero)
        {
            return Convert.ToString((int)(double)numero,2);
        }

        public static double BinarioDecimal(NumeroBinario numero)
        {
            return Convert.ToInt32( (string)numero, 2);
        }
        public static bool isBinary(string arg)
        {
            short i=0;
            bool isBinary=false;
            while (arg.Length > i && (arg[i] == '1' || arg[i] == '0'))
            {
                i++;
            }
            if (arg.Length == i && arg != String.Empty)
            {
                isBinary = true;
            }
            return isBinary;
        }
    }
}
