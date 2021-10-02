using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : VehiculoTerrestre
    {
        
        short cantidadPuertas;
        
        short cilindrada;
        public Moto(short cantidadRuedas,short cantidadPuertas,Colores color,short cilindrada) : base(cantidadRuedas,color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cilindrada = cilindrada;
        }


    }
}
