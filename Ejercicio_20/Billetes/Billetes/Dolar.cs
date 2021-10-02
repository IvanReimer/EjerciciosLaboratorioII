using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {

        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Geters
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region SobreCarga de operadores implicitos y explicitos

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.GetCantidad() / Pesos.GetCotizacion());
        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        #endregion

        #region SobreCarga de operadores Logicos
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }

        public static bool operator !=(Dolar d, Euro e)
        {

            return !(d == e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.GetCantidad() == ((Dolar)p).GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d==p);
        }

        public static bool operator==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return ! (d1 == d2);
        }


        #endregion

        #region Sobrecarga de operadores algebraicos

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.GetCantidad() + ((Dolar)p).GetCantidad();
        }
        public static Dolar operator -(Dolar d,Pesos p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }


        #endregion

    }
}
