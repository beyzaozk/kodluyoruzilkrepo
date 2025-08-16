﻿using System;

namespace karar_yapilari
{
    class Program
    {
        public static void Main(string[] args)
        {
            // if - else
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("günaydın!");
            }
            else if (time <= 18)
            {
                Console.WriteLine("iyi günler!");
            }
            else
                Console.WriteLine("iyi geceler!");

            string sonuc = time <= 18 ? "iyi günler!" : "iyi geceler!";
            sonuc = time >= 6 && time < 11 ? "günaydın!" : time <= 18 ? "iyi günler!" : "iyi geceler!";
            Console.WriteLine(sonuc);

            // switch case
            int month = DateTime.Now.Month;

            //expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Haziran Ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Temmuz Ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Eylül Ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Ağustos Ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi.");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız!");
                    break;    
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız!");
                    break;    
                default:
                    break;
            }

        }
    }
}