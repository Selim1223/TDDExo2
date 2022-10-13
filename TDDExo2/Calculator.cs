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

        public  int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException();
            return firstNumber / secondNumber;
        }

    }
}