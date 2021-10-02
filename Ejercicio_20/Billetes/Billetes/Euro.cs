using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga de operadores explicitos e implicitos

        public static explicit operator Dolar(Euro p)
        {
            return new Dolar(p.cantidad * Euro.GetCotizacion());
        }
        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)(Dolar)e;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }



        #endregion

        #region Sobrecarga de operadores logicos

        public static bool operator ==(Euro e, Dolar d)
        {
            return d == e;
        }

        public static bool operator !=(Euro e, Dolar d)
        {

            return !(d == e);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        #endregion

        #region Sobrecarga de operadores algebraicos

        public static Euro operator +(Euro e, Dolar d)
        {
            return (Euro)(d+e);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - ((Euro)d).GetCantidad();
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return e.GetCantidad() + ((Euro)p).GetCantidad();
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return e.GetCantidad() - ((Euro)p).GetCantidad();
        }

        #endregion

    }
}
