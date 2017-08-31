using System; 

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile || !aSmile && !bSmile)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday || isVacation)
            { return true;
            }
            else
            { return false; }
        }

        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                return 2 * (a + b);
            }
            else
            {
                return a + b;

            } 
        }
        
        public int Diff21(int n)
        {
            int absDiff = Math.Abs(n - 21);
            if (n > 21)
            {
                return absDiff * 2;
                    } else
            {
                return absDiff;
            }
        }
        
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && (hour < 7 || hour > 19))
            {
                return true;
            } else
            {
                return false;
            }
        }
        
        public bool Makes10(int a, int b)
        {
            return (a == 10 || b == 10 || a + b == 10);
        }
        
        public bool NearHundred(int n)
        {
            return (Math.Abs(n - 100) <= 10) || (Math.Abs(n - 200) <= 10);
        }
        
        public bool PosNeg(int a, int b, bool negative)
        {
            // Given two int values, return true if one is negative and one is positive.Except if the parameter "negative" is true, then return true only if both are negative. 
            if (negative)
            {
                if (a < 0 && b < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            { if ((a < 0 && b >= 0) || (a >= 0 && b < 0)){
                    return true;
                }
                else
                { return false;
                }
            }
        }
        
        public string NotString(string s)
        {
            if (s.StartsWith("not"))
            {
                return s;
            }
            else
            {
                return "not " + s;
            }
            
        }
        
        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
        
        public string FrontBack(string str)
        {
            string returnString;
            switch (str.Length)
            {
                case 1:
                    ;
                    returnString = str;
                    break;
                case 2:
                    returnString = str.Substring(1, 1) + str.Substring(0, 1);
                    break;
                default:
                    returnString = str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
                    break;
            }

            return returnString;
        }
        
        public string Front3(string str)
        {
            string tempString;
            if (str.Length > 2)
            {
                tempString = str.Substring(0, 3);
            }
            else
            {
                tempString = str;
            }
            return tempString + tempString + tempString;
        }
        
        public string BackAround(string str)
        {
            return str.Substring(str.Length - 1, 1) + str + str.Substring(str.Length - 1, 1);
        }
        
        public bool Multiple3or5(int number)
        {
            return number % 3 == 0 || number % 5 == 0;
        }
        
        public bool StartHi(string str)
        {
            bool results = false;
            switch (str.Length)
            {
                case 0:
                    results = false;
                    break;
                case 1:
                    results = false;
                    break;

                case 2:
                    if (str == "hi")
                    { results = true;
                       
                    }
                    else
                    { results = false;
                    }
                    break;

                default:
                    if (str.StartsWith("hi ") || str.StartsWith("hi, "))
                        { results = true; }
                    else
                    { results = false; }
                        break;
                   
            }

            return results;

            
        }
        
        public bool IcyHot(int temp1, int temp2)
        {
            bool results = false;
            if (temp1 < 0 && temp2 > 100)
            { results = true; }
            else
            {
                if (temp1 > 100 && temp2 < 0)
                {
                    results = true;
                }
                
            }
            return results;
        }
        
        public bool Between10and20(int a, int b)
        
        {
            bool results = false;
           if (a > 9 && a < 21) { results = true; }
           if (b > 9 && b < 21) { results = true; }
            return results;
        }
        
        public bool HasTeen(int a, int b, int c)
        {
            bool results = false;
            if (a > 12 && a < 20) { results = true; }
            if (b > 12 && b < 20) { results = true; }
            if (c > 12 && c < 20) { results = true; }

            return results;
        }

        public bool SoAlone(int a, int b)
        {
            bool aresults = false;
            bool bresults = false;

            if (a > 12 && a < 20) { aresults = true; }
            if (b > 12 && b < 20) { bresults = true; }

            if (aresults && bresults)
            {
                return false;
            }
            else
            {
                if (aresults || bresults)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        public string RemoveDel(string str)
        {
            if (str.Substring(1,3) == "del")
            {
                return str.Remove(1, 3);
            }
            else
            {
                return str;
            }
        }
        
        public bool IxStart(string str)
        {
            bool results = false;

            if (str.Length > 2)
            {
                if (str.Substring(1, 2) == "ix")
                {
                    results = true;
                }
                else
                {
                    results = false;
                }
            }
            else
            {
                results = false;
            }
            

            return results;
        }
        
        public string StartOz(string str)
        {
            string results = "";
            switch (str.Length)
            {
                case 0:
                    results = "";
                    break;
                case 1:
                    results = "";
                    break;
                default:
                    if (str.StartsWith("oz"))
                    {
                        results = "oz";
                    }
                    else
                    {
                        if (str.Substring(0, 1) == "o")
                        {
                            results = "o";
                        }
                        else
                        {
                            if (str.Substring(1, 1) == "z")
                            {
                                results = "z";
                            }
                        }
                    }
                    break;
            }

            return results;
            
        }
        
        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else
            {
                if (b > a && b > c)
                {
                    return b;
                }
                else
                {
                    if (c > a && c > b)
                    {
                        return c;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

        }
        
        public int Closer(int a, int b)
        {
            int adiff = Math.Abs(10 - a);
            int bdiff = Math.Abs(10 - b);

            if (adiff < bdiff)
            {
                return a;
            }
            else
            { if (bdiff < adiff)
                {
                    return b;
                }
            else
                { return 0; }
            }
        }
        
        public bool GotE(string str)
        {
            int eCount = 0;
            for (int i = 0; i < str.Length; i++)
            { if (str.Substring(i, 1) == "e")
                {
                    eCount++;
                 }
            
            }
            if (eCount > 0 && eCount < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public string EndUp(string str)
        {
            string results = "";
            switch (str.Length)
            {
                case 0:
                    break;
                case 1:
                    results = str.ToUpper();
                    break;
                case 2:
                    results = str.ToUpper();
                    break;
                case 3:
                    results = str.ToUpper();
                    break;
                default:
                    results = str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
                    break;

            }
            return results;
        }
        
        public string EveryNth(string str, int n)
        {
            string results = "";
            for (int i = 0; i < str.Length; i += n)
            {
                results += str.Substring(i, 1);
            }
            return results;
        }
    }
}
