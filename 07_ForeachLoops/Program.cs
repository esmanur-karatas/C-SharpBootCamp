using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    public class Program
    { 
        static void Main(string[] args)
        {
            #region foreach döngüsü
            //Foreach (1;2;3;4)
            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi
            string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            int[] numbers = { 45, 67, 348, 73497, 23, 231, 534, 234 };
            foreach (int numberss in numbers)
            {
                Console.WriteLine(numbers);
            }

            foreach (int numberss in numbers)
            {
                Console.Write(numberss % 2 == 0);
            }

            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);

            List<int> number = new List<int>()
            {
                1,2,3,4,5,6
            };
            //Console.WriteLine(number);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }

            string word = "merhaba";
            foreach(char c in word)
            {
                Console.WriteLine(c);
            }

            #endregion

            #region Örnek Sınav sistemi uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Notları topluyoruz.
                }
                Console.WriteLine() ;
                studentExamAvg[i] = totalExamResult / 3;
            }
            // Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                // Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("----------------------------------------");
            }

            #endregion
        }
    }
}
