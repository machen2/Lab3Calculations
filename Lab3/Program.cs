using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double originalFahrenheit;
            double celsius;
            double newFahrenheit;

            Console.Write("Enter temperature (Fahrenheit): ");
            originalFahrenheit = double.Parse(Console.ReadLine());

            celsius = ((originalFahrenheit - 32) / 9) * 5;

            Console.WriteLine("\n" + originalFahrenheit + " degrees Fahrenheit is " + celsius + " degrees Celsius.\n");

            newFahrenheit = ((celsius * 9) / 5) + 32;

            Console.WriteLine(celsius + " degrees Celsius is " + newFahrenheit + " degrees Fahrenheit.");
            Console.WriteLine();
        }
    }
}
