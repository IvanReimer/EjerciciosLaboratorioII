using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaExcepcion : Exception
    {
        private String nombreClase;
        private String nombreMetodo;
        public CentralitaExcepcion(String mensaje, String clase, String metodo) : this(mensaje,clase,metodo,null)
        {

        }
        public CentralitaExcepcion(String mensaje, String clase, String metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }
        public String NombreClase 
        { 
            get
            {
                return this.nombreClase;
            }
        }
        public String NombreMetodo 
        { 
            get
            {
                return this.nombreMetodo;
            }
        }


    }
}
