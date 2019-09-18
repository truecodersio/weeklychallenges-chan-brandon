using System;
using System.Linq;
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
            // commented out inefficient code for refactored code using System.Linq
            // let me know if the challenge was for loops or if you just wanted the easiest way

            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();

         /* double max = Double.MinValue;
            double min = Double.MaxValue;
            if (numbers == null)
            {
                return 0;
            }

            foreach (double value in numbers)
            {
                if (max < value)
                {
                    max = value;
                }
            }
            foreach (double value in numbers)

            {   if (min > value)
                {
                    min = value;
                }
            }
            return min + max; */

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
