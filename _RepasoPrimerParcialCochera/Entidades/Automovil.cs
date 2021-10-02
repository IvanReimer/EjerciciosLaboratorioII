using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;
        static Automovil()
        {
            Automovil.valorHora = 50;
        }
        public Automovil(String patente, ConsoleColor color) :base(patente)
        {
            this.color = color;
        }
        public Automovil(String patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(String.Format("Patente: {0}",base.ToString()));
            datos.AppendLine(String.Format("Ingreso: {0}",base.ingreso));
            datos.AppendLine(String.Format("Color : {0}", this.color));
            datos.AppendLine(String.Format("Ruedas : {0}", Automovil.valorHora));
            return datos.ToString();
        }


        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine(String.Format("Costo estadia : {0}", ((DateTime.Now.Hour - base.ingreso.Hour )* Automovil.valorHora)));
            return sb.ToString();
        }


        public override bool Equals(object obj)
        {
            return obj is Automovil;
        }

    }
}
