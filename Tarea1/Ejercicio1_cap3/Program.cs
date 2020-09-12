using System;

namespace Ejercicio1_cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
        }
    }
}
