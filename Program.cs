using System;

class Program
{
    static bool IfYearIsLeap(int year)
    {
        if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
        {
            return true; // It's a leap year!
        }
        else
        {
            return false; // Not a leap year
        }
    }

    static void Main(string[] args)
    {
        // Test the function
        Console.WriteLine("Is 2016 a leap year? " + IfYearIsLeap(2016)); // true
        Console.WriteLine("Is 2018 a leap year? " + IfYearIsLeap(2018)); // false
    }
}
