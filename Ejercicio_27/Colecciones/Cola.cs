using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
   public class Cola
    {
        private Queue<int> numeros;

        public Cola()
        {
            this.numeros = new Queue<int>();
        }

        public void AgregarElemento(int numero)
        {
            this.numeros.Enqueue(numero);
        }
        public void EliminarElemento()
        {
            this.numeros.Dequeue();
        }
        public static void MostrarElementos(Cola c)
        {
            foreach (int elemento in c.numeros)
            {
                Console.WriteLine(elemento);
            }
        }
        public Cola OrdenarPositivosDesc(Cola c)
        {
            c = c.FiltrarPositivos(c);
            Cola cAux = new Cola();
            while (c.numeros.Count > 0)
            {
                cAux.AgregarElemento(c.numeros.Max());
                c.EliminarElemento(c.numeros.Max());
            }
            c = cAux;
            return c;
        }
        public Cola OrdenarNegativosDesc(Cola c)
        {
            c = c.FiltrarNegativos(c);
            Cola cAux = new Cola();
            while (c.numeros.Count> 0)
            {
                cAux.AgregarElemento(c.numeros.Min());
                c.EliminarElemento(c.numeros.Min());
            }
            c = cAux;
            return c;
        }
        public Cola FiltrarPositivos(Cola c)
        {
            Cola cAux = new Cola();
            foreach (int elemento in c.numeros)
            {
                if (elemento > 0)
                {
                    cAux.AgregarElemento(elemento);
                }
            }
            return cAux;
        }
        public Cola FiltrarNegativos(Cola c)
        {
            Cola cAux = new Cola();
            foreach (int elemento in c.numeros)
            {
                if (elemento < 0)
                {
                    cAux.AgregarElemento(elemento);
                }
            }
            return cAux;
        }
        public void EliminarElemento(int elem)
        {
            Cola cAux = new Cola();
            bool todaviaNoSeElimino = true;
            foreach (int item in this.numeros)
            {
                if (item == elem && todaviaNoSeElimino)
                {
                    todaviaNoSeElimino = false;
                    continue;
                }
                cAux.AgregarElemento(item);
            }
            this.numeros = cAux.numeros;
        }
    }
}
