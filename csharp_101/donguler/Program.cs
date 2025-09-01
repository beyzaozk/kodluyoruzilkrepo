using System;
using Microsoft.VisualBasic;

namespace donguler
{
    class Program
    {
        static void Main(String[] args)
        {
            // for - loop

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

            // while - foreach

            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayop console a yazdıran program.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac1 = 1;
            int toplam = 0;
            while (sayac1 <= sayi)
            {
                toplam += sayac1;
                sayac1++;
            }
            Console.WriteLine(toplam / sayi);

            // a dan z ye kadar tüm harfleri console a yazdır.
            char charachter = 'a';
            while (charachter <= 'z')
            {
                Console.Write(charachter);
                charachter++;
            }

            // foreach
            string[] arabalar = { "bmw", "ford", "toyota", "nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}