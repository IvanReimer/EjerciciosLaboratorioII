using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        private String autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) :base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        public override string ToString()
        {
            StringBuilder datosComic = new StringBuilder();
            datosComic.Append(base.ToString());
            datosComic.AppendLine($"Autor: {this.autor}");
            datosComic.AppendLine($"Tipo de comic: {this.tipoComic}");
            return datosComic.ToString();
        }
    }
}
