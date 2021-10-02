using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(String path,String info)
        {
            bool seGuardoElArchivo = true;
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(path, true);
                sw.Write(info);
                sw.Close();
            }
            catch (IOException)
            {

                seGuardoElArchivo = false;
            }
            catch(SecurityException)
            {
                seGuardoElArchivo = false;
            }
            catch(Exception)
            {
                seGuardoElArchivo = false;
            }
            return seGuardoElArchivo;
        }
        public static String Leer(String path)
        {
            String lecturaDeArchivo = String.Empty;
            StreamReader sr;
            if (File.Exists(path))
            {
                sr = new StreamReader(path);
                lecturaDeArchivo = sr.ReadToEnd();
                sr.Close();
            }
            else
            {
                throw new FileNotFoundException("No existe la ruta del archivo especificado");
            }
            return lecturaDeArchivo;
        }




    }
}
