using Domain;
using System.Collections.Generic;

namespace Service.Questions
{
    public class SecondQuestion : IQuestion
    {
        int[] values = null;

        public SecondQuestion() { }

        public SecondQuestion(int[] values)
        {
            this.values = values;
        }

        public ResultDomain Execute()
        {
            if (this.values.Length == 0) return new ResultDomain() { ListResultsInt = new List<int>() { 0 } };
            return new ResultDomain() { 
                    ListResultsInt = new List<int>() { 
                            Sum(this.values, 0, 0) 
                    } 
            };
        }

        private int Sum(int[] v1, int pos, int total)
        {
            if (v1.Length == pos) return total;
            total += (v1[pos] * v1[pos]);
            return Sum(v1, pos + 1, total);
        }
    }
}
