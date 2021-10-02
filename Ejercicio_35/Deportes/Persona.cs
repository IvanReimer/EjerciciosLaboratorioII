using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes
{
    public class Persona
    {
        private long dni;
        private string nombre;
        #region Propiedades
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        #endregion

        public String MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre: {this.nombre}.");
            datos.AppendLine($"DNI: {this.dni}.");
            return datos.ToString();
        }
        public Persona(long dni, string nombre) :this(nombre)
        {
            this.dni = dni;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
