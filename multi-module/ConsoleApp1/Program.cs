using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 c = new Class1();
            Console.WriteLine("c.compute=" + c.ComputeNumber());
        }
    }
}
