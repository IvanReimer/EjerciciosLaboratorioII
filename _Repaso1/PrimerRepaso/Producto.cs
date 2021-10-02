using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;

        private string marca;

        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public float GetPrecio()
        {
            return this.precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}",p.GetMarca());
            sb.AppendLine();
            sb.AppendFormat("Codigo de barras: {0}",(string)p);
            sb.AppendLine();
            sb.AppendFormat("Precio: {0}",p.precio);
            return sb.ToString();
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1==p2);
        }
        public static bool operator ==(Producto p,string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p,string marca)
        {
            return ! (p.marca == marca);
        }
    }
}
