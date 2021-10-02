using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }
        public String Nombre
        { 
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != String.Empty)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "Jhon Doe";
                }
            }
        }
        public int Numero 
        { 
            get
            {
                return this.numero;
            }
                
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return c1.numero != c2.numero;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return !(c1 != c2);
        }

    }
}
