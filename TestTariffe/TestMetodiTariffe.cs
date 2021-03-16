using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazoni;

namespace TestTariffe
{
    [TestClass]
    public class TestMetodiTariffe
    {
        [TestMethod]
        public void TestTariffaConveniente()
        {
            int giorno = 60;
            string risultato_aspettato = "si consiglia un mese";
            string risp = Gestione.TariffaConveniente(giorno);
            Assert.AreEqual(risultato_aspettato, risp);
        }
    }
}
