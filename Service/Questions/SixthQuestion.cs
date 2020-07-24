using Domain;
using System.Collections.Generic;

namespace Service.Questions
{
    public class SixthQuestion : IQuestion
    {
        private string _word { get; set; }
        public SixthQuestion(string word)
        {
            this._word = word;
        }

        public ResultDomain Execute()
        {
            char[] chars = this._word.ToCharArray();
            int sumPos = ValueFromChar(chars);
            int n = 1;
            int numberTriangle = Calculate(n);
            do
            {
                if (numberTriangle == sumPos) return new ResultDomain() {
                    ListResultsInt = new List<int>() {
                            n
                    }
                };
                n++;
                numberTriangle = Calculate(n);
            } while (sumPos >= numberTriangle);
            return new ResultDomain() {
                ListResultsInt = new List<int>() {
                            -1
                    }
            };
        }

        private int ValueFromChar(char[] chars)
        {
            var result = 0;
            foreach(char c in chars)
            {
                result += ((int)char.ToUpper(c)) - 64;
            }
            return result;
        }

        private int Calculate(int n)
        {
            return (n * (n + 1)) / 2;
        }
    }
}
