using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public OtraClase()
        {
            try
            {
                MiClase clase = new MiClase();
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("Mensaje error 3",e);
            }
            
        }


    }
}
