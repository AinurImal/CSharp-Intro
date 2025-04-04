using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{   
    class Program
    {
        static void Main(string[] args)
        {
            var Imal = new Person();
            Imal.FirstName = "Imal";
            Imal.LastName = "Ainur";
            Imal.Introduce();   

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
