using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA=400;
        public Agua(int capacidadML, string marca, int contenidoML) : base(capacidadML, contenidoML, marca)
        {

        }
        public int ServirMedida(int medida)
        {
            int servi = 0;
            if (medida <= base.contenidoML)
            {
                servi = Agua.MEDIDA;
            }
            else
            {
                servi = base.contenidoML;
            }
            base.contenidoML -= servi;
            return servi;
        }
        public override int ServirMedida()
        {

            return this.ServirMedida(Agua.MEDIDA);
        }


        protected new String GenerarInforme()
        {
            StringBuilder datosBotellaDeAgua = new StringBuilder();
            datosBotellaDeAgua.AppendLine(base.ToString());
            datosBotellaDeAgua.AppendLine($"Medida de agua: {Agua.MEDIDA}");
            return datosBotellaDeAgua.ToString();
        }

        
    }
}
