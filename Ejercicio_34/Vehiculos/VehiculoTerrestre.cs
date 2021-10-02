using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected Colores color;

        public VehiculoTerrestre(short cantidadRuedas, Colores color)
        {
            this.color = color;
            this.cantidadRuedas = cantidadRuedas;
        }


    }
}
