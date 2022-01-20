using System;
using System.Collections.Generic;

namespace Roman2Int
{
    class Program
    {
        public static int RomanToInt(string s)
        {

            // Dictionary that will hold all of the relevant
            // roman numerals and their integer values.
            var romanNumDict = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
            if (s.Length == 1) { return romanNumDict[s[0]]; }

            // Variable to keep track of the integer total
            // of each loop iteration. To be returned.
            var runningTotal = romanNumDict[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                // Can always add the next roman numeral to the running total.
                runningTotal += romanNumDict[s[i]];

                // This is where we need to check to see if the numeral
                // before the current is less than the current.
                // If it is, that means we need to subtract the previous from the current.
                if (romanNumDict[s[i - 1]] < romanNumDict[s[i]])
                {
                    runningTotal -= (romanNumDict[s[i - 1]] * 2);
                }
            }

            return runningTotal;
        }
        static void Main(string[] args)
        {
            int data = RomanToInt("CD");
            Console.WriteLine(data);
        }
    }
      
    }

