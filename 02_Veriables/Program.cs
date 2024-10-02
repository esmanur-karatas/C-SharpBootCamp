using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region double veri tipi
            double number;
            number = 4.85;
            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine("***** Fiyat Listesi *****");

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 40.90;
            strawberryPrice = 34.78;
            potatoPrice = 9.67;
            tomatoPrice =7.80;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("*Elmanın Fiyatı:      " + applePrice + " ₺"
                +           "\n*Portakalın Fiyatı:   " + orangePrice + " ₺" +
                            "\n*Çileğin Fiyatı:      " + strawberryPrice + " ₺" +
                            "\n*Patatesin Fiyatı:    " + potatoPrice + " ₺" +
                            "\n*Domatesin Fiyatı:    " + tomatoPrice + "  ₺" + "\n\n\n");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.234;
            orangeGram = 2.324;
            strawberryGram = 4.342;
            potatoGram = 23.245;
            tomatoGram = 21.234;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatootalPrice = tomatoPrice * tomatoGram;
            Console.WriteLine("*Alınan Ürün Elma :      " + "Birim Fiyatı:  " + applePrice +         "    Gramaj: " + appleGram +     "      Elmanın Toplam Fiyatı: " + appleTotalPrice  
                         + "\n*Alınan Ürün Portakal:   " + "Birim Fiyatı:  " +orangePrice +          "    Gramaj: " +orangeGram +     "      Portakalın Toplam Fiyatı: " + orangeTotalPrice + " ₺" +
                            "\n*Alınan Ürün Çilek:      " + "Birim Fiyatı:  " + strawberryPrice +    "   Gramaj: " +strawberryGram + "       Çileğin Toplam Fiyatı: " + strawberryTotalPrice + " ₺" +
                            "\n*Alınan Ürün Patates:    " + "Birim Fiyatı:  " +potatoPrice +         "    Gramaj: " +potatoGram +     "      Patetesin Toplam Fiyatı: " + potatoTotalPrice + " ₺" +
                            "\n*Alınan Ürün Domates:    " + "Birim Fiyatı:  " +tomatoPrice +         "   Gramaj: " +tomatoGram +     "       Domatesin Toplam Fiyatı: " + tomatootalPrice + "  ₺" + "\n");

            double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatootalPrice;
            Console.WriteLine("Toplam Fiyat:                " + totalPrice + " ₺");
            #endregion

            #region Char Değişkenler
            char symbol;
            symbol = 'b';
            Console.WriteLine("\n\n\n\n\n"+ symbol);
            #endregion

            #region Klavyeden Veri Girişi
            Console.WriteLine("\n\n\n\n\n***** Csharp Hava Yolları Yolcu Bilgisi *****");

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu Tc si: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("\n\n------------------");
            Console.WriteLine("\n\nYolcu Tc'si :  " + passengerIdentityNumber + "   Yolcu Ad Soyad:  "  + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " - " + passengerAge);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            int shoePrice, computerPrice, chairPrice, tvPrice;

            shoePrice = 1000;
            computerPrice = 40000;
            chairPrice = 60;
            tvPrice = 30000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Aldığınız TV Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice1 = shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvCount;

            Console.Write("\n\n\nToplam Ödemeniz Gereken Tutar: " + totalPrice1);
            #endregion

            #region Klavyeden Ondalık Sayı İşlemleri
            double exam1, exam2, exam3, result;
            Console.Write("\n\n\n\nLütfen 1. Sınav Notunuzu Giriniz: ");
            exam1= double.Parse(Console.ReadLine());

            Console.Write("\n\n\n\nLütfen 2. Sınav Notunuzu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("\n\n\n\nLütfen 3. Sınav Notunuzu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("\n\n\n\nSınav Ortalamanız: " + result);
            #endregion

            #region Klavyeden Char Girişi
            char gender;
            Console.WriteLine("\n\n\n\nLütfen cinsiyet sseçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet :  " + gender);

            #endregion
            Console.Read();
        }
    }
}
