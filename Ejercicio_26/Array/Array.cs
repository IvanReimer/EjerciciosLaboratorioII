using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Arreglo
    {
        private int [] myArray;

        public Arreglo(short cantidad)
        {
            myArray = new int[cantidad];
        }
        public bool CargarNumero(int numero, int posicion)
        {
            bool numeroCargado=false;
            if (posicion <= this.myArray.Length && posicion >= 1 && numero!= 0 )
            {
                this.myArray[posicion-1] = numero;
                numeroCargado = true;
            }
            return numeroCargado;
        }
        public int Lenght
        {
            get
            {
                return this.myArray.Length;
            }
        }
        public void MostrarVector()
        {
            for (int i = 0; i < this.myArray.Length; i++)
            {
                Console.WriteLine(this.myArray[i]);
            }
        }
        public int[] GetPositivosDecreciente()
        {
            Array.Sort(this.myArray);
            Array.Reverse(this.myArray);
            return Arreglo.RedimensionarArrayPositivo(this.myArray);
        }
        public int [] GetNegativosCreciente()
        {
            Array.Sort(this.myArray);
            return Arreglo.RedimensionarArrayNegativo(this.myArray);
        }

        #region Metodos auxiliares
        private static short ObtenerCantidadDePositivos(int[] array)
        {
            short k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    k++;
                }
            }
            return k;
        }
        private static short ObtenerCantidadNegativos(int[] array)
        {
            short k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    k++;
                }
            }
            return k;
        }        
        private static int[] RedimensionarArrayPositivo(int[] array)
        {
            int[] auxArray = new int[Arreglo.ObtenerCantidadDePositivos(array)];
            for (int i = 0; i < auxArray.Length; i++)
            {
                auxArray[i] = array[i];
            }
            return auxArray;
        }
        private static int[] RedimensionarArrayNegativo(int[] array)
        {
            int[] auxArray = new int[Arreglo.ObtenerCantidadNegativos(array)];
            for (int i = 0; i < auxArray.Length; i++)
            {
                auxArray[i] = array[i];
            }
            return auxArray;
        }

        #endregion



    }
}
