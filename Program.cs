using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");

            while (true)
            {
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.Write("Enter your choice (1 or 2), or 0 to exit: ");

                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                if (choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    Console.Write("Enter temperature in Celsius: ");
                    string? inputCelsius = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputCelsius))
                    {
                        continue;
                    }

                    if (!double.TryParse(inputCelsius, out double celsius))
                    {
                        Console.WriteLine("Invalid temperature.");
                        continue;
                    }

                    double fahrenheit = (9.0 / 5.0) * celsius + 32;
                    Console.WriteLine($"{celsius} degrees Celsius is equal to {fahrenheit} degrees Fahrenheit.");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter temperature in Fahrenheit: ");
                    string? inputFahrenheit = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputFahrenheit))
                    {
                        continue;
                    }

                    if (!double.TryParse(inputFahrenheit, out double fahrenheit))
                    {
                        Console.WriteLine("Invalid temperature.");
                        continue;
                    }

                    double celsius = (5.0 / 9.0) * (fahrenheit - 32);
                    Console.WriteLine($"{fahrenheit} degrees Fahrenheit is equal to {celsius} degrees Celsius.");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}
