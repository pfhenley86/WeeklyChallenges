using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var result = 0;
            
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
            List<string> strings = new List<string> {str1, str2, str3, str4};

            int shortestLength = strings[0].Length;

            foreach (var str in strings)
            {
                if (str.Length < shortestLength)
                {
                    shortestLength = str.Length;
                }
            }
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> tinyNum = new List<int> { number1, number2, number3, number4 };
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
