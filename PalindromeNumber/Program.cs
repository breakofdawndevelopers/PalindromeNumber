using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Palindrome Number Game");
            int count = 1;
            while (true)
            {
                try
                {
                    string palendrome = "";
                    string numberReversed = "";

                    char[] palendromeArray = count++.ToString().ToCharArray();
                   

                    foreach (char item in palendromeArray)
                    {
                        palendrome += item;
                    }

                    Array.Reverse(palendromeArray);

                    foreach (char items in palendromeArray)
                    {
                        numberReversed += items;
                    }

                    if (palendrome == numberReversed)
                    {
                        Console.WriteLine("Your number is a Palendrome! " + numberReversed + " Press enter to see the next Palendrome.");
                        Console.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Exception Caught");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
