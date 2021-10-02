using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 30;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML) : base(capacidadML, contenidoML, marca)
        {
            this.tipo = Tipo.Vidrio;
        }
        public Cerveza(int capacidadML, string marca, int contenidoML, Tipo tipo):this(capacidadML, marca, contenidoML)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int servi=0;
            if (base.contenidoML >= Cerveza.MEDIDA*0.8)
            {
                servi =(int)(Cerveza.MEDIDA * 0.8);
            }
            else
            {
                servi = base.contenidoML;
            }
            base.contenidoML -= servi;
            return servi;
        }

        protected new String GenerarInforme()
        {
            StringBuilder datosBotellaDeCerveza = new StringBuilder();
            datosBotellaDeCerveza.AppendLine(base.ToString());
            datosBotellaDeCerveza.AppendLine($"Medida de cerveza: {Cerveza.MEDIDA}");
            datosBotellaDeCerveza.AppendLine($"Tipo de cerveza: {this.tipo}");
            return datosBotellaDeCerveza.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

    }
}
