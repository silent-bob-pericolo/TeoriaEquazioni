using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEquazioniPrimoGrado()
        {
            double a = 1;
            bool valoreAspettato = true;
            bool controlloValore = Equazioni.IsDetermined(a);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void TestIncosisted()
        {
            double a = 1;
            double b = 3;
            bool valoreAspettato = true;
            bool controlloValore = Equazioni.IsIncosisted(a, b);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void TestDegree2()
        {
            double a = 0;
            bool valoreAspettato = false;
            bool controlloValore = Equazioni.IsDegree2(a);
            Assert.AreEqual (valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void EquazioneDelta()
        {
            double a = 3;
            double b = 6;
            double c = 8;
            double valoreAspettato = -60;
            double controlloValore = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }



    }
}
