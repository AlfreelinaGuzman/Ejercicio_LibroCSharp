using System;
using System.Collections;

namespace Ejercicio5_cap7_AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Agenda = new Hashtable();
            string nomb, num, cantidad,m;
            int cant, menu;
            Console.WriteLine("Agenda");
            do
            {
                Console.WriteLine("Seleccione una opcion: \n1-)Agendar Contactos \n2-)Lista de Contactos");
                m = Console.ReadLine();

                menu = Convert.ToInt32(m);

                switch (menu)
                {
                    case 1:

                        Console.Write("Introduzca la cantidad de contactos a agendar: ");
                        cantidad = Console.ReadLine();
                        cant = Convert.ToInt32(cantidad);

                        for (int i = 0; i < cant; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Agenda");
                            Console.WriteLine("Introduzca el nombre de el contacto: ");
                            nomb = Console.ReadLine();
                            Console.WriteLine("Digite telefono de {0}:", nomb);
                            num = Console.ReadLine();
                            Agenda.Add(nomb, num);
                            Console.WriteLine("Contactos Agendados...\n");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Usted agregó: \n");
                        foreach (DictionaryEntry datos in Agenda)
                            Console.WriteLine("{0}: {1}", datos.Key, datos.Value);

                        break;
                }


            } while(menu<2);
           

        }
    }
}
