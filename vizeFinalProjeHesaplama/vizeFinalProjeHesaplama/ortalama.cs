using System;

namespace vizeFinalProjeHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double vize, final, proje, ortalama;
            Console.Write("Vize notunu giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje notunu giriniz: ");
            proje = Convert.ToDouble(Console.ReadLine());


            ortalama = Convert.ToDouble(vize * 30 / 100) + (final * 40 / 100) + (proje * 30 / 100);

            Console.WriteLine("Ortalamanız = {0}", ortalama);

            if (ortalama>=60)
            {
                Console.WriteLine("Ortalamanız:" + ortalama.ToString()+ " "+"Geçtiniz");
            }
            else if (ortalama<=60 && ortalama>=40)
            {
                Console.WriteLine("Ortalamanız:" + ortalama.ToString() +  " "+ "Bütünleme sınavına girmeniz gerekiyor");
            }
            else if(ortalama<40)
            {
                Console.WriteLine("Ortalamanız:" + ortalama.ToString() + " " + "Dersten kaldınız");
            }
                


            Console.ReadKey();
        }
    }
}
