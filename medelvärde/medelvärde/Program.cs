using System;

namespace medelvärde
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("skriv ett tal");
            float tal1 = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett till tal");
            float tal2 = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett sista tal");
            float tal3 = float.Parse(Console.ReadLine());
            Console.WriteLine("medelvärdet är: " + BeräknaMedel (tal1, tal2, tal3));
            
        }
        public static float BeräknaMedel(float tal1, float tal2, float tal3)
        {
            return (tal1 + tal2 + tal3) / 3;
            
        }

    }
}
