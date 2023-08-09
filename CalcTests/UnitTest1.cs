using calculadora_multifuncional;

namespace CalcTests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void DeveSomarDoisNumeros()
        {
            // Arrange
            int numero1 = 2;
            int numero2 = 2;
            int resultadoEsperado = 4;

            // Act
            int resultadoSoma = Program.Somar(numero1, numero2);

            // Assert

            Assert.AreEqual(resultadoSoma, resultadoEsperado);

        }
        [TestMethod]
        public void DeveSubtrairDoisNumeros()
        {
            // Arrange

            int numero1 = 5;
            int numero2 = 2;
            int resultadoEsperado = 3;


            // Act

            int resultadoSub = Program.Subtrair(numero1, numero2);


            // Assert
            Assert.AreEqual(resultadoSub, resultadoEsperado);

        }
        [TestMethod]
        public void DeveMultiplicarDoisNumeros()
        {
            // Arrange

            int numero1 = 8;
            int numero2 = 2;
            int resultadoEsperado = 16;


            // Act

            int resultadoMult = Program.Multiplicar(numero1, numero2);

            // Assert

            Assert.AreEqual(resultadoMult, resultadoEsperado);
        }

        [TestMethod]
        public void DeveDividirDoisNumeros()
        {
            // Arrange

            int numero1 = 10;
            int numero2 = 2;
            int resultadoEsperado = 5;

            // Act

            int resultadoDiv = Program.Dividir(numero1, numero2);

            // Assert

            Assert.AreEqual(resultadoDiv, resultadoEsperado);

        }
        [TestMethod]
        public void DeveDividirPorZero()
        {
            // Arrange

            int numero1 = 3;
            int numero2 = 0;

            // Act & Assert

            Assert.ThrowsException<DivideByZeroException>(() => Program.Dividir(numero1, numero2));

        }
    }
}