using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(String mensaje,Exception innerException) : base(mensaje,innerException)
        {

        }
        public ArchivoIncorrectoException(String mensaje):this(mensaje,null)
        {

        }


    }
}
