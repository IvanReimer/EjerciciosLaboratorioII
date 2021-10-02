using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        private List<Boligrafo> boligrafos;
        private List<Lapiz> lapices;
        public Cartuchera2()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }
        public List<Lapiz> Lapices 
        {
            get
            {
                return this.lapices;
            }
        }
        public List<Boligrafo> Boligrafos
        {
            get
            {
                return this.boligrafos;
            }
        }


        public bool ProbarElementos()
        {
            bool retorno = true;
            foreach (Lapiz item in this.lapices)
            {
                ((IAcciones)item).Escribir("A");
            }
            foreach (Boligrafo item in this.boligrafos)
            {
                if (item.Escribir("a") == null && item is Boligrafo)
                {
                    retorno = false;
                }
                if (item.UnidadesDeEscritura == 0)
                {
                    item.Recargar(10);
                }
            }
            return retorno;
        }

    }
}
