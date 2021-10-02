using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        #region Atributos
        private double cantidad;

        #endregion

        #region Constructores

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Sobrecarga de operadores explicitos e implicitos

        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius( (f.GetCantidad() - 32) * 5/9 );
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin( (f.GetCantidad() + 459.67 ) * 5/9 );
        }
        #endregion

        #region Sobrecarga de operadores algebraicos

        public static Fahrenheit operator +(Fahrenheit f,Celsius c)
        {
            return (Fahrenheit)(c + f);
        }
        public static Fahrenheit operator -(Fahrenheit f,Celsius c)
        {
            return f.GetCantidad() - ((Fahrenheit)c).GetCantidad();
        }

        public static Fahrenheit operator +(Fahrenheit f,Kelvin k)
        {
            return (Fahrenheit)(k+f);
        }

        public static Fahrenheit operator -(Fahrenheit f,Kelvin k)
        {
            return f.GetCantidad() - ((Fahrenheit)k).GetCantidad();
        }

        #endregion
    }
}
