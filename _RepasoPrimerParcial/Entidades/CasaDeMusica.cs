using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ECasaMusica
    {
        Rock,
        Clasico,
        General
    }
    public class CasaDeMusica
    {
        private int espacioEnDeposito;
        private List<InstrumentoMusical> inventarioInstrumentos;
        private ECasaMusica tipoCasaMusica;
        String nombreCasaMusica;
        String direccion;



    }
}
