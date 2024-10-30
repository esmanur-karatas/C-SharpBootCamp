using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_10_DatabaseCrud --> Create - Read - Update - Delete
            //#region Kategori Ekleme
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-08VSUMT;Initial Catalog=BootcampDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO Category (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi!");
            //#endregion

            //#region Ürün Listeleme 
            //// SQL bağlantısı
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-08VSUMT; Initial Catalog=BootcampDb; Integrated Security=True");
            //connection.Open();

            //// SQL komut ve adapter ayarları
            //SqlCommand command = new SqlCommand("SELECT * FROM Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //// DataTable oluşturma ve doldurma
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //connection.Close();

            //// Verileri konsola yazdırma
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //#endregion

            //#region Ürünleri silme
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //// SQL bağlantısı
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-08VSUMT; Initial Catalog=BootcampDb; Integrated Security=True");
            //connection.Open();

            //// Silme işlemi için SQL komutu
            //SqlCommand command = new SqlCommand("DELETE FROM Product WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //// Bağlantıyı kapat ve bilgi mesajı yazdır
            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı!");
            //#endregion

            #region Ürünleri Güncelleme
            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            // SQL bağlantısı
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-08VSUMT; Initial Catalog=BootcampDb; Integrated Security=True");
            connection.Open();

            // Güncelleme işlemi için SQL komutu
            SqlCommand command = new SqlCommand("UPDATE Product SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            // Bağlantıyı kapat ve bilgi mesajı yazdır
            connection.Close();
            Console.WriteLine("Güncelleme başarılı!");

            #endregion
            Console.Read();

        }
    }
}
