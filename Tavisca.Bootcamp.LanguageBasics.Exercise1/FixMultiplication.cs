namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    public class FixMultiplication
    {
        public static int FindDigit(string givenEquation)
        {
            Equation equation = Parser.Parse(givenEquation);
            if (!equation.LeftOperand.IsValid())
            {
                if (!Calculator.Calculate(equation.Result, equation.RightOperand, Operator.Modulus).IsZero())
                    return -1;
                Digit actualDigit = Calculator.Calculate(equation.Result, equation.RightOperand, Operator.Division);
                return CompareDigits(equation.LeftOperand, actualDigit);
            }
            else if (!equation.RightOperand.IsValid())
            {
                if (!Calculator.Calculate(equation.Result, equation.LeftOperand, Operator.Modulus).IsZero())
                    return -1;
                Digit actualDigit = Calculator.Calculate(equation.Result, equation.LeftOperand, Operator.Division);
                return CompareDigits(equation.RightOperand, actualDigit);
            }
            else
            {
                Digit actualDigit = Calculator.Calculate(equation.LeftOperand, equation.RightOperand, Operator.Multiplication);
                return CompareDigits(equation.Result, actualDigit);
            }
        }
        private static int CompareDigits(Digit flaggedDigit, Digit actualDigit)
        {
            if(flaggedDigit.Value.Length != actualDigit.Value.Length)
            {
                return -1;
            }
            bool areDigitEqual = true;
            int result = -1;

            for(int index = 0; index < flaggedDigit.Value.Length; index++) 
            {
                if (flaggedDigit.Value[index] == '?')
                    result = actualDigit.Value[index]-48;
                else if (flaggedDigit.Value[index] != actualDigit.Value[index])
                    areDigitEqual = false;

            }

            if (areDigitEqual)
                return result;
            return -1;
        }
    }

}