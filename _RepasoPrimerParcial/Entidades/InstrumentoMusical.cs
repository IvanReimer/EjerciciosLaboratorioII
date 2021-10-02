using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InstrumentoMusical
    {
        protected float precio;
        protected String descripcion;
        protected String marca;
        protected int codigo;

        public InstrumentoMusical(float precio, string descripcion, string marca, int codigo)
        {
            this.precio = precio;
            this.descripcion = descripcion;
            this.marca = marca;
            this.codigo = codigo;
        }
        public InstrumentoMusical()
        {

        }

    }
}
