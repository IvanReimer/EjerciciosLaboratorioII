using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoTxt : Archivo , IArchivos<PuntoTxt>
    {
        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            bool retorno = false;
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (ruta.EndsWith(".txt"))
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .txt");
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", e);
            }
            return retorno;
        }


    }
}
