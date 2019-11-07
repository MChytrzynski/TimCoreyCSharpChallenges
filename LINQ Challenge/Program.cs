using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimaryChallenge("asdfxcb");
            System.Console.WriteLine("asdf");
        }
        static List<char> PrimaryChallenge(string input){
            return input.OrderBy(x=>x).ToList();
        }
    }
}
