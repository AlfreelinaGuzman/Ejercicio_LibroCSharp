using System;

namespace Ejercicio4_cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero del 1 al 7: ");
            numero = Convert.ToInt32(Console.ReadLine());
            switch(numero)
            {
                case 1:
                    Console.WriteLine("Es Lunes");
                    break;
                case 2:
                    Console.WriteLine("Es Martes");
                    break;
                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Es Viernes");
                    break;
                case 6:
                    Console.WriteLine("Es Sabado");
                    break;
                case 7:
                    Console.WriteLine("Es Domingo");
                    break;
                default:
                    Console.WriteLine("Error: Valor no valido");
                    break;
            }
        }
    }
}
