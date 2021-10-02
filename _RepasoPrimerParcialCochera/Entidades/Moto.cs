using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;
        static Moto()
        {
            Moto.valorHora = 30;
        }
        public Moto(String patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(String patente, int cilindrada, short ruedas) : this(patente,cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(String patente, int cilindrada, short ruedas, int valorHora) : this(patente,cilindrada,ruedas)
        {
            Moto.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.ToString());
            datos.AppendLine(String.Format("Hora ingreso: {0}",base.ingreso));
            datos.AppendLine(String.Format("Cilindrada : {0}",this.cilindrada));
            datos.AppendLine(String.Format("Ruedas : {0}",this.ruedas));
            datos.AppendLine(String.Format("Valor Hora : {0}",Moto.valorHora));
            return datos.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine(String.Format("Costo de estadía: {0}",(Moto.valorHora* (DateTime.Now.Hour - base.ingreso.Hour))));
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Moto;
        }



    }
}
