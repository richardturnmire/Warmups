using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return $"Hello {name}!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
           return $"<{tag}>{content}</{tag}>";
        }

        public string InsertWord(string container, string word) {
            return container.Insert(2, word);
        }

        public string MultipleEndings(string str)
        {
            string holdString = str.Substring(str.Length - 2, 2);
            return holdString + holdString + holdString;
        }

        public string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }

        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return $"{b}{a}{b}";
            }
            else
            {
                return $"{a}{b}{a}";
            }
        }

        public string RotateLeft2(string str)
        {
            return str.Substring(2) + str.Substring(0, 2);
        }

        public string RotateRight2(string str)
        {
            return str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2);
        }

            public string TakeOne(string str, bool fromFront)
        {
            if (fromFront)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1, 1);
            }
        }

        public string MiddleTwo(string str)
        {
            return str.Substring(str.Length / 2 - 1, 2);
        }

        public bool EndsWithLy(string str)
        {
            return str.EndsWith("ly");
        }

        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
        }

        public string TakeTwoFromPosition(string str, int n)
        {
            int takeFrom = n;
            if (n < 1 || n > str.Length - 2) takeFrom = 0;

            return str.Substring(takeFrom, 2);
        }

        public bool HasBad(string str)
        {
            if (str.Length < 3)
            {
                return false;
            }
            bool results = false;
            if (str.Substring(0, 3) == "bad")
            {
                results = true;
            }
            else
            {
                if (str.Length > 3)
                    if (str.Substring(1, 3) == "bad")
                    {
                        results = true;
                    }
            }

            return results;
            
        }

        public string AtFirst(string str)
        {
            
            return str.PadRight(2, char.Parse("@")).Substring(0,2);
        }

        public string LastChars(string a, string b)
        {
            if (a.Length == 0) a = "@";
            if (b.Length == 0) b = "@";
            return a.Substring(0, 1) +
                   b.Substring(b.Length - 1, 1);
        }

        public string ConCat(string a, string b)
        {
            string results = a + b;
            for (int i = 0; i < results.Length - 1; i++)
            {
                if (results.Substring(i, 1) == results.Substring(i + 1, 1))
                {
                    results = results.Remove(i + 1, 1);
                }
            }
            return results;
        }

        public string SwapLast(string str)
        {
            if (str.Length < 2) return str;

            if (str.Length < 3)
            {
                return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1, 1) + str.Substring(str.Length - 2, 1);
            }
            else
            {
                return str.Substring(0, str.Length - 2) + str.Substring(str.Length - 1, 1) + str.Substring(str.Length - 2, 1);
            }
        }

        public bool FrontAgain(string str)
        {
            return str.Substring(0, 2) == str.Substring(str.Length - 2, 2);
        }

        public string MinCat(string a, string b)
        {
            string results = "";

            if (a.Length < b.Length)
            {
                results = a + b.Substring(b.Length - a.Length, a.Length);
            }
            else
            {
                if (a.Length > b.Length)
                {
                    results = a.Substring(a.Length - b.Length, b.Length) + b;
                }
                else
                {
                    results = a + b;
                }
            }
            return results;
        }

        public string TweakFront(string str)
        {
            if (str.Length == 0) return str;

            string results;
            if (str.Substring(0, 1) == "a")
            {
                if (str.Substring(1, 1) == "b")
                {
                    results = str;
                }
                else
                {
                    results = str.Remove(1, 1);
                }

            }
            else
            {
                if (str.Substring(1,1) == "b")
                    if (str.Substring(0, 1) == "a")
                    {
                        results = str;
                    }
                    else
                    {
                        results = str.Remove(0, 1);
                    }
                else
                {
                    results = str.Remove(0, 2);
                }
            }
            return results;
        }

        public string StripX(string str)
        {
            string results = str;
            if (results.StartsWith("x"))
            {
                results = results.Substring(1);
            }
            if (results.EndsWith("x"))
            {
                results = results.Remove(results.Length - 1, 1);
            }
            return results;
        }
    }
}
