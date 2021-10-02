using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadPuertas;
        short cantidadMarchas;
        int pesoCarga;
        public Automovil(short cantidadRuedas,short cantidadPuertas,Colores color,short cantidadMarchas,int pesoCarga):base(cantidadRuedas,color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }




    }
}
