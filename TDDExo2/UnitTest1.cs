namespace TDDExo2
{
    [TestClass]
     public class UnitTest1
    {
        private Calculator _calculator;

        public UnitTest1()
        {
            _calculator = new Calculator();
        }


        [TestMethod]
        [DataRow(10, 20, 30)]
        public void AddTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Add(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(30, 20, 10)]
        public void SubTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Sub(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(5, 2, 10)]
        public void MultiplyTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Multiply(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(15, 3, 5)]
        public void DivideTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Divide(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(15, 0)]
        public void DivideTwoElementsByZero_ShouldThrowException(int firstNumber, int secondNumber)
        {
            Assert.ThrowsException<CustomDivideByZeroException>(() => _calculator.Divide(firstNumber,secondNumber));
        }
    }
}
