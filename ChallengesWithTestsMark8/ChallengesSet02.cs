using System;
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
            throw new NotImplementedException();
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
            foreach(var number in numbers)
            {
                var sum = 0;
                if (number % 2 == 0)
                {
                    sum += number;
                }

                return sum;
            }
            
            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
