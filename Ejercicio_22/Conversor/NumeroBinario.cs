using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroBinario
    {
        #region Atributos
        private string numero;
        #endregion

        #region Constructores
        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        #endregion

        #region Sobrecarga de operadores logicos

        public static bool operator ==(NumeroBinario num1, NumeroDecimal num2)
        {
            return num2 == num1;
        }
        public static bool operator !=(NumeroBinario num1, NumeroDecimal num2)
        {
            return num2 != num1;
        }
        #endregion

        #region Sobrecarga de operadores algebraicos

        public static string operator +(NumeroBinario num1, NumeroDecimal num2)
        {
            return Conversor.DecimalBinario(num2 + num1);
        }
        public static string operator -(NumeroBinario num1, NumeroDecimal num2)
        {
            return Conversor.DecimalBinario(Conversor.BinarioDecimal(num1)-(double)num2);
        }
        #endregion

        #region Sobrecarga de operadores implicitos y explicitos

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }
        public static explicit operator string(NumeroBinario n)
        {
            return n.numero;
        }
        #endregion

    }
}
