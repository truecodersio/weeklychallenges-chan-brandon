using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
			if (Char.IsLetter(c))
			{
				return true;
			}
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double num = -100d;
            double num2 = 100d;
            double max = 0d;
            double min = 0d;
            if (numbers == null)
            {
                return 0;
            }
            foreach (double value in numbers)
            {
                if (num < value)
                {
                    num = value;
                    max = num;
                }
            }
            foreach (double value in numbers)

            {   if (num2 > value)
                {
                    num2 = value;
                    min = num2;
                }
            }
            return min + max;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            var sums = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                sums += numbers[i];
            }
            return sums;
        }

        public int SumEvens(int[] numbers)
        {
            var sums = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sums += numbers[i];
                }
            }
            return sums;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sums = 0;
            if (numbers == null)
            {
                return false;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sums += numbers[i];
                }
            }
            if (sums % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long counter = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
