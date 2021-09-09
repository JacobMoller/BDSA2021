using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = getUserInput();
            checkUserInput(input);
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }

        public static void checkUserInput(string input)
        {
            int num;
            bool parsed = int.TryParse(input, out num);
            if (parsed)
            {
                if (num >= 1582)
                {
                    //we are good boys, lets go
                    if (IsLeapYear(num))
                    {
                        Console.WriteLine("yay");
                    }
                    else
                    {
                        Console.WriteLine("nay");
                    }
                }
                else
                {
                    Console.WriteLine("This program only supports years from 1582. Try again:");
                    //int conversion failed. tell user to enter integers only
                    var input2 = getUserInput();
                    checkUserInput(input2);
                }
            }
            else
            {
                Console.WriteLine("Not a number. Try again:");
                //int conversion failed. tell user to enter integers only
                var input2 = getUserInput();
                checkUserInput(input2);
            }
        }

        public static string getUserInput()
        {
            var input = Console.ReadLine();
            return input.ToString();
        }
    }
}
