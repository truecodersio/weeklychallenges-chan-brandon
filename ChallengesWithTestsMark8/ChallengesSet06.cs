using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            List<string> newList = words.ToList();

            var answer = false;

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList.Contains(null))
                {
                    break;
                }
                if (newList[i] == word)
                {
                    answer = true;
                }
                if (newList[i].ToLower() == word && ignoreCase == true)
                {
                    answer = true;
                }
            }
            return answer;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 0 || num == 1 || num < 0)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1)
            {
                return 0;
            }

            var allCharSame = str.All(c => c == str[0]);

            if (allCharSame == true)
            {
                return -1;
            }

            char result = 'a';
            var count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.LastIndexOf(str[i]) == str.IndexOf(str[i]))
                {
                    result = str[i];
                    count++;
                }
            }

            if (count > 1)
            {
                for (int p = str.Length - 1; p <= 0; p--)
                {
                    return str.IndexOf(str[p]);
                }
            }

            for (int k = 0; k < str.Length; k++)
            {
                if (str.Length == 2)
                {
                    return 1;
                }
                if (str[k] == result)
                {
                    return str.IndexOf(str[k]);
                }
            }
            return 0;
        }



        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int constant = numbers[0];
            int counter = 1;
            int total = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == constant)
                {
                    counter++;
                }
                if (numbers[i] != constant)
                {
                    counter = 1;
                }
                if (counter > total)
                {
                    total = counter;
                }
                constant = numbers[i];
            }
            return total;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var newList = new List<double>();
            var newArray = new double[0];

            if (elements == null || n < 0)
            {
                return newArray;
            }

            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    newList.Add(elements[i - 1]);
                }
            }
            return newList.ToArray();
        }
    }
}
