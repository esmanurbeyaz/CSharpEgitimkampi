using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ***** ");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmak İstediğiniz Tablo Numarasını Giriniz : ");
            tableNumber= Console.ReadLine();
            Console.WriteLine("----------------------------------------");

            SqlConnection connection =  new SqlConnection("Data Source=Esma;initial Catalog=EgitimKampiDb;integrated security=true"); //bağlantıyı oluşturdum
            connection.Open(); //bağlantıyı açtım
            SqlCommand command = new SqlCommand("Select * From TblCategory" , connection); //sorguyu yazdıdm
            SqlDataAdapter adapter = new SqlDataAdapter(command);//sql le c# arası bir köprü
            DataTable dataTable = new DataTable();//verileri belleğe almayı sağlar
            adapter.Fill(dataTable);//bellekte sorguyu göster

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            connection.Close();

            Console.Read();
        }
    }
}
