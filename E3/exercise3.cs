using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
             string userInput = Console.ReadLine();
             int number = int.Parse(userInput);
             while (number != 1)
             {
                if ((number%2) == 0)
                {
                    number = number/2;
                }
                else
                {
                    number = (number * 3) + 1;
                }
                Console.WriteLine(number);
             }
        }
    }
}
