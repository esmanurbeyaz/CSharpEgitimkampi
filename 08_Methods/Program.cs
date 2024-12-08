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
            #region Void Methodlar 

            ////() method olabilmesi için parantez açılıp kapanması gerekli
            //// mor renkte bir küp onun bir method olduğunu belirtir
            //// ikiye ayrılır 
            //// 1 geriye değer döndermeyen methodlar 
            ////Void

            //void CustomerList ()
            //{
            //    Console.WriteLine("esmanur beyaz");
            //    Console.WriteLine("ali kuru");
            //    Console.WriteLine("ayşe yaşar");
            //    Console.WriteLine("hakan batmaz");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}

            //sum();
            #endregion

            #region geriye değer döndermeyen string parametreli methodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine("Müşteri : " + customerName);
            //}

            //WriteMethod("esmanur beyaz");

            //void customerCard(string customerName , string customerSurname, int customerAge)
            //{
            //    Console.WriteLine("Müşterinin Adı Soyadı : " + customerName + " " + customerSurname);
            //    Console.WriteLine("Müşterinin Yaşı : " +customerAge );
            //    Console.WriteLine("------------------------------");
            //}

            //customerCard("ali" , "bakar" , 22 );
            //customerCard("fatma" , "saim" , 45 );
            //customerCard("cenk" , "kara" , 38 );

            #endregion

            #region geriye değer döndermeyen int parametreli methodlar

            //void sum (int number1 , int number2 , int number3)
            //{
            //    int resault = number1 + number2 + number3;
            //    Console.WriteLine(resault);
            //}

            //sum(3, 5, 4);

            #endregion

            #region geriye değer döndüren methodlar

            //string customerName ()
            //{
            //    return "buse yıldız";
            //}

            //customerName();

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region geriye değer döndüren string parametreli methodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + " - Başkent :  " + capital + " - Bayrak rengi : " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz  : ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region geriye değer döndüren int parametreli methodlar

            //int Sum (int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(72, 65));
            //Console.WriteLine(Sum(14, 84));
            //Console.WriteLine(Sum(66, 40));




            #endregion

            #region örnek uygulama

            //string ExamResult(string student, int exam1 , int exam2 , int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli kişi sınavı geçtiniz" + " ortalama : " + result;
            //    }

            //    else
            //    {
            //        return student + " isimli kişi sınavdan kaldınız" + " ortalama : " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Ayşe", 25, 41, 85));

            #endregion


            Console.Read();

        }
    }
}
