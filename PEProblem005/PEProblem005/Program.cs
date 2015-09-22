using System;
/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 * 
 * To get the result I used method comparable to sieve of Eratosthenes.
 * Eliminating the common divisor from all the numbers except the first appearance.
 */
namespace PEProblem005
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int arraySize = 21;

            int[] numbers = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = i;
            }

            for (int i = 2; i < arraySize; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (j % i == 0)
                    {
                        numbers[j] = numbers[j] / numbers[i];
                    }
                }
            }

            int result = 1;
            for (int i = 1; i < arraySize; i++)
            {
                result *= numbers[i];
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
