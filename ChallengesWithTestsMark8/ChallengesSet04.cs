﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            /*var result = 0;
            
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
            
            return result;*/
            
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<int> {str1.Length, str2.Length, str3.Length, str4.Length};

            return strings.Min();

            /*int shortestLength = strings[0].Length;

            foreach (var str in strings)
            {
                if (str.Length < shortestLength)
                {
                    shortestLength = str.Length;
                }
            }
            return shortestLength; */
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var tinyNum = new List<int>() { number1, number2, number3, number4 };
            
            return tinyNum.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1
            );
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double result);
            
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var elements = objs.Length;
            var totalElements = (elements / 2) + 1;

            var count = 0;

            foreach (var obj in  objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            if (count >= totalElements)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            
            var averageEvens = numbers.Where(n => n % 2 == 0);

            if (averageEvens.Count() == 0)
                return 0;
            
            return averageEvens.Average();

        }

        public int Factorial(int number)
        {
            var factor = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            for(int i = number; i > 0; i--)
            {
                factor *= i;
            }
            return factor;
        }
    }
}
