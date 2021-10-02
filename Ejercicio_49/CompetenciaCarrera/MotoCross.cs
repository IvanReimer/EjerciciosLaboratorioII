using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaCarrera
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Atributos

        private short cilindrada;

        #endregion

        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }


        #endregion

        #region Metodos

        public String MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Cilindrada: {this.cilindrada}");
            return datos.ToString();
        }


        #endregion

        #region Constructores

        public MotoCross(short numero, string escuderia) : base(numero,escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada) :this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        #endregion

        #region Sobrecargas

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.cilindrada == a2.cilindrada;
        }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return !(a1== a2);
        }
        #endregion
    }
}
