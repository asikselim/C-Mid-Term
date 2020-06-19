using System;

namespace piramitCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, boşluklar;

            while (true)//sonsuz döngü için
            {
                Console.Write("1-9 arası bir sayı giriniz : ");

                sayi = Convert.ToInt32(Console.ReadLine());

                boşluklar = sayi - 1;

                for (int i = 1; i <= sayi; i++)
                {
                    for (boşluklar = 1; boşluklar <= (sayi - i); boşluklar++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }

                    for (int k = (i - 1); k >= 1; k--)
                    {
                        Console.Write(k);
                    }

                    Console.WriteLine();
                    

                }
            }
        }
    }
}