using System;

namespace DateTimetest
{
    class Program
    {
        static void Main(string[] args)
        {
           var dateTime = new DateTime(2021, 1, 1);
           var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}