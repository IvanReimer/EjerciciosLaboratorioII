using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class Lista
    {
        private List<int> numeros;

        public Lista()
        {
            this.numeros = new List<int>();
        }
        public void AgregarElemento(int elem)
        {
            this.numeros.Add(elem);
        }
        public void EliminarElemento(int elem)
        {
            this.numeros.Remove(elem);
        }
        public static void MostrarElementos(Lista l)
        {
            foreach (int item in l.numeros)
            {
                Console.WriteLine(item);
            }
        }

        public Lista OrdenarPositivosAsc(Lista l)
        {
            l = l.FiltrarMayoresA(l, 0);
            l.numeros.Sort(Lista.OrdenarDesc);
            return l;
        }

        public Lista OrdenarNegativosDesc(Lista l)
        {
            l = l.FiltrarMenoresA(l, 0);
            l.numeros.Sort(Lista.OrdenarAsc);
            return l;
        }
        public static int OrdenarAsc(int numero1, int numero2)
        {
            int retorno = 0;
            if (numero1 > numero2)
            {
                retorno = -1;
            }
            else if (numero1 < numero2)
            {
                retorno = 1;
            }
            return retorno;
        }
        public static int OrdenarDesc(int numero1, int numero2)
        {
            int retorno = 0;
            if (numero1 > numero2)
            {
                retorno = 1;
            }
            else if (numero1 < numero2)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }
            return retorno;

        }

        private Lista FiltrarMayoresA(Lista l, int numero)
        {
            Lista l1 = new Lista();
            foreach (int item in l.numeros)
            {
                if (item > numero)
                {
                    l1.AgregarElemento(item);
                }
            }
            return l1;
        }
        private Lista FiltrarMenoresA(Lista l, int numero)
        {
            Lista l1 = new Lista();
            foreach (int item in l.numeros)
            {
                if (item < numero)
                {
                    l1.AgregarElemento(item);
                }
            }
            return l1;
        }


    }
}
