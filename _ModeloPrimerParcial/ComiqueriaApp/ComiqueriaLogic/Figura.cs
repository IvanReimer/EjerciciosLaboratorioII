using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;
        public Figura(int stock, double precio, double altura) : this(String.Format("Figura {0} cm",altura), stock, precio, altura)
        {
        }
        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion,stock,precio)
        {
            this.altura = altura;
        }
        public override string ToString()
        {
            StringBuilder datosFigura = new StringBuilder();
            datosFigura.Append(base.ToString());
            datosFigura.AppendLine($"Altura: {this.altura}");
            return datosFigura.ToString();
        }
    }
}
