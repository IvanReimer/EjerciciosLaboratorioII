using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        protected int capacidadML;
        protected int contenidoML;
        protected String marca;

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
            this.marca = marca;
        }
        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
        }
        public float PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * 100) / this.capacidadML;
            }
        }

        public abstract int ServirMedida();

        protected String GenerarInforme()
        {
            StringBuilder datosBotella = new StringBuilder();
            datosBotella.AppendLine(String.Format("Marca: {0}", this.marca));
            datosBotella.AppendLine(String.Format("Capacidad en mililitros: {0}",this.capacidadML));
            datosBotella.AppendLine(String.Format("Contenido en mililitros: {0}",this.contenidoML));
            datosBotella.AppendLine(String.Format("Porcentaje de contenido: {0}",this.PorcentajeContenido));
            return datosBotella.ToString();
        }
        public static implicit operator String(Botella b)
        {
            return b.GenerarInforme();
        }
        public static bool operator==(Botella b1, Botella b2)
        {
            return b1.marca == b2.marca;
        }
        public static bool operator !=(Botella b1, Botella b2)
        {
            return !(b1 == b2);
        }









    }
}
