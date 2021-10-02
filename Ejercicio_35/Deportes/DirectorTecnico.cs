using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        private DirectorTecnico(String nombre):base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public String MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.MostrarDatos());
            datos.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento}");
            return datos.ToString();
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre != dt2.Nombre || dt1.fechaNacimiento != dt2.fechaNacimiento;
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 != dt2);
        }
    }
}
