using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CoderByte_FirstFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the C# language, have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it. 
            //For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. 
            //For the test cases, the range will be between 1 and 18 and the input will always be an integer. 


            //this algorithm works until I hit the factorial of 13
            //the factorial of 12 is 479001600 - this algorithm works to determine that, but fails once I compute 13
            //at first, I thought it was because of the limitations of int, so I found System.Numerics and BigInteger
            //this didn't help at all, it resolved to the same things.

            //why does this fail at 13, other than that number just being cursed?

            Console.WriteLine(FirstFactorial(13));
            Console.ReadLine();
        }

        static BigInteger FirstFactorial(int num)
        {
            BigInteger result = 0;
            List<int> nums = new List<int>();
            int counter = 0;
            while (counter < num)
            {
                nums.Add(num);
                num--;
            }
            result = nums.Aggregate((a, x) => a * x);

            return result;
        }
    }
}
