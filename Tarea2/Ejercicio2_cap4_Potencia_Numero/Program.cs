using System;

namespace Ejercicio2_cap4_Potencia_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero, resultado;
            int potencia;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToSingle(Console.ReadLine());
            resultado = numero;

            Console.Write("Ingrese la potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            for(;potencia > 1;potencia--)
            {
                resultado *= numero;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}