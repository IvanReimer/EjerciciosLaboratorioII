using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada , IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;


        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {

        }
        public Provincial(String origen,Franja miFranja, float duracion, String destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        protected override String Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append($"Franja Horaria: {this.franjaHoraria}. ");
            sb.Append($"Costo total: {this.CostoLlamada}. ");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float costoTotal = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoTotal = (float)(base.duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    costoTotal = (float)(base.duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    costoTotal = (float)(base.duracion * 0.66);
                    break;
            }
            return costoTotal;
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
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
        public string RutaDeArchivo { get; set; }
    }
}
