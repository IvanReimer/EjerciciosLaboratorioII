using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private String descripcion;
        private double precio;
        private int stock;
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        public int Stock 
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public double Precio
        { 
            get
            {
                return this.precio;
            }
        }

        public string Descripcion 
        {
            get
            {
                return this.descripcion;
            }
        }
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        public override string ToString()
        {
            StringBuilder datosProducto = new StringBuilder();
            datosProducto.AppendLine(String.Format("Descripcion {0}",this.descripcion));
            datosProducto.AppendLine(String.Format("Codigo: {0}",this.codigo));
            datosProducto.AppendLine(String.Format("Precio: ${0}",this.precio));
            datosProducto.AppendLine(String.Format("Stock: {0} unidades",this.stock));
            return datosProducto.ToString();
        }
    }
}
