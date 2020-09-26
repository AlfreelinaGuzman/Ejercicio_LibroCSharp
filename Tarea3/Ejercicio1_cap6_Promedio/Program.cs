using System;
using System.Collections;

namespace Ejercicio1_cap6_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
             String dato = " ";
            int[][] nota = new int[2][];
            nota[0] = new int[2];
            nota[1] = new int[2];
            int promedio, veces = 4, i = 0, suma = 0, o = 0, x = 0;

            Console.WriteLine("Promadios\n");

            do
            {
                Console.Write("Digite la nota {0}: ", i + 1);
                dato = Console.ReadLine();
                if (i == 2)
                {
                    o = 1;
                    i = 0;
                }
                nota[o][i] = Convert.ToInt32(dato);

                suma += nota[o][i];

                i++;
                x++;

            } while (x < veces);

            promedio = suma / veces;

            Console.WriteLine("El promedio es: {0}.", promedio);
        }
        }
    }