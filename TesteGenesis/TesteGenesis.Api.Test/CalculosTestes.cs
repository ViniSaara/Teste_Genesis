using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteGenesis.Api.Servicos;

namespace TesteGenesis.Api.Test
{
    [TestClass]
    public class CalculosTestes
    {
        [TestMethod]
        public void CalculosTest_6_Meses()
        {
            Calculos calculos = new Calculos();
            var resultado = calculos.CalcularCdb(6, 1000);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(1059.76m, resultado.ValorBruto);
            Assert.AreEqual(1046.31m, resultado.ValorLiquido);
        }

        [TestMethod]
        public void CalculosTest_12_Meses()
        {
            Calculos calculos = new Calculos();
            var resultado = calculos.CalcularCdb(12, 1000);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(1123.08m, resultado.ValorBruto);
            Assert.AreEqual(1098.47m, resultado.ValorLiquido);
        }

        [TestMethod]
        public void CalculosTest_24_Meses()
        {
            Calculos calculos = new Calculos();
            var resultado = calculos.CalcularCdb(24, 1000);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(1261.31m, resultado.ValorBruto);
            Assert.AreEqual(1215.58m, resultado.ValorLiquido);
        }

        [TestMethod]
        public void CalculosTest_25_Meses()
        {
            Calculos calculos = new Calculos();
            var resultado = calculos.CalcularCdb(25, 1000);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(1273.57m, resultado.ValorBruto);
            Assert.AreEqual(1232.54m, resultado.ValorLiquido);
        }
    }
}