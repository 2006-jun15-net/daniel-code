using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 600851475143;
            int count = 1;
            double max = Math.Sqrt(x);
            max = Math.Round(max);
            int answer = 0;

            while (count<max)
            {
                if(( x % count ) == 0)
                {
                    answer = count;
                }

                count = count +2;
            }

            count =1;
            int Prime = 0;

            while (count<answer)
            {
                if(( answer % count ) == 0)
                {
                    Prime = count;
                }

                count = count +2;
            }

            Console.WriteLine("The answer is: " + Prime);
        }
    }
}
