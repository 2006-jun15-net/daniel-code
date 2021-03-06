﻿using System;

namespace ProceduralBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // the Main method is ultimately run by the "dotnet run" command.

            // each "line of code" is a "statement " ending in a semicolon.
            int x = 5; // declares a variable named "x" with type "int" (integer, whole number), and 
                        // gives it the value 5.
            x = 4;
            
            // numeric data types
            //  whole numbers
            //      int (4 bytes, between -2 billion to 2 billion)
            //      short (2 bytes), long (8 bytes), byte (1 byte)

            //  numbers with fractions (floating point number)
            //      double (8 bytes, very wide range)
            //      float (4 bytes, less precise)

            //true or false
            //  bool
            
            
            //bool mathWorks = (3 + 3 == 6); // true

            // test
            //      String (more than one character, use double quotes)
            //      char (just one character, use single quotes)

            //  collections
            //      arrays
            //          in[], double[], anything you want

            int[] numbers = { 4, 5, 9, 2};

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter a Number");
            string userInput = Console.ReadLine();

            // int.Parse can convert a string into the int it represents
            int number = int.Parse(userInput);
            
            number *= 2; // shorthand for writing "number = number *2;"
            
            // the number will be converted back to a string and combined with the first string
            Console.WriteLine("Doubled: " + number);

            // control structures
            //      let us run lines of code conditionally or repeatedly
            if (number <0)
            {
                Console.WriteLine("negative number");
            }
            else
            {
                // repeatedly decrease the number untill it's negative 
                for(; number>= 0; number -=5)
                // (init; test; update)
                {
                    Console.WriteLine(number);
                    //print e.g. 17 then 12 then 7 then 3
                }
            }

           
        }
    }
}
