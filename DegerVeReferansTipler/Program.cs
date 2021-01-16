using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            int say3 = new int();
            int say4 = new int();
            int sayi3 = 10;
            int sayi4 = 30;
            //sdhgjhjgfthfghfg
            sayi3 = sayi4;
            sayi4 = 65;
            Console.WriteLine(sayi3);

        }
    }
}
