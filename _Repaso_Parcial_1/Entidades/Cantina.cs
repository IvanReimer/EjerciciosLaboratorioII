using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        public Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        public static bool operator +(Cantina c, Botella b)
        {
            bool sePudoAgregarBotella=false;
            if (c.espaciosTotales > c.botellas.Count )
            {
                c.botellas.Add(b);
                sePudoAgregarBotella = true;
            }
            return sePudoAgregarBotella;
        }
        public static bool operator ==(Cantina c, Botella b)
        {
            bool hay2BotellasIguales = false;
            foreach (Botella botella in c.botellas)
            {
                if (botella == b)
                {
                    hay2BotellasIguales = true;
                    break;
                }
            }
            return hay2BotellasIguales;
        }

        public static bool operator !=(Cantina c, Botella b)
        {
            return !(c == b);
        }




    }
    







}
