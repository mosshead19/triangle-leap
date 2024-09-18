using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYearIdentifier
{
    internal class Program
    {
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static void Main(string[] args)
        {
            // Test years and expected results
            int[] testYears = { 2024, 1900, 2000, 2023, 2400, 2100 };
            bool[] expectedResults = { true, false, true, false, true, false };

            // Loop to test each year and compare the result with expected
            for (int i = 0; i < testYears.Length; i++)
            {
                bool result = IsLeapYear(testYears[i]);
                Console.WriteLine($"Year: {testYears[i]}, Expected: {expectedResults[i]}, Result: {result}");

                // Check if the result matches the expected result
                if (result == expectedResults[i])
                {
                    Console.WriteLine("Test passed.");
                }
                else
                {
                    Console.WriteLine("Test failed.");
                }
            }
        }
    }
}
