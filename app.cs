using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Mostrar el mensaje de bienvenida inicial
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Solicitar el peso del paquete
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // 3. Verificar si el peso es mayor a 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Finalizar el programa si es muy pesado
                return;
            }

            // 4. Solicitar el ancho del paquete
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            // 5. Solicitar la altura del paquete
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            // 6. Solicitar la longitud del paquete
            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // 7. Verificar si el total de las dimensiones es mayor a 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Finalizar el programa si es muy grande
                return;
            }

            // 8 & 9. Calcular la cotización (quote)
            // Multiplicar dimensiones, multiplicar por el peso y dividir entre 100
            float dimensionsProduct = width * height * length;
            float quote = (dimensionsProduct * weight) / 100;

            // 10. Mostrar el resultado formateado como monto de dinero (dólar)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Mantener la consola abierta para ver el resultado
            Console.ReadLine();
        }
    }
}