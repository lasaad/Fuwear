using System.Collections.Generic;
using System.Linq;

namespace Fuwear.WebApi.Services
{
    public class NPICalcService
    {

        public int GetNPICalc(string npiString)
        {
            var tmp = GetNumbersOperande(npiString);

            var operandes = tmp.Item1;
            var numbers = tmp.Item2;
            int result = numbers.LastOrDefault();

            for (int i = numbers.Length - 1, j = 0; i > 0; i--, j++)
            {
                result = Calc(operandes[j], result, numbers[i - 1]);
            }

            return result;
        }

        private (string[], int[]) GetNumbersOperande (string npiString)
        {

            string[] chars = npiString.Split(' ');
            List<string> resultOperande = new List<string>();
            List<int> resultNumbers = new List<int>();
            
            foreach (var item in chars)
            {
                if (int.TryParse(item, out int n))
                {
                    resultNumbers.Add(n);
                }
                else
                {
                    resultOperande.Add(item);
                }
            }

            return (resultOperande.ToArray(), resultNumbers.ToArray());
        }

        private int Calc(string operande, int number1, int number2)
        {
            switch (operande)
            {   
                case "*":
                    return number1 * number2;
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                default:
                    return number1;
            }
        }
    }
}
