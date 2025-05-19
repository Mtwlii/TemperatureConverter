using System;

class TemperatureConverter
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n Temperature Converter:");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Celsius to Kelvin");
            Console.WriteLine("3. Fahrenheit to Celsius");
            Console.WriteLine("4. Kelvin to Celsius");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1–5): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ConvertTemperature("Celsius", "Fahrenheit");
                    break;
                case "2":
                    ConvertTemperature("Celsius", "Kelvin");
                    break;
                case "3":
                    ConvertTemperature("Fahrenheit", "Celsius");
                    break;
                case "4":
                    ConvertTemperature("Kelvin", "Celsius");
                    break;
                case "5":
                    Console.WriteLine(" Exiting...");
                    return;
                default:
                    Console.WriteLine(" Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ConvertTemperature(string from, string to)
    {
        Console.Write($"Enter temperature in {from}: ");
        string input = Console.ReadLine();

        if (!double.TryParse(input, out double temp))
        {
            Console.WriteLine(" Invalid number. Try again.");
            return;
        }

        double result = 0;

        if (from == "Celsius" && to == "Fahrenheit")
            result = (temp * 9 / 5) + 32;
        else if (from == "Celsius" && to == "Kelvin")
            result = temp + 273;
        else if (from == "Fahrenheit" && to == "Celsius")
            result = (temp - 32) * 5 / 9;
        else if (from == "Kelvin" && to == "Celsius")
            result = temp - 273;

        Console.WriteLine($" {temp}° {from} = {result:F2}° {to}");
    }
}
