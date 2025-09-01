using System;
using Microsoft.VisualBasic;

namespace donguler
{
    class Program
    {
        static void Main(String[] args)
        {
            // ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            Console.Write("Bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır. 
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tektoplam += i;
                }
                else
                {
                    cifttoplam += i;
                }
            }
            Console.WriteLine("tek toplam: " + tektoplam);
            Console.WriteLine("çift toplam: " + cifttoplam);

            //break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}