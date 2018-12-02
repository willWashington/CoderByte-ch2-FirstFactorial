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

            //on first pass of this code, it broke on input 13 because int could not support the result of the factorial of 13
            //changing all my ints to longs resolved the problem


            long[] arr = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            foreach(long num in arr)
            {
                Console.WriteLine(FirstFactorial(num));
            }            
            Console.ReadLine();
        }

        static long FirstFactorial(long num)
        {
            long result = 0;
            List<long> nums = new List<long>();
            long counter = 0;
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
