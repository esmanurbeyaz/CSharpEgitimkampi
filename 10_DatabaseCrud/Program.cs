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

            //crud-> create read update delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");

            #region kategori ekleme işlemi

            //Console.Write("Eklemek istediğiniz kategori adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=Esma;initial Catalog=EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // koşulsuz olarak gerçekleştir
            //connection.Close();

            //Console.WriteLine("kategori başarıyla eklendi");
            #endregion

            #region ürün ekleme işlemi
            //Console.WriteLine("Eklemek istediğiniz ürünü giriniz : ");
            //string productName = Console.ReadLine();
            //Console.WriteLine("Eklemek istediğiniz ürünün fiyatını giriniz : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            ////Console.WriteLine("Eklemek istediğiniz ürünün stok durumunu giriniz : ");
            ////char productStatus = char.Parse(Console.ReadLine());//burası yanlış kullanıcı 0 1 dışında bir şey yazarsa hata alır ilk yaptığın bool doğruydu



            //SqlConnection connection = new SqlConnection("Data source = Esma; initial Catalog = EgitimKampiDb; integrated security = true ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@p1, @p2, @p3)", connection);

            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2" , productPrice);
            //command.Parameters.AddWithValue("@p3" ,true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("ekleme başarılı");





            #endregion

            #region ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=Esma;initial Catalog=EgitimKampiDb;integrated security=true"); //bağlantıyı oluşturdum
            //connection.Open(); //bağlantıyı açtım
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection); //sorguyu yazdıdm
            //SqlDataAdapter adapter = new SqlDataAdapter(command);//sql le c# arası bir köprü
            //DataTable dataTable = new DataTable();//verileri belleğe almayı sağlar
            //adapter.Fill(dataTable);//bellekte sorguyu göster

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region ürün silme işlemi

            //Console.Write("Silinecek ürün ID : ");
            //int productId =int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=Esma;initial Catalog=EgitimKampiDb;integrated security=true"); //bağlantıyı oluşturdum
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("silme işlemi tamamlandı");

            #endregion

            #region ürün güncelleme işlemi

            Console.Write("güncellenecek ürün ID : ");
            int productId =int.Parse(Console.ReadLine());

            Console.Write("güncellenecek ürün adı : ");
            string productName = Console.ReadLine();

            Console.Write("güncellenecek ürün fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=Esma;initial Catalog=EgitimKampiDb;integrated security=true"); //bağlantıyı oluşturdum
            connection.Open();

            SqlCommand command = new SqlCommand("update TblProduct Set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("güncelleme başarılı");
            #endregion


            Console.Read();

        }
    }
}
