using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;
        
        public void Estudiar(byte notaUno, byte NotaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = NotaDos;
        }
        public string Mostrar()
        {
            string mostrarNotaFinal;
            this.CalcularFinal();
            if (this.notaFinal == -1)
            {
                mostrarNotaFinal = "Alumno desaprobado";
            }
            else
            {
                mostrarNotaFinal = this.notaFinal.ToString();
            }
            return "Nombre: " + this.nombre + "\nApellido: "+this.apellido + "\nLegajo: " + this.legajo + "\nNota1: " + this.nota1 +"\nNota2: "+this.nota2+"\nNota final: " +mostrarNotaFinal;
        }

        public void CalcularFinal()
        {
            Random nota = new Random();
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = nota.Next(1,10); 
            }
            else
            {
                this.notaFinal = -1;
            }
        }

    }
}
