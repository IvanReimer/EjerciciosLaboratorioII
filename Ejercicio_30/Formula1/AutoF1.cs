using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class AutoF1
    {

        #region Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        #endregion

        #region Setters
        public void SetCantidadDeCombustible(short cantidad)
        {
            this.cantidadCombustible = cantidad;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }
        public void SetEstaEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }


        #endregion

        #region Getters
        public short GetCantidadDeCombustible()
        {
            return this.cantidadCombustible;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }


        #endregion

        #region Sobrecargas
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Datos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero: " + this.numero);
            sb.AppendLine(String.Format("Esta en competencia?: {0}", this.enCompetencia));
            sb.AppendLine($"Escuderia : {this.escuderia}");
            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine("Vueltas restantes : " + this.vueltasRestantes);
            return sb.ToString();
        }

        #endregion

    }
}
