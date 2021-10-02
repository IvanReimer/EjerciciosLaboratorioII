using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
        public MiClase()
        {
            try
            {
                MiClase clase = new MiClase("Mensaje error 1");
            }
            catch (StackOverflowException e)
            {
                throw new UnaExcepcion("Mensaje error 2", e);
            }

        }
        public MiClase(String a)
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw new StackOverflowException(a,e);
            }
        }



    }
}
