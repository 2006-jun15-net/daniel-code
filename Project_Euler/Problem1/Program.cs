using System;

namespace Problem1
{
    class Program
    {
        //If we list all the natural numbers below 10 
        //that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        // The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        static void Main(string[] args)
        {
            int x = 0;
            int answer = 0;
            while ( x < 1000)
            {
                if ((x%3 == 0)||(x%5 == 0))
                {
                    answer = answer + x;
                }
                x++;
            }
            Console.WriteLine("The answer to Problem one is: " + answer);
        }
    }
}
