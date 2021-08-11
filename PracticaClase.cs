using System;

namespace EjerciciosPracticos2
{
    class Program
    {
        static void Main()
        {
            //nombre del estudiante
            Console.WriteLine("Nombre del estudiante:");
            string name = Console.ReadLine();

            //notas variables
            Console.WriteLine("Ingreso de notas");
            int[] notas = new int[4];
            int p;
            for (int i = 1; i < notas.Length; i++)
            {
                Console.Write("Escriba la nota {0}:", i);
                notas[i] =
                    Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"{name}, obtuvo las siguientes notas:");

            for (int i = 1; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i, notas[i]);
            }

            //Promedio de notas
            p = (notas[1] + notas[2] + notas[3]) / 3;
            Console.WriteLine($"Nota promedio: {p}");

            //Mejor nota
            Console.WriteLine("Revisión de notas:");
            if (notas[1] >= 7 || notas[2] >= 7 || notas[3] >=7)
            {
                for (int i = 1; i < notas.Length; i++)
                {
                    Console.WriteLine("Nota {0}: {1}", i, notas[i]);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.ReadKey();
            }
        }
    }
}
