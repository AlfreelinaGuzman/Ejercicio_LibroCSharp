using System;

namespace Ejercicio3_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            double grados, resultado=0;
            double Pi = 3.1416;

            Console.Write("Ingrese los grados a convertir: ");
            entrada = Console.ReadLine();
            grados = Convert.ToDouble(entrada);

            resultado = grados * Pi / 180;

            Console.WriteLine("\nEl Resultado es: {0} radianes", resultado);
        }
    }
}
