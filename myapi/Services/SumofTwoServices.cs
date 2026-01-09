using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class SumofTwoServices
    {
        public string GetSum(int num1, int num2)
        {
            return $"The sum of {num1} and {num2} is {num1+num2}.";
        }
    }
}