using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }
    public class Camion : VehiculoTerrestre
    {
        short cantidadMarchas;
        int pesoCarga;
        public Camion(short cantidadRuedas,Colores color,short cantidadMarchas,int pesoCarga) : base(cantidadRuedas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }


    }
}
