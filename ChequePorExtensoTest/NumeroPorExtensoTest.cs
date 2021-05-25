using Microsoft.VisualStudio.TestTools.UnitTesting;

using ChequePorExtenso;
namespace ChequePorExtensoTest
{
    [TestClass]
    public class NumeroPorExtensoTest
    {
        [TestMethod]
        public void DeveVerificar1centavos()
        {
            double numero = 0.01;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Um centavo de real", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar5centavos()
        {
            double numero = 0.05;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Cinco centavos de real", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar25centavos()
        {
            double numero = 0.25;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Vinte e cinco centavos de real", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar2reaisE25centavos()
        {
            double numero = 2.25;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Dois reais e vinte e cinco centavos", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar7reais()
        {
            double numero = 7.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar37reais()
        {
            double numero = 37.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar637reais()
        {
            double numero = 637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar1mil637reais()
        {
            double numero = 1637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar15mil415reais16centavos()
        {
            double numero = 15415.16;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Quinze mil quatrocentos e quinze reais e dezesseis centavos", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar61mil637reais()
        {
            double numero = 61637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Sessenta e um mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar961mil637reais()
        {
            double numero = 961637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Novecentos e sessenta e um mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar1milhao852mil700reais()
        {
            double numero = 1852700.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Um milhão oitocentos e cinquenta e dois mil e setecentos reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar5milhao961mil637reais()
        {
            double numero = 5961637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar25milhao961mil637reais()
        {
            double numero = 25961637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar425milhao961mil637reais()
        {
            double numero = 425961637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }

        [TestMethod]
        public void DeveVerificar8bilhoes425milhoes961mil637reais()
        {
            double numero = 8425961637.00;

            NumeroPorExtenso numeroPorExtenso = new NumeroPorExtenso(numero);

            Assert.AreEqual("Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", numeroPorExtenso.NumeroExtenso);
        }
    }
}
