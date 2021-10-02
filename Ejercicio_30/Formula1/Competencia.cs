using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    public class Competencia
    {
        private List<AutoF1> competidores;
        private short cantidadVueltas;
        private short cantidadCompetidores;
        private Competencia()
        {
            competidores = new List<AutoF1>;
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public string MostarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad Vueltas : {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad Competidores : {this.cantidadCompetidores}");
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c,AutoF1 a)
        {
            bool hayAuto=false;
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    hayAuto = true;
                    a.SetEstaEnCompetencia(true);
                    break;
                }
            }
            return hayAuto;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c==a);
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool flag = false;
            if (c != a)
            {
                c.competidores.Add(a);
                flag = true;
            }
            return flag;
        }
    }
}
