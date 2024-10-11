using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Alt Alta 10 tane yıldız oluturma
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            #endregion

            #region Yan yana 10 tane yıldız oluşturma
            for (int j= 1; j <= 10; j++)
            {
                Console.Write("*");
            }
            #endregion

            #region Alt Alta 10 tane yıldız oluturma her satırda 10 tane yıldoız
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine("**********");
            }
            #endregion

            #region dik üçgen
            for (int a = 1; a<= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion 

            #region ters dik üçgen
            for (int c = 5; c >= 1; c--)
            {
                for (int d = 1; d <= c; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region ters düz üçgenn birleşimi
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int c = 5; c >= 1; c--)
            {
                for (int d = 1; d <= c; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region baklava dilimi
            int n;

            Console.Write("Baklava dilimi boyutunu girin: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int g = 1; g <= n; g++)
            {
                for (int h = 1; h <= n - g; h++)
                    Console.Write(" ");

                for (int m = 1; m <= 2 * g - 1; m++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int g = n - 1; g >= 1; g--)
            {
                for (int h = 1; h <= n - g; h++)
                    Console.Write(" ");

                for (int m = 1; m <= 2 * g - 1; m++)
                    Console.Write("*");

                Console.WriteLine();
            }
            #endregion

            #region piramit 
            int o;

            Console.Write("Piramit yüksekliğini girin: ");
            o = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= o; x++)
            {
                for (int y = 1; y <= o - x; y++)
                    Console.Write(" ");

                for (int z = 1; z <= 2 * x - 1; z++)
                    Console.Write("*");

                Console.WriteLine();
            }
            #endregion

            #region ters piramit
            int p;

            Console.Write("Ters piramit yüksekliğini girin: ");
            p = Convert.ToInt32(Console.ReadLine());

            for (int r = p; r >= 1; r--)
            {
                for (int s = 1; s <= p - r; s++)
                    Console.Write(" ");

                for (int t = 1; t <= 2 * r - 1; t++)
                    Console.Write("*");

                Console.WriteLine();
            }
            #endregion

            Console.Read();
        }
    }
}
