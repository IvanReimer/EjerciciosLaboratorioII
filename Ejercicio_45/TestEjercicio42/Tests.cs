using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Reflection;
namespace TestEjercicio42
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [ExpectedException (typeof(DivideByZeroException))]
        public void Test01()
        {
            MiClase.MetodoEstatico();
        }
        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void Test02()
        {
            MiClase clase = new MiClase("Mensaje de error");

        }
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test03()
        {
            MiClase clase = new MiClase();
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Test04()
        {
            OtraClase clase = new OtraClase();
        }




    }
}
