using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private String modelo;
        private static int valorHora;


        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp(String patente, String modelo) : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(String patente, String modelo, int valorHora) : this(patente,modelo)
        {
            PickUp.valorHora = valorHora;
        }
        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(String.Format("Ingreso: {0}",base.ingreso));
            sb.AppendLine(String.Format("Modelo: {0}",this.modelo));
            sb.AppendLine(String.Format("Valor hora: {0}",PickUp.valorHora));
            return sb.ToString();
        }
        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine(String.Format("Costo estadia : {0}", ((DateTime.Now.Hour - base.ingreso.Hour )* PickUp.valorHora)));
            return sb.ToString();
        }



    }
}
