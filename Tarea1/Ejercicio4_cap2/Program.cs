using System;

namespace Ejercicio4_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            double GradosCelsius, GradosFahrenheit=0;

            Console.Write("Ingrese la cantidad de grado en celsius: ");
            entrada = Console.ReadLine();
            GradosCelsius = Convert.ToDouble(entrada);
            GradosFahrenheit = GradosCelsius * 9 / 5 + 32;
            Console.WriteLine("\nEl resultado en Grados Fahrenheit es : {0}", GradosFahrenheit);
        }
    }
}
