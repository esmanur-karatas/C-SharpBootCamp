using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //for(x;y;z) x=> başlangıç y=> bitiş z=> artış değerini tutar.
            //int i;
            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int a= 1; a<=20; a++)
            //{
            //    Console.WriteLine(a);
            //}

            //for (int b = 1; b <= 20; b+=3)
            //{
            //    Console.WriteLine(b);
            //}

            //Console.Write("\nLütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int c = 1; c <= finishValue; c++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int a = 1; a <= 10; a++)
            //{
            //    totalvalue += a;
            //}

            //Console.WriteLine(totalvalue);

            //int totalValue1 = 0;

            //for (int b = 1; b < 20; b++)
            //{
            //    if (b % 2 == 0)
            //    {
            //        totalValue1 += b;
            //        Console.WriteLine(b);
            //    }
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue1);


            //int count = 0;
            //for (int c = 1; c <= 50; c++)
            //{
            //    if (c % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //int bacterium = 1;
            //for (int d = 1; d <= 24; d++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(d + ". Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü
            //While(şart)
            //{
            //    işlemler
            //}

            //int e = 1;
            //while (e <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    e++;
            //}

            //int f = 1;
            //while (f <= 10)
            //{
            //    if (f % 3 == 0)
            //    {
            //        Console.WriteLine(f);
            //    }
            //    f++;
            //}


            //int g = 1;
            //int sum = 0;

            //while (g <= 10)
            //{
            //    sum += g;
            //    g++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu
            //klavyeden girilen 3 basamaklı sayının basamak sayılarının toplamını alınız.

            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            sum = ones + tens + hundreds;

            Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
