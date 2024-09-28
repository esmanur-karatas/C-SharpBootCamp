using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları 
            Console.Write("Merhaba Dünya"); //Consola Merhaba Dünya yazısını yazdırır.
            Console.WriteLine(" Merhaba Dünya"); //Ekrana yazı yazdırır ve imleci bir alt satıra getirir.
            Console.WriteLine();
            Console.WriteLine("***** Yemek Tarifleri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Tatlılar");
            Console.WriteLine("3-Ana Yememkler");
            Console.WriteLine("4-Soğuk Başlangıçlar");
            Console.WriteLine("5-Ara Yememkler");
            Console.WriteLine("6-Soğuk İçecekler");
            Console.WriteLine("7-Sıcak İçecekler");
            Console.WriteLine("8-Salatalar");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Tarifleri *****");
            #endregion

            #region String Değişkenler
            //string değişkeni

            string name;//değişkenin türünü belirledik ve değişkenin adını belirledik. yani name değşkeni string türünde bir değişken.
            name = "Esmanur"; // name değişkenine bir değer atadık.
            Console.WriteLine(name); //değişkeni consola yazdırdık. 
            Console.WriteLine(); //Bir satır boşluk bırakmak için kullandık.
                                 //
            //Değişkenlerin isimlendirilmesi
            //1.CamelCase : costumerName. birinci harf küçük ikinci harf büyük
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city; //aynı türde değişken adlarını virgülle ayırarak da birden fazla ekleyebiliriz.

            //Değişkenlere değer ataması: 
            customerName = "Ahmet";
            customerSurname = "Domurcuk";
            customerPhone = "0555 5555 555";
            customerEmail = "ahmetdomurcuk@gmail.com";
            district = "Merkez";
            city = "Elazığ";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("Adı:" + customerName + "\nSoyadı: " + customerSurname + "\nTelefon: " + customerPhone + "\nEmail: " + customerEmail + "\nİlçe: " + district + "\nŞehir: " + city);
            // artı koymazsak hata verir değişkenlerle tırnak içinde ki metinleri birleştirir. \n ile de alt satıra geçeriz.
            Console.WriteLine();

            //ikinci değişken adlandırma kodlar yukarıdan aşağıya işlediği için önce ilk tanımladığımız değişkenleri ekrana yazdırır sonra da bunu:
            customerName = "Esmanur";
            customerSurname = "Karataş";
            customerPhone = "0555 5555 555";
            customerEmail = "esmanurkaratas@gmail.com";
            district = "Merkez";
            city = "Elazığ";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("Adı:" + customerName + "\nSoyadı: " + customerSurname + "\nTelefon: " + customerPhone + "\nEmail: " + customerEmail + "\nİlçe: " + district + "\nŞehir: " + city);
            // artı koymazsak hata verir değişkenlerle tırnak içinde ki metinleri birleştirir. \n ile de alt satıra geçeriz.
            Console.WriteLine();
            #endregion

            #region İnteger Değişkenler (int)
            int number;
            number = 30;
            Console.WriteLine(number);
            
            //değşkenler bu şekilde de tanımlanabilir.
            int number2 = 77;
            Console.WriteLine(number2);

            int sonuc = number2 - number;

            //değişkenleri toplama, çıkarma, çarpma, bölme.
            Console.WriteLine("Toplama: " + number + number2);
            Console.WriteLine("Çıkarma: " + sonuc);
            Console.WriteLine("Çarpma: " + number * number2);
            Console.WriteLine("Bölme: " + number2 / number);
            Console.WriteLine();
            Console.WriteLine();
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("----- Restorant Menü Fiyatı -----");
            Console.WriteLine();
            Console.WriteLine("-----Kola:      " + cokePrice + "  TL");
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Su:        " + waterPrice + "  TL");
            Console.WriteLine("-----Fries:     " + friesPrice + "  TL");
            Console.WriteLine("-----Pizza:     " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata:  " + lemonadePrice + "  TL");
            Console.WriteLine();
            Console.WriteLine("----- Restorant Menü Fiyatı -----");
            Console.WriteLine();

            int hamburgerCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int cokeCount;

            int totalHamburgerPrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int totalCokePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 2;
            pizzaCount = 1;
            lemonadeCount = 4;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı:      " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı:        " + totalWaterPrice + " TL");
            Console.WriteLine("Fries Tutarı:     " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı:     " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı:  " + totalLemonadePrice + " TL");
            Console.WriteLine();
            int totalprice = totalLemonadePrice + totalHamburgerPrice + totalFriesPrice + totalPizzaPrice + totalWaterPrice + totalCokePrice;
            Console.WriteLine("Toplam Ödeme Tutarı: " + totalprice + " TL");
            Console.WriteLine("-----------------------------------");
            #endregion
            Console.Read();//açılan console ekranını sabit tutmak içi kullanılır.
            
        }
    }
}
