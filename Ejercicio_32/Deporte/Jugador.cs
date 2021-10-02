using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        public string Nombre 
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
        public int Dni 
        { 
            get
            {
                return this.dni;
            }
            set
            {
                if (value >= 0 && value < int.MaxValue)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = -1;
                }
                
            }
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public float PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            
        }
        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados > 0)
                {
                    return (float)this.totalGoles / this.partidosJugados;
                }
                else
                {
                    return 0;
                }
                
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+this.nombre);
            sb.AppendLine("DNI: "+this.dni);
            sb.AppendLine("Partidos jugados: "+this.partidosJugados);
            sb.AppendLine("Goles converidos: "+this.totalGoles);
            sb.AppendLine("Promedio de goles: "+this.PromedioGoles);
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }

    }
}
