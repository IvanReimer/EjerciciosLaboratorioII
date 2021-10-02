using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private String patente;

        public string Patente 
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }
        public Vehiculo(String patente)
        {
            this.patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        public abstract String ConsultarDatos();

        public override string ToString()
        {
            return String.Format("Patente: {0}", this.patente);
        }


        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(this.ToString());
            datos.AppendLine(String.Format("Ingreso: {0}",this.ingreso));
            return datos.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente && v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }



    }
}
