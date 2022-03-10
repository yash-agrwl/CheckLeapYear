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
            else
                Console.WriteLine("\nThe give Input is Valid");
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
    }
}
