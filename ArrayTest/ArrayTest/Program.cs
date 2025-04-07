using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Length:  " + numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:  " + index);

            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }
            Array.Sort(another);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }
        }
    }
}
