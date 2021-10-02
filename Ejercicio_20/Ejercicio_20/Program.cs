using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;
namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Test Dolar

            //Dolar dolar = 1;
            //Pesos peso = (Pesos)dolar;
            //Console.WriteLine(peso.GetCantidad());

            //Dolar dolar = 1.16;
            //Euro euro = (Euro)dolar;
            //Console.WriteLine(euro.GetCantidad());
            #endregion

            #region Test Euro

            #region Euro a dolar
            //Euro euro = 1;
            //Dolar dolar = (Dolar)euro;
            //Console.WriteLine(dolar.GetCantidad());
            #endregion

            #region Euro a Peso (ANDA)

            //Euro e = 1;
            //Pesos p = (Pesos) e;
            //Console.WriteLine(p.GetCantidad());
            #endregion

            #endregion

            #region Test Peso 
            #region Peso a dolar (ANDA)
            //Pesos peso = 38.33;
            //Dolar dolar = (Dolar)peso;
            //Console.WriteLine(dolar.GetCantidad());
            #endregion
            #region Peso a Euro (ANDA)
            //Pesos p = 44.4628;
            //Euro e = (Euro)p;
            //Console.WriteLine(e.GetCantidad());

            #endregion
            #endregion

            Pesos peso = 1;

            Dolar dolar = 1;

            Euro euro = 1;

            Console.WriteLine( (peso + euro).GetCantidad() );

            Console.ReadKey();

        }
    }
}
