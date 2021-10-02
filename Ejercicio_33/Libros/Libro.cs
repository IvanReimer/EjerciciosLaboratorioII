using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Libro
    {
        private List<string> paginas;
        public string this[int index]
        {
            get {
                if (this.paginas is null || index >= this.paginas.Count || index < 0)
                {
                    return String.Empty;           
                }
                else
                {
                    return this.paginas[index];
                }
            }
            set {
                if (this.paginas is null)
                {
                    this.paginas= new List<string>();
                }
                if(index < this.paginas.Count && index >= 0)
                {
                    this.paginas[index] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
