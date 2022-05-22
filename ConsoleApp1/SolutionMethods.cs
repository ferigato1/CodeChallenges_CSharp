using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SolutionMethods
    {
        #region Convert number to reversed array of digits
        //better solution

        //public static long[] Digitize(long n)
        //{
        //    return n.ToString()
        //            .Reverse()
        //            .Select(t => Convert.ToInt64(t.ToString()))
        //            .ToArray();
        //}


        public static long[] Digitize(long n)
        {
            string str = n.ToString();
            string[] num = new string[str.Length];
            long[] digits = new long[str.Length];

            if (n == 0)
            {
                digits[0] = 0;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    num[i] = str.Substring(i, 1);
                }

                int k = 0;
                for (int y = str.Length - 1; y >= 0; y--)
                {
                    digits[k] = long.Parse(num[y]);
                    k++;
                }
            }

            return digits;
        }
        #endregion

        #region Show only the first inicials letter from the First Name and Last name separated by a dot and uppercase.


        //Better solution 1
        //public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();

        //Better solution 2
        //public static string AbbrevName(string name)
        //{
        //    string[] words = name.Split(' ');

        //    return (words[0][0] + "." + words[1][0]).ToUpper();
        //}


        public static string AbbrevName(string name)
        {
            string[] split = name.Split(' ');

            return split[0].Substring(0, 1).ToUpper() + "." + split[1].Substring(0, 1).ToUpper();
        }
        #endregion

        #region Return the number (count) of vowels in the given string. We will consider a, e, i, o, u as vowels (but not y).The input string will only consist of lower case letters and/or spaces.
        //Better solution

        //public static int GetVowelCount(string str)
        //{
        //    return str.Count(i => "aeiou".Contains(i));
        //}

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            char[] chrArray = str.ToCharArray();

            for (int i = 0; i < chrArray.Length; i++)
            {
                if (chrArray[i] == 'a' || chrArray[i] == 'e' || chrArray[i] == 'i' || chrArray[i] == 'o' || chrArray[i] == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
        #endregion

        #region Highest and lowest value of the array

        public static string HighAndLow(string numbers)
        {
            string[] strArr = numbers.Split(' ');
            int arrPos = strArr.Count();
            int[] array = new int[arrPos];

            for (int i = 0; i < strArr.Length; i++)
            {
                array[i] = int.Parse(strArr[i]);
            }

            int n1 = array.Max();
            int n2 = array.Min();

            return n1.ToString() + " " + n2.ToString();

        }
        #endregion

        #region Find the century of the year entered
        public static int СenturyFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
        #endregion

        #region Sheep Counter inside the boolean array counting only true.
        public static int CountSheeps(bool[] sheeps)
        {
            int cnt = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                    cnt++;
            }
            return cnt;
        }
        #endregion

        #region Complete the square sum function so that it squares each number passed into it and then sums the results together. For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
        //static void Main(string[] args)
        //{
        //    int[] n = { 1, 2, 2 };
        //    Console.WriteLine(SquareSum(n).ToString());
        //    Console.ReadLine();
        //}

        // Better solution
        //public static int SquareSum(int[] n) => n.Sum(i => i * i);


        public static int SquareSum(int[] n)
        {
            int answer = 0;
            double t = 0;
            foreach (var item in n)
            {
                double num = Math.Pow(item, 2);
                t += num;
                answer = (int)t;
            }
            return answer;
        }
        #endregion

        #region Removing space from string

        public static string NoSpace(string input)
        {

            string[] array = input.Split(' ');
            string str = "";
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i].ToString();
            }

            return str;
        }
        #endregion

        #region Squaring every digit of the int input

        public static int SquareDigits(int n)
        {
            string number = n.ToString();
            string[] arr = new string[number.Length];
            string whole = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = number[i].ToString();
                whole += Math.Pow(int.Parse(arr[i]), 2);
            }
            return int.Parse(whole);
        }
        #endregion

        #region Int Number in descending order

        //Better solution 1
        //public static int DescendingOrder(int num)
        //{
        //    return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        //}
        //Better solution 2
        //public static int DescendingOrder(int num)
        //{
        //    return int.Parse(string.Concat($"{num}".OrderByDescending(c => c)));
        //}

        public static int DescendingOrder(int num)
        {
            string number = num.ToString();
            int[] array = new int[number.Length];
            string result = "";

            for (int i = 0; i < number.Length; i++)
            {
                array[i] = int.Parse(number.Substring(i, 1).ToString());
            }

            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                result += item.ToString();
            }

            return int.Parse(result);
        }

        #endregion

        #region Converts this -> "abcd" into this "A-Bb-Ccc-Dddd"

        //Better solution
        //public static String Accum(string s)
        //{
        //    return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        //}
        //Better solution 2
        //public static String Accum(string s)
        //{
        //    return String.Join("-", s.Select((c, i) => Char.ToUpper(c) + new String(Char.ToLower(c), i)));
        //}

        public static string Accum(string s)
        {
            string[] arrayOrig = new string[s.Length];
            string[] arrayResult = new string[s.Length];
            int letterCounter = 1;
            bool firstTime = true;
            string upper, lower, whole;

            for (int i = 0; i < arrayOrig.Length; i++)
            {
                arrayOrig[i] = s.Substring(i, 1);
            }

            for (int i = 0; i < arrayOrig.Length; i++)
            {
                if (arrayOrig[i].Length == 1 && firstTime == true)
                {
                    arrayResult[i] = arrayOrig[i];
                    firstTime = false;
                }
                else
                {
                    for (int j = 0; j <= letterCounter; j++)
                    {
                        arrayResult[i] += arrayOrig[i];
                    }
                    letterCounter++;
                }
            }

            for (int i = 0; i < arrayResult.Length; i++)
            {
                for (int j = 0; j < arrayResult.Length; j++)
                {
                    upper = arrayResult[j].Substring(0, 1).ToUpper();
                    lower = arrayResult[j].Substring(1).ToLower();
                    whole = upper + lower;
                    arrayResult[i] = whole;
                    i++;
                }              
            }           

            return String.Join('-', arrayResult);
        }
        #endregion
    }
}
