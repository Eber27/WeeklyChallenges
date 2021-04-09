using System;
using System.Collections.Generic;
using System.Linq;

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

            else

            {
                return false;
            }

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0 ? true : false);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0 ? true : false);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0 ? true : false);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }

            return (numbers.Min() + numbers.Max());
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
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }

            else
            {
                return (numbers.Sum());
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            if (numbers == null )
            {
                return false;
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }

            return number / 2;
        }
    }
}
