using System;

namespace Arraywithsort
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Con quienes vives en tu hogar?");

            var family = new string[] { "Jose. Papá", "Melissa. Mamá", "Johep", "Drake. Mascota", "Mai. Mascota", "Perla. Mascota" };

            foreach (var member in family)
                Console.WriteLine(member);

            Console.ReadKey();
        }
    }
}
