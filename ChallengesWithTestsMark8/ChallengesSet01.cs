using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //clean up your formatting with the curly braces
            if (num1 == num2)
                {
                return true;
                }
            else
                {
                return false;
                }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            var resultSubtract = minuend - subtrahend;
            return resultSubtract;
        }

        public int Add(int number1, int number2)
        {
            var resultAdd = number1 + number2;
            return resultAdd;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else if (number1 == number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            var resultMultiply = factor1 * factor2;
            return resultMultiply;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return "Hello, " + nameOfPerson + "!";
            }          
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
