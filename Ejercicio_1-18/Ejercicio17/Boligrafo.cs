using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles
{
    class Boligrafo
    {
        const short cantidadMaximaTinta=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.SetTinta(tinta);
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            this.tinta.CompareTo(Boligrafo.cantidadMaximaTinta);

            if (this.tinta >= Boligrafo.cantidadMaximaTinta)
            {
                this.tinta = Boligrafo.cantidadMaximaTinta;
            }

            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
        }
        public void Recargar()
        {
            this.tinta = Boligrafo.cantidadMaximaTinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            
            StringBuilder retorno = new StringBuilder();
            dibujo = retorno.ToString();
            int gastoTotal = gasto;
            for (int i = 0; i < Math.Min(gasto,this.tinta); i++)
            {
                retorno.Append("*");
            }
            dibujo = retorno.ToString();
            this.SetTinta(Convert.ToInt16(gastoTotal * -1));
            Console.ForegroundColor = this.color;
            return this.tinta > 0;
        }

    }
}
