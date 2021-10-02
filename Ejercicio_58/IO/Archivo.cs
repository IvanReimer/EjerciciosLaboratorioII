using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(String ruta, bool validaExistencia)
        {
            bool retorno = false;
            if (validaExistencia)
            {
                retorno = File.Exists(ruta);
            }
            else
            {
                throw new FileNotFoundException();
            }
            return retorno;
        }




    }
}
