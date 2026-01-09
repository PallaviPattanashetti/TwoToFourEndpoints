using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Services
{
    public class GreaterEqualServices
    {
        public string GetNumbers(int firstNumber, int secondNumber)
        {
          
            string statement1 = "";
            if (firstNumber > secondNumber) statement1 = $"{firstNumber} is greater than {secondNumber}";
            else if (firstNumber < secondNumber) statement1 = $"{firstNumber} is less than {secondNumber}";
            else statement1 = $"{firstNumber} is equal to {secondNumber}";

          
            string statement2 = "";
            if (secondNumber > firstNumber) statement2 = $"{secondNumber} is greater than {firstNumber}";
            else if (secondNumber < firstNumber) statement2 = $"{secondNumber} is less than {firstNumber}";
            else statement2 = $"{secondNumber} is equal to {firstNumber}";

            return $"{statement1}. {statement2}."; 
        }
    }
}