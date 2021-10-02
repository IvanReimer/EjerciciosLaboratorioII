using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class Pila
    {
        private Stack<int> numeros;
        public Pila()
        {
            this.numeros = new Stack<int>();
        }

        public void AgregarElemento(int elem)
        {
            numeros.Push(elem);
        }
        public void SacarElemento()
        {
            numeros.Pop();
        }
        
        public static void MostrarElementos(Pila p)
        {
            foreach (int elemento in p.numeros)
            {
                Console.WriteLine(elemento);
            }
        }
        private static Pila FiltrarPositivos(Pila p)
        {
            Pila pAux = new Pila();
            foreach (int item in p.numeros)
            {
                if (item > 0)
                {
                    pAux.AgregarElemento(item);
                }
            }
            return pAux;
        }
        public static Pila OrdenarPositivosAsc(Pila p)
        {
            p = Pila.FiltrarPositivos(p);
            Pila pilaRetorno = new Pila();
            while(p.numeros.Count()> 0)
            {
                pilaRetorno.AgregarElemento(p.numeros.Min());
                p = Pila.SacarMinimo(p);
            }
            return pilaRetorno;
        }

        private static Pila SacarMinimo(Pila p)
        {
            Pila aux = new Pila();
            bool flag = true;
            foreach (int item in p.numeros)
            {
                if (item == p.numeros.Min() && flag)
                {
                    flag = false;
                }
                else
                {
                    aux.numeros.Push(item);
                }
            }
            return aux;
        }

        public static Pila OrdenarNegativosAsc(Pila p)
        {
            p = Pila.FiltrarNegativos(p);
            p.numeros.ToList();
            Pila pAux = new Pila();
            while (p.numeros.Count > 0)
            {
                pAux.AgregarElemento(p.numeros.Max());
                p= Pila.SacarMaximo(p);
            }
            return pAux;
        }

        private static Pila SacarMaximo(Pila p)
        {
            Pila aux = new Pila();
            bool flag = true;
            foreach (int item in p.numeros)
            {
                if (item == p.numeros.Max() && flag)
                {
                    flag = false;
                }
                else
                {
                    aux.numeros.Push(item);
                }
            }
            return aux;
        }

        private static Pila FiltrarNegativos(Pila p)
        {
            Pila pAux = new Pila();

            foreach (int elemento in p.numeros)
            {
                if (elemento < 0)
                {
                    pAux.AgregarElemento(elemento);
                }
            }
            return pAux;
        }



    }
}
