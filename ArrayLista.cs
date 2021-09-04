using System;
using System.Collections.Generic;

namespace ArrayLista
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Que productos se compraran en el supermercado?");
            var groceries = new List<String>();
            groceries.Add(Console.ReadLine());
            groceries.Add(Console.ReadLine());
            groceries.Add(Console.ReadLine());
            groceries.Add(Console.ReadLine());
            groceries.Add(Console.ReadLine());

            Console.WriteLine("La lista de compras es:");

            foreach (var product in groceries)
                Console.WriteLine(product);

            Console.ReadKey();
        }
    }
}
