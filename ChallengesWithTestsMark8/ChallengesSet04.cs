﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortLength = str1.Length;
            var stringList = new List<string> { str1, str2, str3, str4 };

            foreach (var str in stringList)
            {
                if (str.Length < shortLength)
                {
                    shortLength = str.Length;
                }
            }

            return shortLength;
        }


        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbersList = new List<int> { number1, number2, number3, number4 };
            numbersList.Sort();

            return numbersList.ElementAt(0);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isNull = 0;
            int notNull = 0;
            foreach (var objects in objs)
            {
                if (objects == null)
                {
                    isNull++;
                }
                else
                {
                    notNull++;
                }
            }
            return isNull > notNull;
        }


        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double numTotal = 0;
            double count = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    numTotal += num;
                    count++;
                }
            }
            if (numTotal == 0)
            {
                return numTotal;
            }
            return numTotal / count;
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
            var result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
