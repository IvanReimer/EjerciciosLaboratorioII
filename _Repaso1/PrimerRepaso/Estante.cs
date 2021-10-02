using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion -1;
        }
        public Producto [] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in e.productos)
            {
                if (!(p is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(p));
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            return e.productos.Contains(p);
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p) ;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool flag = false;
            if (e != p)
            {
                //for(int i = 0; i < e.GetProductos().Length; i++)
                //{
                //    if(e.productos[i] is null)
                //    {
                //        e.productos[i] = p;
                //        flag = true;
                //        break;
                //    }
                //}
                int i = 0;
                while ( i < e.productos.Length && !(e.productos[i] is null) )
                {
                    i++;
                }
                if (i < e.productos.Length)
                {
                    e.productos[i] = p;
                    flag = true;
                }

            }
            return flag;
        }
        public static Estante operator -(Estante e , Producto p)
        {
            if (e == p)
            {
                int i = 0;
                while (e.productos[i] != p)
                {
                    i++;
                }
                for (int j = i; j < e.productos.Length -1; j++)
                {
                    e.productos[j] = e.productos[j + 1];
                }
                e.ubicacionEstante--;
            }
            return e;
        }

    }
}
