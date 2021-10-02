using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        public Producto this[Guid index]
        {
            get
            {
                Producto product = null;
                foreach (Producto p in this.productos)
                {
                    if (((Guid)p) == index)
                    {
                        product = p;
                        break;
                    }
                }
                return product;
            }
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool hayProductosConMismaDescripcion = false;
            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                {
                    hayProductosConMismaDescripcion = true;
                    break;
                }
            }
            return hayProductosConMismaDescripcion;
        }
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }
        public void Vender(Producto producto , int cantidad)
        {
            this.ventas.Add(new Venta(producto, cantidad));
        }
        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }
        public String ListarVentas()
        {
            this.ventas.Sort(Comiqueria.Ordenar);
            StringBuilder datosVentas = new StringBuilder();
            foreach (Venta venta in this.ventas)
            {
                datosVentas.AppendLine(venta.ObtenerDescripcionBreve());
            }
            return datosVentas.ToString();
        }
        private static int Ordenar(Venta v1, Venta v2)
        {
            if (v1.Fecha > v2.Fecha)
            {
                return 1;
            }
            else if(v1.Fecha < v2.Fecha)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public Dictionary<Guid, String> ListarProductos()
        {
            Dictionary<Guid, String> diccionario = new Dictionary<Guid, string>();
            foreach (Producto p in this.productos)
            {
                diccionario.Add((Guid)p, p.Descripcion);
            }
            return diccionario;
        }
    }
}
