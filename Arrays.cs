using System;

namespace Warmups.BLL
{
    public class Arrays
    {

        public bool FirstLast6(int[] numbers)
        {
            if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6) {
                return true;
            } else {
                return false;
            }
        }

        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                if (numbers[0] == numbers[numbers.Length - 1])
                {
                    return true;
                } else
                {
                    return false;
                } 
            } else
            {
                return false;
            }
        }

        public int[] MakePi(int n)
        {
            string strPi = Math.PI.ToString();
            int intTemp;
            int [] digitsPi = new int[n] ;
            int intCount = 0;
            

          
            for (int i = 0; i < strPi.Length; i++)
            {
                if (int.TryParse(strPi.Substring(i, 1), out intTemp))
                {
                  
                    digitsPi[intCount] = intTemp;
                    intCount++;

                    if (intCount == n) { break; }
                }
             }


            return digitsPi;
        }
        
        public bool CommonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
                    } else
            {
                return false;
            } 
        }
        
        public int Sum(int[] numbers)
        {
            int sumIntegers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumIntegers += numbers[i];
            }
            return sumIntegers;
        }
        
        public int[] RotateLeft(int[] numbers)
        {
            int SaveFirstElement = numbers[0];
            for (int i = 1; i < numbers.Length ; i++){
                numbers[i - 1] = numbers[i];
            }
            numbers[numbers.Length - 1] = SaveFirstElement;
            return numbers;
        }
        
        public int[] Reverse(int[] numbers)
        {
            int[] reverseNumbers = new int[numbers.Length];
            int newPos = numbers.Length - 1;

            for( int i=0; i < numbers.Length; i++)
            {
                reverseNumbers[newPos] = numbers[i];
                newPos--;
            }

            return reverseNumbers;

        }
        
        public int[] HigherWins(int[] numbers)
        {
            int savedNumber = numbers[0];
            
            int[] newNumbers = new int[numbers.Length];

            if (numbers[0] > numbers[numbers.Length - 1])
            {
                savedNumber = numbers[0];
            } else {
                savedNumber = numbers[numbers.Length - 1];
             }
        
            for (int i = 0; i < numbers.Length; i++)
            {
                newNumbers[i] = savedNumber;
            }
            return newNumbers;
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] intMiddle = new int[2];
            intMiddle[0] = a[1];
            intMiddle[1] = b[1];
            return intMiddle;
        }
        
        public bool HasEven(int[] numbers)
        {
            bool evenFound = false;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenFound = true;
                    break;
                }
            }
            return evenFound;
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] lastArray = new int[numbers.Length * 2];
            lastArray[lastArray.Length - 1] = numbers[numbers.Length - 1];
            return lastArray;
        }


        public bool Double23(int[] numbers)
        {
            int countTwos = 0;
            int countThrees = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    countTwos++;
                }
                else
                {
                    if (numbers[i] == 3)
                    {
                        countThrees++;
                    }
                }
            }
            if (countTwos == 2 || countThrees == 2)
            {
                return true;
            } else {
                return false; 
            }
        }

            public int[] Fix23(int[] numbers)
        {
            int[] fixedNumbers = new int[numbers.Length];

            fixedNumbers[0] = numbers[0];

            for (int i = 1; i < numbers.Length ; i++)
            {
                if (numbers[i - 1] == 2 && numbers[i] == 3)
                {
                    fixedNumbers[i] = 0;
                } else
                {
                    fixedNumbers[i] = numbers[i];
                }
                }

            return fixedNumbers;

        }
        
        public bool Unlucky1(int[] numbers)
        {
            bool results = false;
            for (int i = 0; i < 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 3)
                {
                    results = true;
                }
            }
            if (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length -1] == 3)
            { results = true; }

            return results;
        }
        
        public int[] Make2(int[] a, int[] b)
        {
            int[] newArrayInts = new int[2];
            int intPosition = -1;

            for (int i = 0; i < a.Length; i++)
            {
                intPosition++;
                newArrayInts[intPosition] = a[i];
                
            }

            for (int i = 0; i < b.Length; i++)
            { if (intPosition < 1)
                {
                    intPosition++;
                    newArrayInts[intPosition] = b[i];
                }
            }

            return newArrayInts;
        }

    }
}
