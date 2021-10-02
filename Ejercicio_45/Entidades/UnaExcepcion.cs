using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(String mensaje, Exception innerException) : base(mensaje,innerException)
        {

        }



    }
}
