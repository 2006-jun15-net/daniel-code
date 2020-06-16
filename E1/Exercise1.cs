using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int x = 0; x<=7; x++)
           {
               for(int y = 0;y<=(7-x); y++)
               {
                Console.Write(" ");
               }
               for (int z = 7; z>=(7-x); z--)
               {
                   Console.Write("#");
               }
               Console.WriteLine("");
           }
        }
    }
}
