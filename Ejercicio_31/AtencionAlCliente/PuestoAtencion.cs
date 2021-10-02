using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public enum Puesto
    {
        Caja1, Caja2
    }
    public class PuestoAtencion
    {
        
        private static int numeroActual;
        private Puesto puesto;
        
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(1000);
            return true;
        }
        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual += 1;
                return PuestoAtencion.numeroActual;
            }

        }

    }
}
