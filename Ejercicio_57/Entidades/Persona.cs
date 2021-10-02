using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private String nombre;
        private String apellido;
        public Persona(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static bool Guardar(Persona p)
        {
            bool pudoSerializar = true;
            Stream fs = new FileStream("serializacion.txt",FileMode.Create);
            BinaryFormatter serializador = new BinaryFormatter();
            try
            {
                serializador.Serialize(fs, p);
            }
            catch (Exception)
            {
                pudoSerializar = false;
            }
            finally
            {
                fs.Close();
            }
            return pudoSerializar;
        }
        public static Persona Leer()
        {
            Persona p;
            Stream lector = new FileStream("serializacion.txt", FileMode.Open);
            BinaryFormatter serializador = new BinaryFormatter();
            try
            {
                p = (Persona)serializador.Deserialize(lector);
            }
            catch (Exception)
            {
                p = null;
            }
            finally
            {
                lector.Close();
            }
            return p;
        }
        public override string ToString()
        {
            StringBuilder datosPersona = new StringBuilder();
            datosPersona.Append($"Nombre: {this.nombre}. Apellido: {this.apellido}");
            return datosPersona.ToString();
        }
    }
}
