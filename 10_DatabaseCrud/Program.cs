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
            //Crud--> Create-Read-Update-Delete

           Console.WriteLine("*****Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A1R71B7\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand( "insert into TblCategory (CategoryName) values (@p1)", connection );
            //command.Parameters.AddWithValue("@p1", categoryName );
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarılı bir şekilde eklendi!");

            #endregion

            #region Ürüm Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            ////Console.Write("Ürün Durumu: ");
            //// productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A1R71B7\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün başarılıı bir şekilde eklendi");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A1R71B7\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable datatable = new DataTable(); 
            //adapter.Fill(datatable);

            //foreach (DataRow row in datatable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A1R71B7\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@ProductId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi Başarılı Bir Şekilde Gerçekleşti");

            #endregion


            #region  Ürün Güncelleme İşlemi

            //Console.Write("Güncellecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A1R71B7\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı.");


            #endregion


            Console.Read();
            
        }
    }
}
