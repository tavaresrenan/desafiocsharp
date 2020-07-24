using Domain;
using System;
using System.Collections.Generic;

namespace Service.Questions
{
    public class FirstQuestion : IQuestion
    {
        private string firstName, lastName = string.Empty;

        public FirstQuestion(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public ResultDomain Execute()
        {
            var domain = new ResultDomain();
            domain.ListOfResults = new List<String>();
            for(int n = 1; n <= 100; n++)
            {
                string sResult = string.Empty;
                if ((n % 15) == 0)
                {
                    sResult = $"{n} - {this.firstName} {this.lastName}";
                }
                else if((n % 5) == 0)
                {
                    sResult = $"{n} - {this.lastName}";
                }
                else if((n % 3) == 0)
                {
                    sResult = $"{n} - {this.firstName}";
                } else
                {
                    sResult = $"{n}";
                }
                domain.ListOfResults.Add(sResult);
            }

            return domain;
        }
    }
}
