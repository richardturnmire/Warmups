using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
            {
                if (cigars > 39)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            { if (cigars > 39 && cigars < 61)
                {
                    return true;
                }
            else
                {
                    return false;
                }
            }
        }
        
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            int results = 1;

            if (yourStyle > 7 || dateStyle > 7)
            {
                if (yourStyle < 3 || dateStyle < 3)
                {
                    results = 0;
                }
                else
                {
                    results = 2;
                }
            }
            else
            {
                if (yourStyle < 3 || dateStyle < 3)
                {
                    results = 0;
                }
                else
                {
                    results = 1;
                }
            }
                return results;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            int upperLimit;
            if (isSummer)
            {
                upperLimit = 101;
            }
            else
            {
                upperLimit = 91;
            }

            if (temp > 59 && temp < upperLimit)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int birthdayBonus;
            if (isBirthday)
            {
                birthdayBonus = 5;
            }
            else
            {
                birthdayBonus = 0;
            }

            if (speed < 61 + birthdayBonus)
            {
                return 0;
            }
            else
            {
                if (speed < 81 + birthdayBonus)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }


        }
        
        public int SkipSum(int a, int b)
        {
            int results = a + b;

            if (results > 9 && results < 20)
            {
                results = 20;
            }
            
                return results;
            
        }
        
        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if (day == 0 || day == 6)
                {
                    return "off";
                }
                else
                {
                    return "10:00";
                }
            }
            else
            {
                if (day == 0 || day == 6)
                {
                    return "10:00";
                }
                else
                {
                    return "7:00";
                }
            }
        }
        
        public bool LoveSix(int a, int b)
        {
           if (a == 6 || b == 6)
            {
                return true;
            }
           else
            { if ((a + b == 6) || (Math.Abs (a - b) == 6))
                        {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n < 0 || n > 10)
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
                if (n > 0 && n < 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SpecialEleven(int n)
        {
            int remainder = n % 11;

            if (remainder < 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Mod20(int n)
        {
            int remainder = n % 20;

            if (remainder == 0)
            {
                return false;
            }
            else
            {
                if (remainder > 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public bool Mod35(int n)
        {
           if (n % 15 == 0)
            {
                return false;
            }
           else
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }
            else
            {
                if (isMorning)
                {
                    if (isMom)
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
                    return true;
                }
            }
        }

        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c)
            {
                return true;
            }
            else
            {
                if (a + c == b)
                {
                    return true;
                }
                else
                {
                    if (b + c == a)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (bOk)
            {
                if (c > b)
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
                if (b > a && c > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            int abDiff = b - a;
            int bcDiff = c - b;

            if (equalOk)
            {
                if (abDiff > -1 && bcDiff > -1)
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
                if (abDiff > 0 && bcDiff > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        
        public bool LastDigit(int a, int b, int c)
        {
            string stra = a.ToString();
            string strb = b.ToString();
            string strc = c.ToString();

            stra = stra.Substring(stra.Length - 1, 1);
            strb = strb.Substring(strb.Length - 1, 1);
            strc = strc.Substring(strc.Length - 1, 1);

            if (stra == strb || stra == strc)
            {
                return true;
            }
            else
            {
                if (strb == strc)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    die2++;
                    if (die2 == 6)
                    {
                        die2 = 1;
                    }
                }
                else
                { }

            }
            else
            {

            }

           return die1 + die2;
        }

    }
}
