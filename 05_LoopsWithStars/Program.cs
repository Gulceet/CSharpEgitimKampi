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
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //*********************************************

            #endregion

            #region yan yana 10 yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            //*********************************************
            #endregion

            #region Alt alta 10 yıldız oluşturma her satıda 10 yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*********");
            //}

            #endregion

            #region Dik üçgen şeklinde yıldızları yazdırma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //**************************************************
            #endregion

            #region ters dik üçgen


            //for (int i = 30; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region tersdüz dik üçgen oluşturma

            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 11; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region baklava dilimi 


            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write("  ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            #endregion

            #region Piramit oluşturma

            //Console.WriteLine();
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{

            //    //boşluklar
            //    for (int j = n - i; j > -1; j--)
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

            #region Ters Piramit oluşturma
            
            //int x = 10;
            //for (int i = x; i >= 1; i--)
            //{

            //    //boşluklar
            //    for (int j = x - i; j > 0; j--)
            //    {

            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i-1; k++)
            //    {

            //        Console.Write("*");
            //    }



            //    Console.WriteLine();
            //}


            #endregion

            Console.Read();
        }
    }
}
