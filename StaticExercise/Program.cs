using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FarenheitToCelsius(68);
            var farenheit = TempConverter.CelciusToFarenheit(20);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"farenheit {farenheit}");
        }
    }
}
