namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Parser
    {
        public static Equation Parse(string equation)
        {
                string[] equationParts = equation.Split('*', '=');
                return new Equation
                {
                    LeftOperand = new Digit
                    {
                        Value = equationParts[0]
                    },
                    RightOperand = new Digit
                    {
                        Value = equationParts[1]
                    },
                    Result = new Digit
                    {
                        Value = equationParts[2]
                    }
                };
        }
    }

}