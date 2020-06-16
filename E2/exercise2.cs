using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int num = int.Parse(userInput);
            num = num -1;
         for (int x = 0; x<=num; x++)
           {
               for(int y = 0;y<=(num-x); y++)
               {
                Console.Write(" ");
               }
               for (int z = num; z>=(num-x); z--)
               {
                   Console.Write("#");
               }
               Console.WriteLine("");
           }
        }
    }
}
