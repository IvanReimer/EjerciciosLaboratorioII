using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }
        public ConsoleColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper retorno = null;
            if (texto.Length * 0.3 <= this.tinta)
            {
                this.tinta -= (float)(texto.Length * 0.3);
                retorno = new EscrituraWrapper(texto, this.colorTinta);
            }
            return retorno;
        }
        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }
        public override string ToString()
        {
            return String.Format("Es un {0} de color {1} y su nivel de tinta es {2}", typeof(Boligrafo),this.colorTinta,this.tinta);
        }
    }
}
