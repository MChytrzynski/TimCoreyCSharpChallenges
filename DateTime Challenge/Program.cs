// Primary Challenge
// Capture a date from the console and
// calculate how many days ago it was.
// Then capture a time from the console
// and calculate how many hours and
// minutes ago it was (assume less than
// now and not previous day).
// Bonus Challenge
// For times, allow the user to choose to
// specify 12- or 24-hour format. For dates,
// allow the user to specify
// month/day/year or day/month/year
// format based upon their choice. Also,
// don’t assume times are not the previous
// day

using System;
using System.Globalization;

namespace Datetime_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please specify the date and time");
            string inputDate = Console.ReadLine();
            Console.WriteLine("Please specify the date format. For example MM.dd.yy hh:mm tt");
            string inputFormat = Console.ReadLine();
            System.Console.WriteLine("Please choose between 12 and 24 hour format (12/24)");
            string timeFormat = Console.ReadLine();
            BonusChallenge(inputDate, inputFormat, timeFormat);
        }
        static void PrimaryChallenge(string inputDate)
        {
            DateTime date = new DateTime();
            DateTime.TryParse(inputDate, out date);
            TimeSpan DateDifference = DateTime.UtcNow.Subtract(date);
            Console.WriteLine($"{DateDifference.Days} days and {DateDifference.Hours} hours passed since {inputDate}");
        }
        static void BonusChallenge(string inputDate, string inputFormat, string timeFormat)
        {
            DateTime result;
            string outputString = "passed since";
            if (timeFormat == "12")
            {
                DateTime.TryParseExact(inputDate, inputFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
            }
            else
            {
                DateTime.TryParseExact(inputDate, inputFormat, CultureInfo.CreateSpecificCulture("en"), DateTimeStyles.None, out result);
            }
            TimeSpan DateDifference = DateTime.UtcNow.Subtract(result);
            if (DateDifference.Milliseconds < 0)
            {
                DateDifference = DateDifference.Negate();
                outputString = "until";
            }
            Console.WriteLine($"{DateDifference.Days} days and {DateDifference.Hours} hours {outputString} {inputDate}");

        }

    }
}
