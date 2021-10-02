using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        private List<IAcciones> utiles;

        public Cartuchera1()
        {
            this.utiles = new List<IAcciones>();
        }
        public List<IAcciones> Utiles 
        { 
            get
            {
                return this.utiles;
            }
            set
            {
                this.utiles = value;
            }
        }
        public bool ProbarElementos()
        {
            bool retorno = true;
            foreach ( IAcciones item in this.utiles)
            {
                if (item.Escribir("a") == null && item is Boligrafo)
                {
                    retorno = false;  
                    item.Recargar(10);
                }

            }
            return retorno;
        }
    }
}
