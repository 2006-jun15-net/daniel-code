using System;

namespace OneNamespace
{
    class Program
    {
        static void Method()
        {
            Console.WriteLine();
            var x = new OtherNamespace.Program();
            var y = new Program();
        }
    }
}