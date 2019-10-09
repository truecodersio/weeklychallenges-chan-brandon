using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }
            do
            {
                startNumber++;
            }
            while (startNumber % n != 0);
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0d)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            if (numbers.Length == 1)
            {
                return true;
            }

            var status = false;
            var newNumbers = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (newNumbers <= numbers[i])
                {
                    status = true;
                    newNumbers = numbers[i];
                }
                else if (newNumbers > numbers[i])
                {
                    status = false;
                    break;
                }
            }
            return status;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var after = 0;
            var counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                counter++;
                if (counter == numbers.Length)
                {
                    break;
                }
                if (numbers[i] % 2 == 0 || numbers[i] == 0)
                {
                    after += numbers[i + 1];
                }
            }
            return after;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var counter = 0;
            var newString = "";
            if (words == null)
            {
                return newString;
            }
            for (int i = 0; i < words.Length; i++)
            {
                counter++;
                if (words[i] == " " || words[i] == "" || words[i] == "  ")
                {
                    continue;
                }
                if (counter < words.Length)
                {
                    words[i] = words[i].Trim();
                    newString = newString + words[i] + " ";
                }
                if (counter == words.Length)
                {
                    words[i] = words[i].Trim();
                    newString += words[i] + ".";
                }
            }
            return newString;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var empty = new double[0];
            if (elements == null)
            {
                return empty;
            }
            var newList = new List<double>();
            var counter = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                counter++;
                if (counter % 4 == 0)
                {
                    newList.Add(elements[i]);
                }
            }
            double[] answer = newList.ToArray();
            return answer;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (i == k)
                    {
                        continue;
                    }
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
