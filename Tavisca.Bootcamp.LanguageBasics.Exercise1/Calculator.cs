using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Calculator
    {

        public static Digit Calculate(Digit digit1, Digit digit2, Operator op)
        {
            int operand1, operand2;

            if (string.IsNullOrEmpty(digit1?.Value) || string.IsNullOrEmpty(digit1?.Value) ||
                !int.TryParse(digit1.Value, out operand1) || !int.TryParse(digit2.Value, out operand2))
                throw new Exception("Invalid digits");

            switch (op)
            {
                case Operator.Division:
                    return new Digit
                    {
                        Value = (operand1 / operand2).ToString()
                    };
                case Operator.Modulus:
                    return new Digit
                    {
                        Value = (operand1 % operand2).ToString()
                    };
                case Operator.Multiplication:
                    return new Digit
                    {
                        Value = (operand1 * operand2).ToString()
                    };
                default:
                    throw new Exception("Invalid Operation");
            }
        }

    }

}