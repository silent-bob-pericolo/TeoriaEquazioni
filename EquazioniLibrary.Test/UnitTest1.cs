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
        [TestMethod]
        public void Rsoluzione()
        {
            double a = 12;
            double b = 12;
            double c = 3;
            double risultato = -1.0 / 2;
            string valoreAspettato = ($"una sola soluzione che è{risultato}");
            string controlloValore = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void Risoluzione2()
        {
            double a = 1;
            double b = 5;
            double c = 6;
            string valoreAspettato = ($"due soluzione che sono {-2} e {-3}");
            string controlloValore = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void Risoluzione3()
        {
            double a = 0;
            double b = 5;
            double c = 6;
            string valoreAspettato = "non eseguibile";
            string controlloValore = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void Risoluzione4()
        {
            double a = 2;
            double b = 0;
            double c = 2;
            string valoreAspettato =$"nessuna soluzione perchè è impossibile" ;
            string controlloValore = Equazioni.RisoluzioneEquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(valoreAspettato, controlloValore);
        }
        [TestMethod]
        public void testEquazionePrimoGrado()
        {
            double a = 0;
            double b = 2;
            string valoreAspettato = ("l'equazione è impossibile");
            string controllo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, controllo);
        }
        [TestMethod]
        public void testEquazionePrimoGrado2()
        {
            double a = -2;
            double b = 4;
            string valoreAspettato = ("la soluzione è -2");
            string controllo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, controllo);
        }
        [TestMethod]
        public void testEquazionePrimoGrado3()
        {
            double a = 0;
            double b = 0;
            string valoreAspettato = ("l'equazione è indeterminata");
            string controllo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, controllo);
        }






    }
}
