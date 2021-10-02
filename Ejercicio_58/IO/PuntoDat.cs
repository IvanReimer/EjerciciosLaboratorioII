using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private String contenido;
        public String Contenido 
        { 
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        protected override bool ValidarArchivo(String ruta, bool validaExistencia)
        {
            bool retorno = false;
            try
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (ruta.EndsWith(".dat"))
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .dat");
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
