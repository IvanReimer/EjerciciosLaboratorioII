using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        #region Atributos
        private double cantidad;

        #endregion

        #region Constructores
        public Celsius(double cantidad)
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

        #region Sobrecarga de operadores implicitos y explicitos

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit( c.GetCantidad() * 9 / 5 + 32);
        }

        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.GetCantidad() + 273.15);
        }

        #endregion

        #region Sobrecarga de operadores logicos

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.GetCantidad() == c2.GetCantidad();
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1==c2);
        }

        public static bool operator ==(Celsius c1, Fahrenheit f)
        {
            return c1.GetCantidad() == ((Fahrenheit)f).GetCantidad();
        }
        public static bool operator !=(Celsius c1, Fahrenheit f)
        {
            return !(c1 == f);
        }

        public static bool operator ==(Celsius c1, Kelvin k)
        {
            return k == c1;
        }
        public static bool operator !=(Celsius c1, Kelvin k)
        {
            return !(c1 == k);
        }


        #endregion

        #region Sobrecarga de operadores algebraicos

        public static Celsius operator +(Celsius c,Kelvin k)
        {
            return (Celsius)(k + c);
        }
        public static Celsius operator -(Celsius c,Kelvin k)
        {
            return c.GetCantidad() - ((Celsius)k).GetCantidad();
        }

        public static Celsius operator +(Celsius c,Fahrenheit f)
        {
            return c.GetCantidad() + ((Fahrenheit)f).GetCantidad();
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return c.GetCantidad() - ((Fahrenheit)f).GetCantidad();
        }

        #endregion
    }
}
