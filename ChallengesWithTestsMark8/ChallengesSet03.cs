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
            else if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            int num1 = numbers.Sum() % 2;
            if (num1 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           bool caseLower = false;
           bool caseUpper = false;
           bool isNumber = false;

            




            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    caseLower = true;
                }
                if (char.IsUpper(password[i]))
                {
                    caseUpper = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }
                if (caseLower && caseUpper && isNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            char letter = val[0];
            return letter;

            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val[val.Length - 1];
            return last;
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }

            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            int result = nums[nums.Length - 1] - nums[0];
            return result;

            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if ( i% 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();

                throw new NotImplementedException();
            }
           
        

        public void ChangeAllElementsToUppercase(string[] words)
        {
          for (var  i = 0; i < words.Length; i++)
            {
               words[i] = words[i].ToUpper();
            }
        }
    }
}
