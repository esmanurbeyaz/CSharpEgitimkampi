using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alte 10 tane yıldız

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region yan yana 10 tane yıldız

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alte 10 tane yıldız her satırda 10 yıldız

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region ters dik üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region ikili dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region baklava dilimi 
            //int n = 5; //kaç satırdan oluşacağını belirtir
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--) //bu döngü sol taraftan boşluk bırakır 
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++) // 1-3-5 yıldız ekleme
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region ters piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region doğru baklava dilimi 

            //int n = 5;


            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region en en en doğru baklava dilimi


            int n = 5; //kaç satırdan oluşacağını belirtir
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - 1; j > 0; j--) //bu döngü sol taraftan boşluk bırakır 
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++) // 1-3-5 yıldız ekleme
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                
                Console.Write("      ");
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 7 - i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion





            Console.Read();
        }
    }
}
