using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a temperature in Fahrenheit.");
            double temp = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your temperature in Celsius is {TempConverter.FahrenheitToCelsius(temp)}");

            Console.WriteLine();

            Console.WriteLine($"Give me a temperature in Celsius.");
            temp = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your temperature in Fahrenheit is {TempConverter.CelsiusToFahrenheit(temp)}");



        }
    }
}
