using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazoni;

namespace TestTariffe
{
    [TestClass]
    public class TestMetodiTariffe
    {
        [DataTestMethod]
        [DataRow(60, "si consiglia un mese")]
        [DataRow(170, "si consiglia 3 mesi")]
        [DataRow(360, "si consiglia 12 mesi")]
        public void TestTariffaConveniente(int giorno, string risultato_aspettato)
        {
            string risp = Gestione.TariffaConveniente(giorno);
            Assert.AreEqual(risultato_aspettato, risp);
        }
    }
}
