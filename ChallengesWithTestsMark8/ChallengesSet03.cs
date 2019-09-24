using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int store = 0;
            foreach (int num in numbers)
            {
                if (numbers == null)
                {
                    return false;
                }
                if (num % 2 != 0)
                {
                    store += num;
                }
            }
            if (store % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int constant = 0;
            var newList = new List<int>();
            while (constant < 100)
            {
                constant++;
                if (constant % 2 != 0)
                {
                    newList.Add(constant);
                }
            }
            int[] newArray = newList.ToArray();
            return newArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word.ToUpper());
            }
        }
    }
}
