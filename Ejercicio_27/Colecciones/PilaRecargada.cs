using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class PilaRecargada
    {
        Stack<int> numeros;

        public PilaRecargada()
        {
            this.numeros = new Stack<int>();
        }
        public void AgregarElemento(int elem)
        {
            this.numeros.Push(elem);
        }
        public void SacarElemento()
        {
            this.numeros.Pop();
        }
        public static void MostrarElementos(PilaRecargada p)
        {
            foreach (int elemento in p.numeros)
            {
                Console.WriteLine(elemento);
            }
        }
        public static PilaRecargada OrdenarPositivosAsc(PilaRecargada p)
        {
            List<int> numeros = p.numeros.ToList();
            numeros.Sort(Lista.OrdenarDesc);
            


            return p;
        }





    }
}
