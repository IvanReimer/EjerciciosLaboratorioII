using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InstrumientoDeCuerda : InstrumentoMusical
    {
        public InstrumientoDeCuerda(float precio, string descripcion, string marca, int codigo) : base(precio, descripcion, marca, codigo)
        {
        }
    }
}
