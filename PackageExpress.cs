using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1: Display the initial welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Requirement 2: Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Requirement 3: Check if weight is greater than 50
            if (weight > 50)
            {
                // Display error and terminate program if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Requirement 4: Prompt for the package width
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            // Requirement 5: Prompt for the package height
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            // Requirement 6: Prompt for the package length
            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Requirement 7: Check if the total dimensions exceed 50
            if ((width + height + length) > 50)
            {
                // Display error and terminate program if dimensions are too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Requirement 8 & 9: Calculate the quote
            // Formula: (Width * Height * Length * Weight) / 100
            float dimensionsProduct = width * height * length;
            float quote = (dimensionsProduct * weight) / 100;

            // Requirement 10: Display the final quote as a dollar amount
            // The :F2 format ensures it shows two decimal places (e.g., $528.00)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}