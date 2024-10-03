using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDeğişkenler

            //double apple = 60.35;
            //double pear = 65.75;
            //double banana = 90.80;
            //double grape = 70.25;
            //double orange = 35.65;

            //Console.WriteLine("********** FİYAT LİSTESİ **********");
            //Console.WriteLine();
            //Console.WriteLine("1 KG Elma : " + apple + " TL");
            //Console.WriteLine("1 KG Armut : " + pear + " TL");
            //Console.WriteLine("1 KG Muz : " + banana + " TL");
            //Console.WriteLine("1 KG Üzüm : " + grape + " TL");
            //Console.WriteLine("1 KG Portakal : " + orange + " TL");
            //Console.WriteLine();
            //Console.WriteLine("********** FİYAT LİSTESİ **********");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleWeight;
            //double pearWeight;
            //double bananaWeight;
            //double grapeWeight;
            //double orangeWeight;

            //double totalApple;
            //double totalPear;
            //double totalBanana;
            //double totalGrape;
            //double totalOrange;
            //double totalFruits;

            //appleWeight = 6.300;
            //pearWeight = 5.250;
            //bananaWeight = 2.100;
            //grapeWeight = 8.700;
            //orangeWeight = 4.600;


            //totalApple = appleWeight * apple;
            //totalPear = pearWeight * pear;
            //totalBanana = bananaWeight * banana;
            //totalGrape = grapeWeight * grape;
            //totalOrange = orangeWeight * orange;
            //totalFruits = totalApple + totalPear + totalBanana + totalGrape + totalOrange;


            //Console.WriteLine("----------ÖDENECEK TUTAR----------");
            //Console.WriteLine();
            //Console.WriteLine("Elma     : " + appleWeight + " kg" + " Tutar :" + totalApple + " TL");
            //Console.WriteLine("Armut    : " + pearWeight + " kg" + " Tutar :" + totalPear + " TL");
            //Console.WriteLine("Muz      : " + bananaWeight + " kg" + " Tutar :" + totalBanana + " TL");
            //Console.WriteLine("Üzüm     : " + grapeWeight + " kg" + " Tutar :" + totalGrape + " TL");
            //Console.WriteLine("Portakal : " + orangeWeight + " kg" + " Tutar :" + totalOrange + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar : " + totalFruits + " TL");
            //Console.WriteLine();
            //Console.WriteLine("------------TEŞEKKÜRLER------------");





            #endregion

            #region charDeğişkenler
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region  klavyeden veri girişleri string değişkenler

            //Console.WriteLine(" ***** HAVA YOLLARI YOLCU BİLGİ ***** ");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerCountry, passengerIdentifyNumber, passengerAge;

            //Console.Write("Adınızı giriniz : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Soyadınızı giriniz : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçenizi giriniz : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehrinizi giriniz : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Ülkenizi giriniz : ");
            //passengerCountry = Console.ReadLine();
            //Console.Write("Yaşınızı giriniz : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Kimlik numaranızı giriniz giriniz : ");
            //passengerIdentifyNumber = Console.ReadLine();

            //Console.WriteLine("*************************");
            //Console.WriteLine("------YOLCU BİLGİSİ------");
            //Console.WriteLine("Yolcu :" + passengerName + " " + passengerSurname);
            //Console.WriteLine("Gidilen Konum : " + passengerDistrict + "/" + passengerCity + "/" + passengerCountry );
            //Console.WriteLine("Yolcunun Yaşı : " + passengerAge);
            //Console.WriteLine("Yolcunun Kimlik Bilgisi : " +  passengerIdentifyNumber);
            //Console.WriteLine();
            //Console.WriteLine("************************");




            #endregion

            #region klavyeden tam sayı girişleri ve dönüşümler 

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount , computerCount , chairCount , tvCount ;

            //Console.Write("Lürfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lürfen aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lürfen aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lürfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("toplam tutar : " +totalPrice);


            #endregion

            #region klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3;

            //Console.Write("lütfen 1. sınav notunuzu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sınav notunuzu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3. sınav notunuzu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //double ortalama = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalamanız : " + ortalama);

            //if (ortalama > 60)
            //{
            //    Console.WriteLine("Dersi Geçtiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Dersten Kaldınız");
            //}


            #endregion

            #region klavyeden karakter girişleri

            char gender;
            Console.Write("Lütfen cinsiyetinizi giriniz : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyetiniz : " +gender);

            #endregion


            Console.Read();
        }
    }
}
