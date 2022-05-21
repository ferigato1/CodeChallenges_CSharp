using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var valid = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Select one of the options bellow or type EXIT to quit:");
                Console.WriteLine("1. Convert number to reversed array of digits.");
                Console.WriteLine("2. Show only the first inicials letter of the First and Last name separated by a dot and uppercase.");
                Console.WriteLine("3. Return the number (count) of vowels in the given string. We will consider a, e, i, o, u as vowels (but not y).The input string will only consist of lower case letters and/or spaces.");
                Console.WriteLine("4. Highest and lowest value of the array.");
                Console.WriteLine("5. Find the century of the year entered.");
                Console.WriteLine("6. Sheep Counter inside the boolean array counting only the true sheeps.");
                Console.WriteLine("7. Complete the square sum function so that it squares each number passed into it and then sums the results together. For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.");
                Console.WriteLine("8. Remove space from string.");
                Console.WriteLine("9. Squaring every digit of the int input");
                Console.WriteLine("10. Convert Int Number in descending order");

                var input = Console.ReadLine();
                             
                switch (input.ToUpper())
                {
                    //Convert number to reversed array of digits
                    case "1":
                        Console.WriteLine("Entry with a Long number: ");
                        long lNumber = long.Parse(Console.ReadLine());
                        //Console.WriteLine(Digitize(entry));

                        long[] arr = SolutionMethods.Digitize(lNumber);

                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine(arr[i]);
                        }
                        continue;
                    //Show only the first inicials letter from the First Name and Last name separated by a dot and uppercase
                    case "2":
                        Console.WriteLine("Enter with First and Last Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine(SolutionMethods.AbbrevName(name));
                        continue;
                    //Return the number (count) of vowels in the given string. We will consider a, e, i, o, u as vowels (but not y).The input string will only consist of lower case letters and/or spaces.
                    case "3":
                        Console.WriteLine("Type a string to count the vowels:");
                        string str1 = Console.ReadLine();
                        Console.Write("Number of Vowels:" + SolutionMethods.GetVowelCount(str1) + "\n");
                        continue;
                    //Highest and lowest value of the array
                    case "4":
                        Console.WriteLine("Type numbers splited by a blank space:");
                        string str2 = Console.ReadLine();
                        Console.Write(SolutionMethods.HighAndLow(str2) + "\n");
                        continue;
                    //Find the century of the year entered
                    case "5":
                        Console.WriteLine("Type the year desired:");
                        int year = int.Parse(Console.ReadLine());
                        Console.WriteLine(SolutionMethods.СenturyFromYear(year));
                        continue;
                    //Sheep Counter inside the boolean array counting only true.
                    case "6":
                        Console.WriteLine("Type true or false separated by blank spaces:");
                        string [] sheep = Console.ReadLine().Split(' ');                                               
                        bool[] sheepB = new bool[sheep.Length];

                        for (int i = 0; i < sheep.Length; i++)
                        {
                            sheepB[i] = bool.Parse(sheep[i]);
                        }
                        Console.WriteLine("Sheeps quantity: " + SolutionMethods.CountSheeps(sheepB));            
                        Console.WriteLine("");
                        continue;
                    //Complete the square sum function so that it squares each number passed into it and then sums the results together. For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
                    case "7":
                        Console.WriteLine("Enter with numbers splited by blank spaces:");
                        string num1 = Console.ReadLine();
                        string[] arr1 = num1.Split(' ');
                        int[] n = new int [arr1.Length];

                        for (int i = 0; i < n.Length; i++)
                        {
                            n[i] = int.Parse(arr1[i]);
                        }
                        Console.WriteLine(SolutionMethods.SquareSum(n).ToString());                        
                        continue;       
                        //Removing space from string
                    case "8":
                        Console.WriteLine("Type the string you want to remove space:");
                        string strSpace = Console.ReadLine();
                        Console.WriteLine(SolutionMethods.NoSpace(strSpace));
                        continue;
                        //Squaring every digit of the int input
                    case "9":
                        Console.WriteLine("Enter with a number that will be converted");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(SolutionMethods.SquareDigits(num2));
                        continue;
                    case "10":
                        Console.WriteLine("Enter with a number that will be sorted in descending order");
                        int num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(SolutionMethods.DescendingOrder(num3));
                        continue;
                    //Exit
                    case "EXIT":
                        valid = false;
                        break;

                }

            } while (valid);
                      
        } 
        
    }

}



