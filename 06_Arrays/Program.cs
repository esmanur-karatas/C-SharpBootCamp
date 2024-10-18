using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region string int Arrays

            string[] colors = new string[4];
            colors[0] = "Kırmızı";
            colors[1] = " Beyaz";
            colors[2] = "Siyah";
            colors[3] = "Turuncu";

            Console.WriteLine(colors[2]);

            string[] cities = new string[5];
            cities[0] = "Elazığ";
            cities[1] = "Malatya";
            cities[2] = "Ankara";
            cities[3] = "Antalya";
            cities[4] = "İstanbul";
            Console.WriteLine(cities[2]);

            int[] numbers = new int[10];
            numbers[0] = 6;
            numbers[1] = 7;
            numbers[5] = 3243;
            numbers[6] = 893930;
            numbers[7] = 483;
            Console.WriteLine(numbers[5]);

            string[] cities2 = { "Ankara", "Erzincan", "Bursa", "Balıkesir" };
            Console.WriteLine(cities2[3]);
            #endregion

            #region Dizideki tüm elemanları Listeleme
            string[] colors2 = { "beyaz", "kahverengi", "turuncu", "yeşil", "siyah" };
            for (int i = 0; i < colors2.Length; i++)
            {
                Console.WriteLine(colors2[i]);
            }

            int[] numbers2 = { 3, 4, 24, 546, 54567, 432, 234, 536, 342, 2121, 234 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers2[i] <= 200)
                {
                    Console.WriteLine(numbers2[i]);
                }
            }

            char[] symbol = { 'A', 'a', 'b', 'c', 'd' };
            for (int i = 0; i < symbol.Length; i++)
            {
                Console.WriteLine(symbol[i]);
            }

            int[] myArray = { 3, 4, 24, 546, 54567, 432, 234, 536, 342, 2121, 234 };
            int maxNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları
            string[] person = { "Ayşe", "Ahmet", "Domurcuk", "Şevval", "Feyza" };
            Console.WriteLine(person.Length);
            int index = Array.IndexOf(person, "Ahmet");
            Console.WriteLine(index);

            int[] numbers3 = { 3, 4, 24, 546, 54567, 432, 234, 536, 342, 2121, 234 };
            Array.Sort(numbers3);
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.WriteLine(numbers3[i]);
            }

            int[] numbers4 = { 3, 4, 24, 546, 54567, 432, 234, 536, 342, 2121, 234 };
            Array.Reverse(numbers4);
            for (int i = 0; i < numbers4.Length; i++)
            {
                Console.WriteLine(numbers4[i]);
            }
            Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers4.Max() + "\nDizinin En Küçük Elemanı: " + numbers4.Min());
            #endregion

            #region Kullanıcıdan Değer Alma
            string[] country = new string[6];
            for (int i = 0; i < country.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
                country[i] = Console.ReadLine();
            }

            Console.WriteLine("\n-------------------------------");
            for (int i = 0; i < country.Length; i++)
            {
                Console.WriteLine(country[i]);
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine("\nÇift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("\nTek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();


        }
    }
}
