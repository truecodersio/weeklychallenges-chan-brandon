using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = 0;
            var odds = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odds += numbers[i];
                }
                if (numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                }
            }
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var newArray = new string[4];
            newArray[0] = str1;
            newArray[1] = str2;
            newArray[2] = str3;
            newArray[3] = str4;
            var smallest = newArray[0];
            var smaller = 0;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i].Length < smallest.Length)
                {
                    smallest = newArray[i];
                }
                smaller = smallest.Length;
            }
            return smaller;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var number = number1;
            var newArray = new int[4];
            newArray[0] = number1;
            newArray[1] = number2;
            newArray[2] = number3;
            newArray[3] = number4;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (number > newArray[i])
                {
                    number = newArray[i];
                }
            }
            return number;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var a = sideLength1;
            var b = sideLength2;
            var c = sideLength3;

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input == "")
            {
                return false;
            }
            if (input.StartsWith('-') || input.Contains('.') && input.Any(char.IsDigit))
            {
                return true;
            }
            else if (input.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var counter = 0;
            var numCounter = 0;
            foreach (var value in objs)
            {
                if (value == null)
                {
                    counter++;
                }
                if (value != null)
                {
                    numCounter++;
                }
            }
            if (counter > numCounter)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0d;
            var counter = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                    counter++;
                }
            }
            if (counter == 0)
            {
                return 0;
            }
            return evens / counter++;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            var num = 1;
            while (number != 1)
            {
                num = num * number;
                number = number - 1;
            }
            return num;
        }
    }
}
