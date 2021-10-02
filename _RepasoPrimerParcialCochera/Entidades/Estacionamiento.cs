using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private String nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento (String nombre, int espacioDisponible) :this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }
        public static explicit operator String(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Vehiculo vehiculo in e.vehiculos)
            {
                sb.AppendLine(vehiculo.ConsultarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento e , Vehiculo v)
        {
            bool vehiculoEstaEnEstacionamiento = false;
            foreach (Vehiculo vehiculo in e.vehiculos)
            {
                if (vehiculo == v)
                {
                    vehiculoEstaEnEstacionamiento = true;
                    break;
                }
            }
            return vehiculoEstaEnEstacionamiento;
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }
        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != v && !(v.Patente is null) && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }
        public static String operator -(Estacionamiento e, Vehiculo v)
        {
            if (e == v)
            {
                e.vehiculos.Remove(v);
            }
            return v.ImprimirTicket();
        }

    }
}
