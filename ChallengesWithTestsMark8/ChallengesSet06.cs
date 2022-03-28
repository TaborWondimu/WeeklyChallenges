using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            // base case
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if( ignoreCase == true)
            {
                word = word.ToLower();  
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
                
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
         
            if(num >= 0)
            {
               if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true; 
                }
            }
            if ((num == 2) || (num == 3))
           {
                isPrime = true;
            }
            if( num == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;
            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if(str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }
                if(uIndex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int countC = 1;
                for (int j = i + 1; j < numbers.Length;j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    countC++;
                }
                if(countC > count)
                {
                    count = countC;
                }
            }
            return count;
           
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
           if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> nElement = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
              if( elements[i] % n == 0)
                {
                    nElement.Add(elements[i]);  
                }
                if (n < 0 || n > elements.Count)
                {
                    nElement.Clear();
                }
            }
            return nElement.ToArray();
          
        }
    }
}
