using System;

namespace Ejercicio4_cap5_factorial
{
    class Program
    {
        //Ejercicio_5_4
     
        static void Main(string[] args)
        {
            String numero;
            int num,resultado = 0;

            Console.WriteLine("Introduzca el Numero: ");
            numero = Console.ReadLine();

            num = Convert.ToInt32(numero);

            resultado = Factorial(num);

            Console.WriteLine("Resultado: {0}", resultado);
        }

        public static int Factorial(int a)
        {
            int numi = 1, numf = 2, i = 1;

            do
            {

                numi = numi * numf;
                numf = numf + 1;
                i++;

        } while (i < a);

            return  numi;
        }
    }
}