using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private String nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(String nombre):this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> t , T equipo)
        {
            bool equipoEstaEnTorneo = false;
            foreach (T item in t.equipos)
            {
                if (item == equipo)
                {
                    equipoEstaEnTorneo = true;
                }
            }
            return equipoEstaEnTorneo;
        }
        public static bool operator !=(Torneo<T> t, T equipo)
        {
            return !(t == equipo);
        }
        public static bool operator +(Torneo<T> t, T equipo)
        {
            bool seAgregoEquipo = false;
            if (t != equipo)
            {
                t.equipos.Add(equipo);
                seAgregoEquipo = true;
            }
            return seAgregoEquipo;
        }
        public String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {this.nombre}");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private String CalcularPartido(T e1, T e2)
        {
            Random resultado = new Random();
            StringBuilder resultadoPartido = new StringBuilder();
            resultadoPartido.AppendLine($"{e1.Nombre} {resultado.Next(0,100)} - {resultado.Next(0,100)} {e2.Nombre}");
            return resultadoPartido.ToString();
        }
        public String JugarPartido
        { 
            get
            {
                Random r = new Random();
                return this.CalcularPartido(this.equipos.ElementAt(r.Next(0, this.equipos.Count-1)), this.equipos.ElementAt(r.Next(0, this.equipos.Count - 1)));
            }
        }

    }
}
