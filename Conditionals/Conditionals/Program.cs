using System;


namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and a season of harvest.");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's Spring and a season of new beginnings.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer and a season of heat.");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter and a season of snow.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
            
    }
}
