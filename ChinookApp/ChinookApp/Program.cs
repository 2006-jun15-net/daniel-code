using ChinookApp.DataConnect.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;


namespace ChinookApp
{
    class Program
    {
        
            public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.(); });
                                                                //place file path for text file
            String connectionString = System.IO.File.ReadAllText("C:/Users/james/Desktop/Revature/DBconnect.txt");
            DbContextOptions<ChinookContext> options = new DbContextOptionsBuilder<ChinookContext>()
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(connectionString)
                .Options;

        static void Main(string[] args)
        {
            DisplayData();

            Console.WriteLine("\nAdding some data...");
            AddSomeDataFromUserInput();

            DisplayData();

            Console.WriteLine("\nUpdating some data...");
            UpdateSomeData();

            DisplayData();

            Console.WriteLine("\nDeleting some data...");
            DeleteSomeData();

            DisplayData();
        }
        public static void DeleteSomeData()
        {
            throw new NotImplementedException();
        }

        public static void UpdateSomeData()
        {
            throw new NotImplementedException();
        }

        public static void AddSomeDataFromUserInput()
        {
            throw new NotImplementedException();
        }

            using var context = new ChinookContext(options);

            var salespeople = context.Employee
                .Where(e => e.Title.Contains("sales"))
                .ToList();

            foreach (var person in salespeople)
            {
                Console.WriteLine($"{person.Title} {person.FirstName} {person.LastName}");
            }
        }
    }
}
