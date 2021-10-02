using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;
namespace CentralitaTest
{
    [TestClass]
    public class TestCentralita
    {
        [TestMethod]
        public void Test01()
        {
            Centralita central = new Centralita();
            Assert.IsNotNull(central.Llamadas);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void Test02()
        {
            Centralita central = new Centralita();
            Local llamada1 = new Local("1", 10, "2", 5);
            Local llamada2 = new Local("1", 15, "2", 2);

            central += llamada1;

            central += llamada2;
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaExcepcion))]
        public void Test03()
        {
            Centralita central = new Centralita();
            Provincial llamada1 = new Provincial("1", Provincial.Franja.Franja_1, 12, "2");
            Provincial llamada2 = new Provincial("1", Provincial.Franja.Franja_2, 10, "2");
            central += llamada1;
            central += llamada2;
        }

        [TestMethod]
        public void Test04()
        {
            Centralita central = new Centralita();
            Local llamadaLocal1 = new Local("1", 10, "2", 5);
            Local llamadaLocal2 = new Local("1", 15, "2", 2);
            Provincial llamadaProvincial1 = new Provincial("1", Provincial.Franja.Franja_1, 12, "2");
            Provincial llamadaProvincial2 = new Provincial("1", Provincial.Franja.Franja_1, 12, "2");
            Assert.IsTrue(llamadaLocal1==llamadaLocal2);
            Assert.IsTrue(llamadaProvincial1==llamadaProvincial2);
            Assert.IsFalse(llamadaLocal1== llamadaProvincial1);
            Assert.IsFalse(llamadaLocal2== llamadaProvincial2);        
        }

    }
}
