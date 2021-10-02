using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class NumeroDecimal
    {
        #region Atributos
        private double numero;

        #endregion

        #region Constructores

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        #endregion

        #region Sobrecarga de operadores logicos

        public static bool operator ==(NumeroDecimal entero,NumeroBinario binary )
        {
            return Conversor.BinarioDecimal(binary) == (double)entero;
        }
        public static bool operator !=(NumeroDecimal entero,NumeroBinario binary)
        {
            return !(entero == binary);
        }

        #endregion

        #region Sobrecarga de operadores algebraicos
        public static double operator +(NumeroDecimal num1, NumeroBinario num2)
        {
            return Conversor.BinarioDecimal(num2) + (double)num1;
        }
        public static double operator -(NumeroDecimal num1,NumeroBinario num2 )
        { 
            return (double)num1 - Conversor.BinarioDecimal(num2);
        }
        #endregion

        #region Sobrecarga de operadores implicitos y explicitos

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator double(NumeroDecimal n)
        {
            return n.numero;
        }
        #endregion

    }
}
