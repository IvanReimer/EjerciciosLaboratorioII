using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Edificio
    {
        private Cantina[] cantinas;
        private const short LIMITECANTINAS=2;
        private static Edificio singleton;

        private Edificio()
        {
            this.cantinas = new Cantina[Edificio.LIMITECANTINAS];
        }
        static Edificio()
        {
            Edificio.singleton = new Edificio();
        }
        public static Edificio GetBar()
        {
            return Edificio.singleton;
        }
        public static bool operator +(Edificio e,Cantina c)
        {
            bool hayLugares = false;
            for (int i = 0; i < e.cantinas.Length; i++ )
            {
                if (e.cantinas[i] is null)
                {
                    hayLugares = true;
                    e.cantinas[i] = c;
                    break;
                }
            }
            return hayLugares;
        }


    }
}
