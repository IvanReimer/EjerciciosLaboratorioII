using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Pesos()
        {
            Pesos.cotizRespectoDolar = 1 / 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga de operadores explicitos e implicitos
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(Pesos.GetCotizacion() * p.GetCantidad());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)(Dolar)p;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        #endregion

        #region Sobrecarga de operadores logicos

        public static bool operator ==(Pesos p, Dolar d)
        {
            return d == p;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p , Euro e)
        {
            return e == p;
        }

        public static bool operator !=( Pesos p,Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Sobrecarga de operadores algebraicos

        public static Pesos operator +( Pesos p,Euro e)
        {
            return (Pesos)(e + p);
        }
        public static Pesos operator -(Pesos p,Euro e)
        {
            return p.GetCantidad() - ((Pesos)e).GetCantidad();
        }
        public static Pesos operator +(Pesos p,Dolar d)
        {
            return (Pesos)(d + p);
        }
        public static Pesos operator -(Pesos p,Dolar d)
        {
            return p.GetCantidad() - ((Pesos)d).GetCantidad();
        }

        #endregion

    }
}
