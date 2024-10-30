using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //Geriye değer döndürmeyen metotlar
            //Customer --> Listele, ekle, sil, güncelle

            // Geriye Değer Döndürmeyen Metotlar
            // Customer => Listele, ekle, sil, güncelle
            // Void

            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ayşe Yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");
            }

            CustomerList();

            void Sum()
            {
                int x = 3;
                int y = 9;
                int z = x + y;
                Console.Write("X + Y = " + z);
            }
            Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar
            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }

            WriteMethod("\nAhmet Domurcuk");

            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri: " + name + " " + surName);
            }

            CustomerCard("Cem", "Demir");
            CustomerCard("Elif", "Aksoy");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            void Sum2(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }

            Sum2(90, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar
            string CustomerName()
            {
                return "Buse Kara";
            }
            CustomerName();

            string StudentCard()
            {
                string name = "Zeynep";
                string surname = "Yılmaz";
                return name + " " + surname;
            }

            Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar
            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
                return cardInfo;
            }

            Console.WriteLine(CountryCard("Japonya", "Tokyo", "Beyaz-Kırmızı"));

            string a, b, c;
            Console.Write("\nÜlke Adını Giriniz: ");
            a = Console.ReadLine();

            Console.Write("\nBaşkenti Giriniz: ");
            b = Console.ReadLine();

            Console.Write("\nBayrak Rengini Giriniz: ");
            c = Console.ReadLine();

            Console.WriteLine(CountryCard(a,b,c));
            Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı - Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            int Sum3(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }

            Console.WriteLine(Sum3(10, 15));
            Console.WriteLine(Sum3(23, 47));
            Console.WriteLine(Sum3(32, 58));
            Console.WriteLine(Sum3(12, 14));

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return $"{student} isimli öğrenci sınavı geçti" + "Ortalama: " + result;
                }
                else
                {
                    return $"{student} isimli öğrenci başarısız oldu" + "Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Can", 48, 62, 77));
            Console.WriteLine(ExamResult("Ece", 34, 59, 45));
            #endregion
            Console.Read();
        }
    }
}
