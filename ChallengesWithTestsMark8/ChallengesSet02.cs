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

            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            for (int i = 0; i <= vals.Length; i++)
                if (vals.Length % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 != 0)
            {
                return false;
            }
            else
                return true;
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
               if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
               else
            {
                return numbers.Min() + numbers.Max();
            }
          throw new NotImplementedException();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            int length = str1.Length;
            int length2 = str2.Length;
            if(length <= length2)
            {
                return length;
            }
            else if (length2 < length)
            {
                return length2;
            }
       
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
           foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;

            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
              var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];  
                }
                }
              return sum;
            
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            
            if (numbers == null)
            return false;
            int sum = numbers.Sum();
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
               
           throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else 
            {
              return number / 2;
            }

          
            throw new NotImplementedException();
        }
    }
}
