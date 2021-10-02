using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    public class Diccionario
    {
        private Dictionary<string, int> palabras;

        public Diccionario()
        {
            this.palabras = new Dictionary<string, int>();
        }
        public void AgregarPalabra(string palabra)
        {
            if (!this.palabras.ContainsKey(palabra))
            {
                this.palabras.Add(palabra, 1);
            }
            else
            {
                this.palabras[palabra]++;
            }
        }

        public String[] ObtenerTop3PalabrasConMasApariciones(Diccionario dic)
        {
            String[] top3Palabras= new string[3];
            for (int i = 0; i < top3Palabras.Length; i++)
            {
                top3Palabras[i] = Diccionario.PalabraConMasApariciones(dic);

                dic = Diccionario.RemoverPalabraConMasApariciones(dic);
            }
            return top3Palabras;
        }
        public static string PalabraConMasApariciones(Diccionario dic)
        {
            string claveConMasApariciones = String.Empty;
            foreach (KeyValuePair<String, int> palabra in dic.palabras)
            {
                if (palabra.Value == dic.palabras.Values.Max())
                {
                    claveConMasApariciones = palabra.Key;
                    break;
                }
            }
            return claveConMasApariciones;
        }

        private static Diccionario RemoverPalabraConMasApariciones(Diccionario d)
        {
            Diccionario dAux = new Diccionario();
            bool seEncontroPalabraConMasApariciones = false;
            foreach (KeyValuePair <String,int> item in d.palabras)
            {
                if (item.Value == d.palabras.Values.Max() && !seEncontroPalabraConMasApariciones)
                {
                    seEncontroPalabraConMasApariciones = true;
                    continue;                    
                }
                dAux.palabras.Add(item.Key, item.Value);
            }
            return dAux;
        }
        
    }
}
