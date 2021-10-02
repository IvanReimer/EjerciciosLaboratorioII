using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool estaDeMas = this + value;
            }
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool esPosibleAgregarCliente = true;
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    esPosibleAgregarCliente = false;
                    break;
                }
            }
            if (esPosibleAgregarCliente)
            {
                n.clientes.Enqueue(c);

            }
            return esPosibleAgregarCliente;
        }
        public Queue<Cliente> ClientesPendientes
        { 
            get
            {
                return this.clientes;
            }
        
        }

        public static bool operator ==(Negocio n , Cliente c)
        {
            bool clienteYaEstaEnLaCola = false;

            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    clienteYaEstaEnLaCola = true;
                    break;
                }
            }
            return clienteYaEstaEnLaCola;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
