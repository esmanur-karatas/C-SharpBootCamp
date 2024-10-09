using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region if 
            Console.Write("Lütfen şifrenizi giriniz:");
            string password;
            password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifreniz doğru");
            }
            else
            {
                Console.WriteLine("Şifreniz yanlış");
            }

            string capital, country;
            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
            {
                Console.WriteLine("VERİLER DOĞRULANDI");
            }
            else
            {
                Console.WriteLine("HATALI BİLGİ!");
            }

            int number;
            Console.Write("Sayıyı Giriniz: ");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Sayı Doğruu!");
            }
            else
            {
                Console.WriteLine("Hatalı sayı girdiniz!");
            }

            int exam1, exam2, exam3, average;
            string result;
            Console.Write("1. sınav notunuzu giriniz: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("2. sınav notunuzu giriniz: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("3. sınav notunuzu giriniz: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavlarınızın not ortalaması: " + average);

            if (average > 0 & average <= 50)
            {
                result = "Maalesef Kaldınız";
            }
            if (average > 50 & average <= 70)
            {
                result = "Orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "İyi";
            }
            if (average > 84 & average <= 100)
            {
                result = "Çok İyi";
            }
            else
            {
                result = "Ortalamanız 100 den büyük 0 dan küçük olamaz. ";
            }

            Console.WriteLine(result);


            string city;
            Console.Write("Lütfen şehir giriniz: ");
            city = Console.ReadLine();

            if (city == "adana" | city == "ankara" | city == "elazığ" | city == "malatya")
            {
                Console.WriteLine("Aradığınız şehir bulundu");
            }
            else
            {
                Console.WriteLine("Arama sonucu bulunamadı, geçerli bir şehir ismi giriniz!");
            }


            Console.Write("Lütfen kullanıcı adı giriniz: ");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.Write("Kullanıcı adı hatalı! ");
            }
            else
            {
                Console.Write("Hoş geldiniz");
            }

            #endregion

            #region mod işlemleri

            int number2;
            number2 = 30;
            int result2 = number % 5;
            Console.WriteLine(result2);

            Console.Write("Lütfen 1. sayıyı giriniz: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı giriniz: ");
            int number4 = int.Parse(Console.ReadLine());

            int result3 = number3 % number4;

            Console.Write("1. Sayının 2. sayıya bölümünden kalan: " + result);


            Console.Write("Lütfen sayıyı giriniz: ");
            int number5 = int.Parse(Console.ReadLine());

            if (number5 % 2 == 0)
            {
                Console.Write("Sayı Çifttir");
            }
            else
            {
                Console.Write("Sayı Tektir");
            }

            #endregion

            #region Char değişkenler ile karar yapıları 

            char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' || team == 'G')
            {
                Console.Write("Galatasaray");
            }

            if (team == 'f' || team == 'F')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'b' || team == 'B')
            {
                Console.Write("Beşiktaş");
            }
            if (team == 't' || team == 'T')
            {
                Console.Write("Trabzon");
            }

            #endregion

            #region Örnek proje
            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            string menuItem;

            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------------Ana Yemekler---------------");
                Console.WriteLine();
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Domatesli Makarna");
                Console.WriteLine("6-İçli Köfte");
                Console.WriteLine("7-Çiğköfte");
                Console.WriteLine("8-Lagmacun");
                Console.WriteLine("---------------Ana Yemekler---------------");
                Console.WriteLine();
            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------------Çorbalar---------------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine("3-Tarhana Çorbası");
                Console.WriteLine("4-Domates Çorbası");
                Console.WriteLine("5-Karışık Sebze Çorbası");
                Console.WriteLine("---------------Çorbalar---------------");
                Console.WriteLine();
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------------Pizzalar---------------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margaritha");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("---------------Pizzalar---------------");
                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------------İçecekler---------------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("4-Şalgam");
                Console.WriteLine("5-Gazoz");
                Console.WriteLine("---------------İçecekler---------------");
                Console.WriteLine();
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("---------------Tatlılar---------------");
                Console.WriteLine();
                Console.WriteLine("1-Baklava");
                Console.WriteLine("2-Künefe");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("4-Kazandibi");
                Console.WriteLine("5-Muhallebi");
                Console.WriteLine("---------------Tatlılar---------------");
                Console.WriteLine();
            }

            #endregion

            #region Switch Case
            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            string menuItem2;

            Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            menuItem2 = Console.ReadLine();

            switch (menuItem2)
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("---------------Ana Yemekler---------------");
                    Console.WriteLine();
                    Console.WriteLine("1-Köri Soslu Tavuk");
                    Console.WriteLine("2-Kızartma Tabağı");
                    Console.WriteLine("3-Fasulye Pilav");
                    Console.WriteLine("4-Fırında Somon");
                    Console.WriteLine("5-Domatesli Makarna");
                    Console.WriteLine("6-İçli Köfte");
                    Console.WriteLine("7-Çiğköfte");
                    Console.WriteLine("8-Lahmacun");
                    Console.WriteLine("---------------Ana Yemekler---------------");
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine("---------------Çorbalar---------------");
                    Console.WriteLine();
                    Console.WriteLine("1-Mercimek Çorbası");
                    Console.WriteLine("2-Ezogelin Çorbası");
                    Console.WriteLine("3-Tarhana Çorbası");
                    Console.WriteLine("4-Domates Çorbası");
                    Console.WriteLine("5-Karışık Sebze Çorbası");
                    Console.WriteLine("---------------Çorbalar---------------");
                    Console.WriteLine();
                    break;

                case "3":
                    Console.WriteLine();
                    Console.WriteLine("---------------Pizzalar---------------");
                    Console.WriteLine();
                    Console.WriteLine("1-Akdeniz Pizza");
                    Console.WriteLine("2-Margaritha");
                    Console.WriteLine("3-Tavuklu Pizza");
                    Console.WriteLine("---------------Pizzalar---------------");
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine();
                    Console.WriteLine("---------------İçecekler---------------");
                    Console.WriteLine();
                    Console.WriteLine("1-Kola");
                    Console.WriteLine("2-Ayran");
                    Console.WriteLine("3-Su");
                    Console.WriteLine("4-Şalgam");
                    Console.WriteLine("5-Gazoz");
                    Console.WriteLine("---------------İçecekler---------------");
                    Console.WriteLine();
                    break;

                case "5":
                    Console.WriteLine();
                    Console.WriteLine("---------------Tatlılar---------------");
                    Console.WriteLine();
                    Console.WriteLine("1-Baklava");
                    Console.WriteLine("2-Künefe");
                    Console.WriteLine("3-Sütlaç");
                    Console.WriteLine("4-Kazandibi");
                    Console.WriteLine("5-Muhallebi");
                    Console.WriteLine("---------------Tatlılar---------------");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                    break;
            }

            Console.Write("AY DEĞERİ GİRİNİZ(SAYI)");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağostus"); break;
                case 9: Console.Write("Eylül"); break;
                case 10: Console.Write("Ekim"); break;
                case 11: Console.Write("Kasım"); break;
                case 12: Console.Write("Aralık"); break;
                default: Console.WriteLine("yanlış değer girdiniz."); break;
            }

            #endregion

            #region Switch case hesap makinesi
            double num1, num2, res;
            string operation;

            Console.WriteLine("****** Hesap Makinesi ******");
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı giriniz: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("+ : Toplama");
            Console.WriteLine("- : Çıkarma");
            Console.WriteLine("* : Çarpma");
            Console.WriteLine("/ : Bölme");
            Console.Write("İşlem seçiniz: ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                        Console.WriteLine("Sonuç: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayı 0'a bölünemez!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi!");
                    break;
            }
            #endregion

            Console.Read();

        }
    }
}