using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where( x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new List<string>();   
            strings.Add(str1);
            strings.Add(str2);
            strings.Add(str3);
            strings.Add(str4);
            int shortest = strings.Min(words => words.Length);
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var inputs = new List<int>();

            inputs.Add(number1);
            inputs.Add(number2);
            inputs.Add(number3);
            inputs.Add(number4);

            return inputs.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
           else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            double output;
            return double.TryParse(input, out output);

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            var itemTotal = objs.Length;
            var majority = (itemTotal / 2) + 1;

            foreach ( var elements in objs)
            {
                if (elements == null)
                {
                    count++;
                }
            }
            if (count >= majority)
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
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
          var n = numbers.Where(num => num % 2 == 0);
            if(n.Count() == 0)
            return 0;
          
            return n.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                int result = (number == 1 || number == 0) ? 1 : number * Factorial(number - 1);
                
                return result;
            }

        }
    }
}
    

