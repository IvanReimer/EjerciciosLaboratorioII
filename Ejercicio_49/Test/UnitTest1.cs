using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompetenciaCarrera;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test01()
        {
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(1, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            Assert.IsInstanceOfType(c.Competidores, typeof(List<VehiculoDeCarrera>));
        }      
        
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test02()
        {
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(1, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.Motocross);
            AutoF1 auto = new AutoF1(1, "asd");
            bool anda = c + auto;
        }
        /*
        [TestMethod]
        public void Test03()
        {
            Competencia c = new Competencia(1, 5, Competencia.TipoCompetencia.F1);
            AutoF1 auto = new AutoF1(1, "asd");
            try
            {
                bool anda = c + auto;
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        */
        [TestMethod]
        public void Test04()
        {
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(1, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            AutoF1 auto = new AutoF1(1, "asd");
            bool agrego = c + auto;
            Assert.IsTrue(c == auto);
        }   

        [TestMethod]
        public void Test05()
        {
            Competencia<VehiculoDeCarrera> c = new Competencia<VehiculoDeCarrera>(1, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            AutoF1 auto = new AutoF1(1, "asd");
            AutoF1 auto1 = new AutoF1(2, "bcd");
            bool agrego = c + auto;
            agrego = c + auto1;
            Assert.IsTrue(c - auto);
            Assert.IsFalse( c != auto );
        }





    }
}
