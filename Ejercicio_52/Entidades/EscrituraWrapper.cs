using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public String texto;
        public EscrituraWrapper (String texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }


    }
}
