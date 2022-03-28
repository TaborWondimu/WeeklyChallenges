using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            if (startNumber == 0)
            {
                return n;
            }
         
            var result1 = 0;
            int max = startNumber * n;
            for (int i = startNumber; i < max; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    result1 = i;
                    break;
                }
            }

                return result1;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
          for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
          
        }

        public bool IsAscendingOrder(int[] numbers)
        {
          
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <  numbers[i - 1])
                {
                    return false;
                }
                
            }
            return true;

        }
                

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //  base case
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
           for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i -1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //base case
            if(words == null || words.Length == 0)
            {
                return "";
            }
            string result = "";
            foreach(string word in words)
            {
                if(word.Trim().Length > 0)
                {
                    result += word.Trim() + " ";
                }
            }
            if (result.Length == 0)
            {
                return "";
            }
            result = result.Substring(0, result.Length - 1);
            result += ".";
            return result;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            // base case
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> result = new List<double>();
           for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
           return result.ToArray();

        }
        
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            // base case
            if(nums == null || nums.Length == 0)
            {
                return false;
            }
           for(int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
           return false;
        }
    }
}
