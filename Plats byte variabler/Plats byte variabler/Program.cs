using System;

namespace Plats_byte_variabler
{
    class Program
    {
        public static void Main()
        {
            int a = 10, b = 20;
            BytPlats(ref a,ref b);
            Console.WriteLine(a + " " + b);
        }

        public static void BytPlats(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
