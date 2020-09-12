using System;

namespace Ejercicio5_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            float Dolar, Euro, Conversion;

            Console.Write("Ingrese el valor del dolar en Euro: ");
            Conversion = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese los dolares a convertir: ");
            Dolar = Convert.ToSingle(Console.ReadLine());

            Euro = Dolar * Conversion;

            Console.WriteLine("El resultado es: {0} Euros", Euro);
        }
    }
}
