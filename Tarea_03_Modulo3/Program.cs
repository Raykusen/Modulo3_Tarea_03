using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_03_Modulo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pide al usuario su nombre
            Console.WriteLine("¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();

            // Asegura que el usuario escribió algo
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                // Obtiene la inicial
                char inicial = nombre.Trim()[0];
                Console.WriteLine($"Tu inicial es: {inicial}");
            }
            else
            {
                Console.WriteLine("No ingresaste un nombre válido.");
            }

            Console.ReadKey();
        }
    }
}
