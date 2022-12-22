using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
             // Print a welcome message to the console
            Console.WriteLine("Temperature Converter");

            // Loop indefinitely until the user chooses to exit
            while (true)
            {
                // Print the menu of options to the console
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.Write("Enter your choice (1 or 2), or 0 to exit: ");

                 // Read the user's choice from the console
                string? input = Console.ReadLine();
                 // If the user did not enter anything, go back to the beginning of the loop
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                
                // Parse the user's choice as an integer

                if (!int.TryParse(input, out int choice))
                {
                    // If the input could not be parsed as an integer, print an error message and go back to the beginning of the loop
                    Console.WriteLine("Invalid choice.");
                    continue;
                }
                // If the user chose to exit, break out of the loop
                if (choice == 0)
                {
                    break;
                }
                // If the user chose to convert from Celsius to Fahrenheit, prompt them for a temperature in Celsius
                else if (choice == 1)
                {
                    Console.Write("Enter temperature in Celsius: ");
                    string? inputCelsius = Console.ReadLine();
                     // If the user did not enter anything, go back to the beginning of the loop
                    if (string.IsNullOrEmpty(inputCelsius))
                    {
                        continue;
                    }
                      // Parse the user's input as a double
                    if (!double.TryParse(inputCelsius, out double celsius))
                    {
                        // If the input could not be parsed as a double, print an error message and go back to the beginning of the loop
                        Console.WriteLine("Invalid temperature.");
                        continue;
                    }
                // Convert the temperature from Celsius to Fahrenheit
                    double fahrenheit = (9.0 / 5.0) * celsius + 32;
                    // Print the result to the console
                    Console.WriteLine($"{celsius} degrees Celsius is equal to {fahrenheit} degrees Fahrenheit.");
                }
                // If the user chose to convert from Fahrenheit to Celsius, prompt them for a temperature in Fahrenheit
                else if (choice == 2)
                {
                    Console.Write("Enter temperature in Fahrenheit: ");
                    string? inputFahrenheit = Console.ReadLine();
                    // If the user did not enter anything, go back to the beginning of the loop
                    if (string.IsNullOrEmpty(inputFahrenheit))
                    {
                        continue;
                    }
                    // Parse the user's input as a double
                    if (!double.TryParse(inputFahrenheit, out double fahrenheit))
                    {
                        // If the input could not be parsed as a double, print an error message and go back to the beginning of the loop
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
