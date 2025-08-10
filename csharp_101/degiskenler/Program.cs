using System;

namespace degiskenler
{
    class Program
    {
        public static void Main(string[] args)
        {

            byte b = 5; //1 byte yer kaplar
            sbyte c = 5; //bellekte 1 byte yer kaplar

            short s = 5; //bellekte 2 byte yer kaplar
            ushort us = 5; //2 byte yer kaplar.

            Int16 i16 = 2; // 2 byte yer kaplar.
            int i = 2; //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; // 8 byte
            uint ui = 2; // 4 byte

            long l = 4; // 8 byte
            ulong ul = 4; //8 byte

            // reel sayılar için
            float f = 4; // 4 byte
            double d = 4; // 8 byte
            decimal de = 5; //16 byte

            char ch = 'b'; // 2 byte
            string st = "beyza"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler
            string str1 = string.Empty;
            str1 = "beyza";
            string ad = "beyza";
            string soyad = "özkan";
            string tamisim = ad + " " + soyad;

            //integer tanımlama şekilleri
            int i1 = 5;
            int i2 = 3;
            int i3 = i1 * i2;

            //boolean
            bool bool1 = 10 < 2;

            //değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yenid = str20 + int20.ToString();
            Console.WriteLine(yenid); // çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktısı 40 

            int int22 = int20 + int.Parse(str20); // çıktısı 40

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime); // çıktısı 10.08.2025

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour); // çıktısı 13:38
        }
    }
}