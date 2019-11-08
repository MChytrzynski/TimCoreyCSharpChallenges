using System;

namespace Datetime_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDate ="02.11.19 12:45";
            PrimaryChallenge(inputDate);
        }
        static void PrimaryChallenge(string inputDate){
            DateTime date=new DateTime();
            DateTime.TryParse(inputDate, out date);
            TimeSpan DateDifference = DateTime.UtcNow.Subtract(date);
            Console.WriteLine($"{DateDifference.Days} days and {DateDifference.Hours} hours passed since {inputDate}");
        }

    }
}
