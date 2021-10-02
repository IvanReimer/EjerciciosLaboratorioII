using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float perimetro;
        private float area;
        
        public Rectangulo(Punto punto1, Punto punto3)
        {
            this.vertice1 = punto1;
            this.vertice3 = punto3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }
        public float Perimetro()
        {
            bool flag = true;
            if (flag)
            {
                this.perimetro = Math.Abs((this.vertice1.GetX() - this.vertice4.GetX()) * 2) + Math.Abs((this.vertice1.GetY() - this.vertice2.GetY()) * 2);
                flag = false;
            }
            return this.perimetro;
        }
        public float Area()
        {
            bool flag = true;
            if (flag)
            {
                this.area = Math.Abs(this.vertice1.GetX() - this.vertice4.GetX()) * Math.Abs(this.vertice1.GetY() - this.vertice2.GetY());
                flag = false;
            }
            return this.area;
        }
        public static string MostrarRectangulo(Rectangulo rect)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(String.Format("Punto 1: ({0};{1})", rect.vertice1.GetX(), rect.vertice1.GetY()));
            retorno.AppendLine(String.Format("Punto 2: ({0};{1})", rect.vertice2.GetX(), rect.vertice2.GetY()));
            retorno.AppendLine(String.Format("Punto 3: ({0};{1})", rect.vertice3.GetX(), rect.vertice3.GetY()));
            retorno.AppendLine(String.Format("Punto 4: ({0};{1})", rect.vertice4.GetX(), rect.vertice4.GetY()));
            retorno.AppendLine(String.Format("Area : {0}",rect.Area()));
            retorno.AppendLine(String.Format("Perímetro : {0}", rect.Perimetro()));
            return retorno.ToString();
        }

    }
}
