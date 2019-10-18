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

            var isSameChar = str.All(c => c == str[0]);

            if (isSameChar == true)
            {
                return -1;
            }

            var counter = -1;
            var count = 0;
            int temp = 0;
            char character = 'a';
            for (int i = 0; i < str.Length; i++)
            {
                for (int k = 0; k < str.Length; k++)
                {
                    if (str[i] == str[k])
                    {
                        counter++;
                        character = str[i];
                        temp = counter;
                    }
                    else if (str[i] != str[k])
                    {
                        if (temp > count)
                        {
                            count = temp;
                        }
                        counter = 0;
                        break;
                    }
                }
            }
            return count;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
