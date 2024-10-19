using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Forech döngüsü

            //Forech döngüsü(1;2;3;4)

            //1. değişken türü
            //2. değişken adı
            //3. in
            //4. Liste, Koleksiyon, dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 23, 65, 84, 9516, 4154, 77, 321, 54, 6, 21, 3 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 23, 65, 84, 9516, 4154, 77, 321, 54, 6, 21, 3 };

            //// bu yanlış true false olarak kontrol ederek yazdırdı içerisine if değişkeni ekleyerek yazdırman gerekli
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i % 2 == 0);
            //}

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 23, 65, 84, 9516, 4154, 77, 321, 54, 6, 21, 3 };
            //int sum = 0;

            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine(sum); //bunu foreach in içine yazarsan satır satır her topladığında ulaştığı değeri ekrana basıyor

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //bir kelimeyi harflerine ayıran ifade

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);   
            //}



            #endregion

            #region örnek sınav sistemi uygulaması

            //klavyeden öğrenci sayısı ismi sınav notu alıp ortalam hesaplayalım 
            //doğru ama videoda böyle değil

            //Console.WriteLine("********** SINAV SİSTEMİ **********");
            //Console.WriteLine();
            //Console.WriteLine("******************************");

            //Console.Write("Lütfen öğrenci sayısı giriniz : ");
            //int studentcount = int.Parse(Console.ReadLine());

            //string[] studentname = new string[studentcount];
            //int [] studentnot = new int[studentcount];   

            //for (int i = 0; i < studentcount; i++)
            //{
            //    Console.Write($"{i+1} . öğrencinin adını giriniz : ");
            //    string name= Console.ReadLine();
            //    studentname[i] = name;
            //    Console.WriteLine($"{i+1} . öğrencinin adı : " + name);
            //}


            //Console.WriteLine();
            //Console.WriteLine("******************************");
            //Console.WriteLine();


            //for (int i = 0; i < studentcount; i++)
            //{
            //    Console.Write($"{i+1} . öğrenci olan {studentname[i]} notunu giriniz : ");
            //    int not = int.Parse(Console.ReadLine());
            //    studentnot[i] = not;
            //    Console.WriteLine($"{i+1} . öğrencinin notu : " + not);

            //}

            //Console.WriteLine();
            //Console.WriteLine("******************************");
            //Console.WriteLine();

            //int x = 0;

            //for (int i = 0; i < studentcount; i++)
            //{

            //    x += studentnot[i];
            //}

            //int ortalama = x / studentcount;

            //Console.WriteLine("sınıfın ortalaması : " + ortalama);


            //videodaki kod 


            Console.WriteLine("***** C# Eğitim Kampı Sınav Sistemi Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını alma 
            Console.WriteLine("------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");

            //Öğrencilerin isimlerini ve not ortalamalarını tutacak olan diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();

                studentExamAverage[i] = totalExamResult / 3;
            }

            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması: {studentExamAverage[i]}");

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi başarıyla geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
                }

                Console.WriteLine("------------------------------------------------------");
            }








            #endregion

            Console.Read();

        }
    }
}
