using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
   public class Equipo
    {
        private List<Jugador> jugadores;
        private short cantidadDeJugadores;
        private string nombre;
        
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool equipoContieneJugador = false;
            bool seEncuentraJugador= false;
            if (e.jugadores.Count < e.cantidadDeJugadores )
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (j == item)
                    {
                        seEncuentraJugador = true;
                        break;
                    }
                }
                if (!seEncuentraJugador)
                {
                    e.jugadores.Add(j);
                    equipoContieneJugador = true;
                }
            }
            return equipoContieneJugador;
        }

    }
}
