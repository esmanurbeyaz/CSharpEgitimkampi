using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  if else
            //Console.Write("Lütfen şifrenizi giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("ŞİFRE DOĞRU");
            //}
            //else
            //{
            //    Console.WriteLine("ŞİFRE YANLIŞ");
            //}

            //string capital, country;

            //Console.Write("Başkenti Giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();

            //if ( capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğru");

            //}

            //else
            //{
            //    Console.WriteLine("Veriler Hatalı");
            //}


            //int number;
            //Console.Write("5+3 işleminin sonucunu giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 8)
            //{
            //    Console.WriteLine("İşlem Sonucu Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("İşlem Sonucu hatalı");
            //}

            //double exam1, exam2, exam3, resault;
            //Console.Write("1. Sınav Notunuzu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunuzu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //resault = (exam1+ exam2 + exam3)/3;

            //if (resault < 50)
            //{
            //    Console.WriteLine("notunuz kötü kaldınız" + " not : " +resault );
            //}

            //else if (resault > 50 & resault < 70)
            //{
            //    Console.WriteLine("notunuz orta şartlı geçtiniz" + " not : " + resault);
            //}
            //else
            //{
            //    Console.WriteLine("notunuz iyi geçtiniz" + " not : " + resault);
            //}


            // videodaki örnek 

            //int exam1, exam2, exam3, average;
            //string resault;
            //resault = "hata";

            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average =  (exam1 + exam2 + exam3)/3;
            //Console.WriteLine("Sınavların ortalaması : " + average);

            //if (average > 0 & average <= 50)
            //{
            //    resault = "Sonuç Vasat";
            //}
            //if(average > 50 & average <= 70)
            //{
            //    resault = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    resault = "Sonuç İyi";
            //} 
            //if (average > 84)
            //{
            //    resault = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(resault);

            //string city;
            //Console.Write("Lütfen Şehir Giriniz : ");
            //city = Console.ReadLine();

            //if (city == "yozgat" || city == "kayseri" || city == "ankara" || city == "kırşehir")
            //{
            //    Console.WriteLine("Şehir iç anadoluda");
            //}

            //else if (city == "uşak" || city == "izmir" || city == "manisa" || city == "kütahya")
            //{
            //    Console.WriteLine("Şehir egede");
            //}
            //else
            //{
            //    Console.WriteLine("bilinmeyen şehir");
            //}

            //Console.Write("Lütfen kullancıı adı giriniz :");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hoş geldiniz");
            //}



            #endregion

            #region mod işlemleri

            //int number;
            //number = 26;
            //int resault = number % 5;
            //Console.WriteLine(resault);


            //int number1, number2, resault;

            //Console.Write("birinci sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("birinci sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());



            //resault = number1 % number2;
            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan : " + resault);

            //Console.Write("lütfen sayı giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}

            #endregion

            #region char değişkenler ile karar yapıları

            //char team;
            //Console.Write("Lütfen takım sembolü giriniz : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G') 
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region örnek proje uygulaması



            //Console.WriteLine("****** MENÜ ******");
            //Console.WriteLine();    
            //Console.WriteLine("1- ÇORBALAR");
            //Console.WriteLine("2- ANA YEMEKLER");
            //Console.WriteLine("3- SALATALAR");
            //Console.WriteLine("4- İÇECEKLER");
            //Console.WriteLine("5- TATLILAR");
            //Console.WriteLine("---------------------");
            //Console.WriteLine();
            //Console.Write("Lütfen bir kategori numarası giriniz : ");

            //int category = int.Parse(Console.ReadLine());

            //if (category == 1)
            //{
            //    Console.WriteLine("----- ÇORBALAR -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- DOMATES ÇORBASI");
            //    Console.WriteLine("2- TARHANA ÇORBASI");
            //    Console.WriteLine("3- MERCİMEK ÇORBASI");

            //    int choocie = int.Parse(Console.ReadLine());
            //    if (choocie == 1)
            //    {
            //        Console.WriteLine("Domates Çorbası Seçildi");
            //    }
            //    if (choocie == 2)
            //    {
            //        Console.WriteLine("Tarhana Çorbası Seçildi");
            //    }
            //    if (choocie == 3)
            //    {
            //        Console.WriteLine("Mercimek Çorbası Seçildi");
            //    }


            //}

            //if (category == 2)
            //{
            //    Console.WriteLine("----- ANA YEMEKLER -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- KÖFTE");
            //    Console.WriteLine("2- MAKARNA");
            //    Console.WriteLine("3- PİZZA");

            //    int choocie = int.Parse(Console.ReadLine());
            //    if (choocie == 1)
            //    {
            //        Console.WriteLine("Köfte Seçildi");
            //    }
            //    if (choocie == 2)
            //    {
            //        Console.WriteLine("Makarna Seçildi");
            //    }
            //    if (choocie == 3)
            //    {
            //        Console.WriteLine("Pizza Seçildi");
            //    }

            //}

            //if (category == 3)
            //{
            //    Console.WriteLine("----- SALATALAR -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- AKDENİZ SALATA");
            //    Console.WriteLine("2- TAVUKLU SALATA");
            //    Console.WriteLine("3- ÇOBAN SALATA");

            //    int choocie = int.Parse(Console.ReadLine());
            //    if (choocie == 1)
            //    {
            //        Console.WriteLine("Akdeniz Salata Seçildi");
            //    }
            //    if (choocie == 2)
            //    {
            //        Console.WriteLine("Tavuklu Salata Seçildi");
            //    }
            //    if (choocie == 3)
            //    {
            //        Console.WriteLine("Çoban Salata Seçildi");
            //    }

            //}

            //if (category == 4)

            //{
            //    Console.WriteLine("----- İÇECEKLER -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- KOLA");
            //    Console.WriteLine("2- LİMONATA");
            //    Console.WriteLine("3- ÇAY");

            //    int choocie = int.Parse(Console.ReadLine());
            //    if (choocie == 1)
            //    {
            //        Console.WriteLine("Kola Seçildi");
            //    }
            //    if (choocie == 2)
            //    {
            //        Console.WriteLine("Limonata Seçildi");
            //    }
            //    if (choocie == 3)
            //    {
            //        Console.WriteLine("Çay Seçildi");
            //    }

            //}

            //if (category == 5)
            //{
            //    Console.WriteLine("----- TATLILAR -----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- KAZANDİBİ");
            //    Console.WriteLine("2- SÜTLAÇ");
            //    Console.WriteLine("3- BAKLAVA");

            //    int choocie = int.Parse(Console.ReadLine());
            //    if (choocie == 1)
            //    {
            //        Console.WriteLine("Kazandibi Seçildi");
            //    }
            //    if (choocie == 2)
            //    {
            //        Console.WriteLine("Sütlaç Seçildi");
            //    }
            //    if (choocie == 3)
            //    {
            //        Console.WriteLine("Baklava Seçildi");
            //    }

            //}












            #endregion

            #region switch case

            //Console.Write("Lütfen bir ay girii yapın : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}




            #endregion

            #region switch case hesap makinesi

            //int number1, number2, resault;
            //char symbol;

            //Console.Write("birinci sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("ikinci sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("yapılacak işlemi seçiniz : ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+': Console.WriteLine("işlem toplamadır sonuç : " + (number1 + number2)); break;
            //    case '-': Console.WriteLine("işlem çıkarmadır sonuç : " + (number1 - number2)); break;
            //    case '*': Console.WriteLine("işlem çarpmadır sonuç : " + (number1 * number2)); break;
            //    case '/': Console.WriteLine("işlem bölmedir sonuç : " + (number1 / number2)); break;

            //}


            #endregion


            Console.Read();


        }
    }
}
