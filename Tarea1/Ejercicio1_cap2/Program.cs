using System;

namespace Ejercicio1_cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            int NumeroLados,Longitud,resultado=0;

            Console.Write("Ingrese el numero de lados del poligono: ");
            entrada = Console.ReadLine();
            NumeroLados = Convert.ToInt32(entrada);

            Console.Write("Ingrese la longitud de un lado del poligono: ");
            entrada = Console.ReadLine();
            Longitud = Convert.ToInt32(entrada);
            resultado = NumeroLados * Longitud;
            Console.WriteLine("\nEl resultado es: {0}",resultado);
        }
    }
}
