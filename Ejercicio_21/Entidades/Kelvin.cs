using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        #region Atributos
        private double cantidad;
        #endregion

        #region Constructores
        public Kelvin(double cantidad)
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

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit( k.GetCantidad() * 9/5 - 459.67);
        }

        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.GetCantidad() - 273.15);
        }
        #endregion

        #region Sobrecarga de operadores logicos

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.GetCantidad() == k2.GetCantidad();
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return ! (k1 == k2);
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.GetCantidad() == ((Kelvin)f).GetCantidad();
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.GetCantidad() == ((Kelvin)c).GetCantidad();
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }


        #endregion

        #region Sobrecarga de operadores algebraicos

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return k.GetCantidad() + ((Kelvin)c).GetCantidad();
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return k.GetCantidad() - ((Kelvin)c).GetCantidad();
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return k.GetCantidad() + ((Kelvin)f).GetCantidad();
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return k.GetCantidad() - ((Kelvin)f).GetCantidad();
        }

        #endregion
    }
}
