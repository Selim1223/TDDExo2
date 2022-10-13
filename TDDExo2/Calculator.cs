namespace TDDExo2
{
    internal class Calculator
    {
        public Calculator()
        {
        }


        public  int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public  int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public  int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

         public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                throw new CustomDivideByZeroException("ne peut pas diviser par 0.");
            return firstNumber / secondNumber;
        }

        public class CustomDivideByZeroException : Exception
        {
            public CustomDivideByZeroException(string message) : base(message) { }
        }

    }
}
