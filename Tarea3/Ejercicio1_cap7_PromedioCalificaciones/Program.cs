using System;
using System.Collections;

namespace Ejercicio1_cap7_PromedioCalificaciones
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string c, cali;
            int calificacion, cantidad = 0;
            float suma = 0.0f, promedio = 0.0f, min = 0.0f, max = 0.0f;

            Console.Write("Introduzca la cantidad de alumnos: ");
            c = Console.ReadLine();
            cantidad = Convert.ToInt32(c);
            ArrayList alCalificacion = new ArrayList(cantidad);

            for (int n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Introduzca la calificación: ");
                cali = Console.ReadLine();
                calificacion = Convert.ToInt32(cali);
                alCalificacion.Add(calificacion);
                suma += calificacion;
                if (n == 0)
                {
                    max = calificacion;
                    min = calificacion;
                }
                if (calificacion < min)
                    min = calificacion;
                if (calificacion > max)
                    max = calificacion;
            }
            promedio = suma / cantidad;

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificación mínima es: {0}", min);
            Console.WriteLine("La calificación máxima es: {0}", max);
        }
    }
}