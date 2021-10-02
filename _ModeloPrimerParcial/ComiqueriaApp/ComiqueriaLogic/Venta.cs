using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        static Venta()
        {
            Venta.porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio,cantidad);
        }
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioBruto = precioUnidad * cantidad;
            return precioBruto + (precioBruto * Venta.porcentajeIva / 100);
        }
        public String ObtenerDescripcionBreve()
        {
            return String.Format("Fecha: {0} - Descripcion: {1} - Precio final: {2:0.00}.", this.fecha, this.producto.ToString(), this.precioFinal);
        }
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }


    }
}
