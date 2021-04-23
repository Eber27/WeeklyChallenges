using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }

            return vals.Contains(false) ? true : false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();
            var result = sum % 2;

            return result == 0 ? false : true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(Char.IsUpper) && password.Any(Char.IsLower) && password.Any(Char.IsNumber))
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
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            int i = 0;
            int[] array = new int[50];

            for (int odds = 1; odds < 100; odds += 2)
            {
                array[i] = odds;
                i++;
            }

            return array;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            int i = 0;

            foreach (var word in words)
            {
                words[i] = words[i].ToUpper();
                i++;
            }
        }
    }
}
