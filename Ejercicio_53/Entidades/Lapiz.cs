using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioTinta;
        public Lapiz(int unidades)
        {
            this.tamanioTinta = unidades;
        }

        float IAcciones.UnidadesDeEscritura 
        {
            get
            {
                return this.tamanioTinta;
            }
            set
            {
                this.tamanioTinta = value;
            }
        }
        ConsoleColor IAcciones.Color 
        { 
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }

        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper retorno = null;
            if ( ( texto.Length * 0.1) <= this.tamanioTinta)
            {
                this.tamanioTinta -= (float)(texto.Length * 0.1);
                retorno = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }
            return retorno;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return String.Format("Es un {0} de color {1} y su nivel de tinta es {2}", typeof(Lapiz), ((IAcciones)this).Color, this.tamanioTinta);
        }
    }
}
