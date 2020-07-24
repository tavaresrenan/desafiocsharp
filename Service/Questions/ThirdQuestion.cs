using Domain;
using System.Collections.Generic;

namespace Service.Questions
{
    public class ThirdQuestion : IQuestion
    {

        public ResultDomain Execute()
        {
            return new ResultDomain()
            {
                ListResultsInt = new List<int>() {
                            Fibonacci(5)
                    }
            }; ;
        }

        private int Fibonacci(int n)
        {
            int val1 = 1;
            int val2 = 1;
            int acc = val1 + val2;
            while (acc.ToString().Length < n)
            {
                val2 = val1;
                val1 = acc;
                acc = val1 + val2;
            }
            return acc;
        }
    }
}
