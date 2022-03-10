using System;

namespace CheckLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Check Leap Year Problem\n");
            int YearInput = TakeInput();
            if (YearInput == -1)
                Console.WriteLine("\nThe given Input is Invalid");
            else if (IsLeapYear(YearInput))
                Console.WriteLine("\n" + YearInput + " is a Leap Year.");
            else
                Console.WriteLine("\n" + YearInput + " is not a Leap Year");
        }

        public static int TakeInput()
        {
            Console.Write("Enter Year: ");
            string Input = Console.ReadLine();
            if (Input.Length == 4)
                return int.Parse(Input);
            else
                return -1;
        }

        public static bool IsLeapYear(int YearInput)
        {
            if (YearInput % 400 == 0 || (YearInput % 100 != 0 && YearInput % 4 == 0))
                return true;
            else
                return false;
        }
    }
}
