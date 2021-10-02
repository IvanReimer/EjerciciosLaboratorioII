using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Constructores

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);

            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Métodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaTotal = 0;

            foreach (Llamada elem in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (elem is Local)
                        {
                            gananciaTotal += elem.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (elem is Provincial)
                        {
                            gananciaTotal += elem.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        gananciaTotal += elem.CostoLlamada;
                        break;
                }
            }
            return gananciaTotal;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancias por llamados locales: ${this.GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamados provinciales: ${this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancias totales por llamados : ${this.GananciasPorTotal}");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
            }
            return sb.ToString();
        }
        #endregion


        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool contieneLaLlamada = false;
            foreach (Llamada elem in c.listaDeLlamadas)
            {
                if (elem == llamada)
                {
                    contieneLaLlamada = true;
                    break;
                }
            }
            return contieneLaLlamada;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
            }
            return c;
        }
    }
}
