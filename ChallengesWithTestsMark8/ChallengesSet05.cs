using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber/n + 1) * n);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)

            {
                if (businesses[i].TotalRevenue == 0)
                    businesses[i].Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            {
            if (numbers == null || numbers.Length == 0)
                return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                    return false;
            }
            return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
                return 0;

            int SumTotal = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    SumTotal += numbers[i];
                }

               
            }
            return SumTotal;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";

            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] Arrays = new double[0];
            if (elements == null)
                return Arrays;

            double[] fourthElem = elements.Where((x, i) => i % 4 == 3).ToArray();
            return fourthElem;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int z = i + 1; z < nums.Length; z++)
                {
                    if (nums[i] + nums[z] == targetNumber)
                    {
                        return true;
                    }
                }

            }

            return false;
        }
    }
}
