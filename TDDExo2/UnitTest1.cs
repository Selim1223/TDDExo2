namespace TDDExo2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(10, 20, 30)]
        public void AddTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Add(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(30, 20, 10)]
        public void SubTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Sub(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(5, 2, 10)]
        public void MultiplyTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Multiply(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(15, 3, 5)]
        public void DivideTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            var calculator = new Calculator();
            Assert.AreEqual(calculator.Divide(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(15, 0, 5)]
        public void DivideTwoElementsByZero_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            var calculator = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(firstNumber,secondNumber));
        }
    }
}