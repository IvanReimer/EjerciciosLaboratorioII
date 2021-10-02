using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<String>
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        private String path;
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


        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        #endregion
        
        #region Sobrecargas

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
                if (!c.Guardar())
                {
                    throw new FallaLogException("No se pudo guardar la llamada");
                }
            }
            else
            {
                throw new CentralitaExcepcion("Llamada ya cargada en el sistema", "Centralita", "Operaador +");
            }
            return c;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }



        #endregion

        public bool Guardar()
        {
            bool sePudoGuardar = true;
            try
            {
                StreamWriter sw = new StreamWriter(this.path, true);
                sw.Write(DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm") + "hs - Se realizo una llamada\n");
                sw.Close();
            }
            catch (Exception)
            {
                sePudoGuardar = false;
            }
            return sePudoGuardar;
        }

        public string Leer()
        {
            String lecturaTotalArchivo = String.Empty;
            try
            {
                StreamReader lectorDeArchivo = new StreamReader(this.path);
                lecturaTotalArchivo = lectorDeArchivo.ReadToEnd();
                lectorDeArchivo.Close();

            }
            catch (Exception)
            {
                lecturaTotalArchivo = "Falla al leer el archivo";
            }
            return lecturaTotalArchivo;
        }
        public string RutaDeArchivo 
        { 
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }
    }

}
