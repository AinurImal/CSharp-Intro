// See https://aka.ms/new-console-template for more information
using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted into byte");
            }
            
        }
    }
}

