using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local> 
    {
        protected float costo;
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }
        public Local(String origen, float duracion, String destino, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        protected override String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append($"Costo llamada: {this.costo}. ");
            sb.Append($"Costo: {this.CostoLlamada}. ");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        

        public override bool Equals(object obj)
        {
            return typeof(Local) == obj.GetType();
            //return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }

        public string RutaDeArchivo { get; set; }
    }
}
