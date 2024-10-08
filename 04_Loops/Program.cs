using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For döngüsü
            //For(x;y;z)
            //x: başlangıç
            //y: bitiş
            //z: artış-azalış


            //for yaz 2 kere tab bas tamamlar 

            //breakpoint koyduktan sonra programı çalıştırırsan ve f11 ile adım adım ilerlersen
            //programın çalışma adımlarını görüntüleyebilirsin

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}



            //for (int i = 3; i <= 50; i = i + 3 /* i+=3 */)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Yazılmasını İstediğiniz Adedi Giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET!!!");
            //}



            #endregion

            #region for föngüsü ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            // 1 den 10 a kadaar saıların toplamı
            //doğrusu 

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);


            //yanlış 
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i+(i+1));
            //}


            //int totalValue = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(totalValue);
            //    }
            //}
            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);


            // 1 ile 50 arasında 7 ye bölünen kaç sayı var
            //DOĞRUUUU

            //int number = 0;

            //for (int i = 0; i <50 ; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        number ++ ;
            //    }
            //}

            //Console.WriteLine(number);

            //bir bakteri türü her saatin sonunda kendini ikiye bölerek çoğaltmaktadır 24 saatin sonundaki  bakteri sayısı nedir
            //doğru
            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri = (bakteri * 2);
            //    Console.WriteLine(i + ". saatte: " + bakteri);
            //}






            #endregion

            #region while döngüsü

            //while şart
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba");
            //    i++;
            //}

            //1 ile 10 arası 3 e tam bölünen sayılar
            //doğru
            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    i++;
            //}

            //1 le 10 arasındaki sayıların toplamı 

            //int i = 0;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum = sum + i;

            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region örnek soru

            //klavyeden girilen 3 basamaklı sayının basamakları toplamını bulunuz

            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100; 

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds); 
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);



            #endregion
            Console.Read();
        }
    }
}
