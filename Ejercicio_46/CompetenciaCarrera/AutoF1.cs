using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaCarrera
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos
        private short caballosDeFuerza;
        #endregion

        #region Constructores
        public AutoF1(short numero, String escuderia, short caballosFuerza) :this(numero,escuderia)
        {
            this.caballosDeFuerza = caballosFuerza;

        }
        public AutoF1(short numero, String escuderia):base(numero,escuderia)
        {

        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.caballosDeFuerza == a2.caballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Datos
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            return datos.ToString();
        }

        #endregion

    }
}
