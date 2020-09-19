using System;

namespace Ejercicio5_cap4_Promedio_Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, cantidad, promedio, mayor, menor;

            Console.Write("Ingrese la cantidad de personas a ingresar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Edad 1: ");
            edad = Convert.ToInt32(Console.ReadLine());
            promedio = edad;
            //asignar la primera edad como mayor, menor
            mayor = edad;
            menor = edad;

            for(int i = 2; i <= cantidad; i++)
            {
                Console.Write("Edad {0}: ", i);
                edad = Convert.ToInt32(Console.ReadLine());

                promedio += edad;

                if (edad > mayor)
                    mayor = edad;
                else if (edad < menor)
                    menor = edad;
            }

            promedio /= cantidad;

            Console.WriteLine("El promedio es: {0} \n" +
                "El mayor es: {1}\n" +
                "El menor es: {2}", promedio, mayor, menor);

        }
    }
}