using System;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write String Here: ");
            String a = Console.ReadLine();
            int stringSize = a.Length;
           // Console.WriteLine(stringSize);
            for (int i = (stringSize-1); i>=0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
        }
        
    }
}