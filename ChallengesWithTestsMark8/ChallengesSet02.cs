﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CharacterIsNotALetter(char c)
        {
            return !char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
    
            var max = numbers.Max();
            var min = numbers.Min();
    
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null) str1 = "";
            if (str2 == null) str2 = "";

            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                int sum = 0;
        
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
        
                return sum;
            }
    
            return 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            
            var sum = 0;
            
            foreach(var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                
            }
            
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            
            return number / 2;
        }
    }
}
