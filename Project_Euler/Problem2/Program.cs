using System;

namespace Problem2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int past1 = 1;
            int past2 = 0;
            int answer = 0;
            int current = 0;

            while ( current <= 4000000 )
            {
                current = past2 + past1;

                if ( current % 2 == 0)
                {
                    answer = answer + current;
                }
                past2 = past1;
                past1 = current;
            }
            Console.WriteLine("The answer is: " + answer);
        }
    }
}
