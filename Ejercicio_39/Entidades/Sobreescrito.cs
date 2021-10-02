using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Sobreescrito
    {
        protected String miAtributo;
        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract String MiPropiedad 
        {
            get;
        }
        public abstract String MiMetodo();
        public override string ToString()
        {
            return this.MiPropiedad;
        }
    }
}
