using System;

using ConsoleApp41a; // JTM

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Class!");
            Console.WriteLine("Hello World!" + (new JTM()).Add(1,1));

            Console.ReadLine();

        }
    }
}
