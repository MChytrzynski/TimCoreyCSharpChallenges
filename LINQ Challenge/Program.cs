// Primary Challenge
// Create a LINQ query that takes in a string and returns a
// list of all the letters in order, regardless of case. 
 
// Bonus Challenge
// Modify the LINQ query to return a list of anonymous objects,
// each with a Letter property and a Count property.
// Populate the count with the number of times a letter is used.
// Order the list by letter count (max first) and then by character.


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
