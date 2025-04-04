// See https://aka.ms/new-console-template for more information
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(c < b || c > a);
        }
    }
}
