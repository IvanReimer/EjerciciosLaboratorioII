using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public String NroDestino
        {
            get
            {

                return this.nroDestino;
            }
        }
        public String NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public abstract float CostoLlamada
        { 
            get;
        }
        #endregion

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
            this.duracion = duracion;
        }
        public static int OrdenarPorDuracion(Llamada llamada1 , Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }
            return retorno;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Número de origen: {this.nroOrigen}. ");
            sb.Append($"Número de destino{this.nroDestino}. ");
            sb.Append(String.Format("Duracion: {0}. ", this.duracion));
            return sb.ToString();
        }

        #region Sobrecargas

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Equals(llamada2) && llamada1.nroDestino == llamada2.nroDestino && llamada1.nroOrigen == llamada2.nroOrigen;
        }

        #endregion
    }
}
