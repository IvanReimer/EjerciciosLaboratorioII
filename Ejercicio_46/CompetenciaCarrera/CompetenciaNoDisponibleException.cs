using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaCarrera
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private String nombreClase;
        private String nombreMetodo;
        public String NombreMetodo 
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        public String NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public CompetenciaNoDisponibleException(String mensaje, String clase, String metodo):this(mensaje,clase,metodo,null)
        {
            
        }
        public CompetenciaNoDisponibleException(String mensaje, String clase, String metodo, Exception innerException):base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(String.Format("Excepcion del metodo {0} de la clase {1}",this.nombreMetodo,this.nombreClase));
            datos.AppendLine(this.Message);
            Exception e = this.InnerException;
            while(e != null)
            {
                datos.Append(String.Format("{0}\t",e));
                e = e.InnerException;
            }
            return datos.ToString();
        }



    }
}
