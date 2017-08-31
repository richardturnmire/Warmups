using System;
using System.Text.RegularExpressions;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            string results = "";
            for (int i = 0; i < n; i++)
            {
                results += str;
            }
            return results;
        }

        public string FrontTimes(string str, int n)
        {
            string results = "";
            string returnString = "";
            switch (str.Length)
            {
                case 0:

                    results = str;
                    break;
                case 1:
                    results = str;
                    break;
                case 2:
                    results = str;
                    break;
                default:
                    results = str.Substring(0, 3);
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                returnString += results;

            }
            return returnString;
        }

        public int CountXX(string str)
        {
            int results = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2) == "xx")
                { results++; }
            }
            return results;
        }

        public bool DoubleX(string str)
        {
            int xPos = -1;
            xPos = str.IndexOf("x");
            if (xPos > -1  && xPos < str.Length - 1)
            {
                if (str.Substring(xPos + 1, 1) == "x")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string EveryOther(string str)
        {
            string results = "";
            for (int i = 0; i < str.Length ; i+= 2)
            {
                results += str.Substring(i, 1);
            }

            return results;

        }

        public string StringSplosion(string str)
        {
            string results = "";
            for (int i = 1; i < str.Length; i++)
            {
                results += str.Substring(0, i);
            }
            return results + str;
        }

        public int CountLast2(string str)
        {
            if (str.Length < 3) return 0;

         int results = 0;

            string testString = str.Substring(str.Length - 2, 2);
            
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i , 2) == testString)
                {
                    results++;
                }
            }

            return results;
        }

        public int Count9(int[] numbers)
        {
            int results = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                {
                    results++;
                }
            }
            return results;
        }

        public bool ArrayFront9(int[] numbers)
        {
            int workingLength = numbers.Length;
            if (workingLength > 3) workingLength = 4;
            bool results = false;

            for (int i = 0; i < workingLength; i++)
            {
                if (numbers[i] == 9)
                {
                    results = true;
                    break;
                }
            }

            return results;

        }

        public bool Array123(int[] numbers)
        {
            bool results = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    results = true;
                    break;
                }
            }
            return results;
        }

        public int SubStringMatch(string a, string b)
        {
            int results = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (b.IndexOf(a.Substring(i, 2)) > -1)
                {
                    results++;

                }
            }
            return results;
        }

        public string StringX(string str)
        {
            string results = str.Substring(0, 1);

            for (int i = 1; i < str.Length -1; i++)
            {
                if (str.Substring(i, 1) != "x")
                {
                    results += str.Substring(i, 1);
                }
        
            }

            return results + str.Substring(str.Length - 1, 1);
        }

        public string AltPairs(string str)
        {
            string results = "";
            for (int i = 0; i < str.Length ; i += 4)
            {
                results += str.Substring(i, 1);
               if (i + 1 < str.Length)
                {
                    results += str.Substring(i + 1, 1);
                }
            }
                       

            return results;
        }

        public string DoNotYak(string str)
        {
            string results = str;
            //int xPos = -1;
            //for (int i = 0; i < results.Length; i++)
            //{
            //    xPos = results.IndexOf("yak");
            //    if (xPos > -1)
            //    {
            //       results = results.Remove(xPos, 3);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //return results;
            string pattern = "y.k";
            MatchCollection magrp = Regex.Matches(str, pattern);

            foreach (Match m in magrp)
            {
                Console.WriteLine("'{0}' found at index {1}.",
                                  m.Value, m.Index);
                results = results.Remove(m.Index,3);
            }

            return results;
        }

        public int Array667(int[] numbers)
        {
            int results = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6)
                {
                    if (numbers[i + 1] == 6 || numbers[i + 1] == 7)

                    {
                        results++;
                    }
                }
            }

            return results;
        }

        public bool NoTriples(int[] numbers)
        {
            bool results = true;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    results = false;
                    break;
                }
            }
            return results;
        }

        public bool Pattern51(int[] numbers)
        {
            bool results = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 5 && numbers[i + 2] == numbers[i] - 1)
               
                {
                    results = true;
                    break;
                }
            }
            return results;
        }

    }
}
