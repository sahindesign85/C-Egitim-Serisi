using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünlerler");
            Console.WriteLine("3-Siparişlerler");
            Console.WriteLine("4-Çıkış Yap");

            Console.Write("Lütfen getirmek istediğiniz tablo nmarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-A1R71B7\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray) 
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Read();
        }
    }
}
