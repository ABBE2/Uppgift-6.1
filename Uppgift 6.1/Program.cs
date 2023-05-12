using System;
using System.Security.Cryptography.X509Certificates;

namespace uppgift_6._1
{
    class program
    {
        static int Addera(int tal1, int tal2, int tal3)
        {
            int x = tal1 + tal2 + tal3;
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tre heltal.");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int svar = Addera(x, y, z);
            Console.WriteLine();
            Console.WriteLine("Adderar man alla talen med varandra får man:" + x + "+" + y + "+" + z + "=" + svar);
        }
    }
}