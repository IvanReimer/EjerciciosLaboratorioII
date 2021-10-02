using System;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;
        public Equipo(String nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public static bool operator ==(Equipo e1,Equipo e2)
        {
            return e1.Nombre == e2.Nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public String Ficha()
        {
            return String.Format("{0} fundado el {1}",this.Nombre,this.fechaCreacion);
        }





    }
}