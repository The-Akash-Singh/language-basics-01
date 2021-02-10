using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
            int index = 0, calculation = 0;
            string finddigit = "";

            int[] integerNumbersArray = new int[3];

            string[] stringNumbersArray = equation.Split(new Char[] { '*', '=' });

            foreach (string number in stringNumbersArray)
            {
                if (string.IsNullOrWhiteSpace(number) && number.Length > 4)
                {
                    return -1;
                }
                bool numberConvertSuccessfullyOrNot = int.TryParse(number, out integerNumbersArray[index++]);
            }

            if (integerNumbersArray[0] == 0)
            {
                if (integerNumbersArray[2] % integerNumbersArray[1] != 0) return -1;

                calculation = integerNumbersArray[2] / integerNumbersArray[1];
                finddigit = stringNumbersArray[0];
            }
            else if (integerNumbersArray[1] == 0)
            {
                if (integerNumbersArray[2] % integerNumbersArray[0] != 0) return -1;

                calculation = integerNumbersArray[2] / integerNumbersArray[0];
                finddigit = stringNumbersArray[1];
            }
            else
            {
                calculation = integerNumbersArray[0] * integerNumbersArray[1];
                finddigit = stringNumbersArray[2];
            }

            string matchFindDigitValue = Convert.ToString(calculation);

            if (matchFindDigitValue.Length != finddigit.Length)
            {
                return -1;
            }

            for (int i = 0; i < finddigit.Length; i++)
            {
                if (finddigit[i] == '?')
                {
                    return int.Parse(matchFindDigitValue[i].ToString());
                }
            }
            return 0;
        }
    }
}
