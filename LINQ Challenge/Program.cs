using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimaryChallenge("aasdfxcb");
            BonusChallenge("aassddddffxcbss");

        }
        static List<char> PrimaryChallenge(string input)
        {
            return input.OrderBy(x => x).ToList();
        }
        static Object BonusChallenge(string input)
        {
            input.Count();
            return input.Select(x => new
            {
                Letter = x,
                Count = input.Count(y => y == x)
            }).OrderByDescending(x => x.Count).ThenBy(x => x.Letter).ToList();

        }
    }
}
