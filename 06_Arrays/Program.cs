using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2.4.6.8.10.12.
            //sarı,kırmızı,mavi,turuncu
            //adana,ankara,istanbul,bursa

            // değişken türü [] dizi adı=new değişen türü[dizinin eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //************************************************

            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "Amsterdam";
            //cities[2] = "Floransa";
            //cities[3] = "Newyork";
            //cities[4] = "Edinburg";

            //Console.WriteLine(cities[1]);

            //*********************************************

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 10;
            //numbers[2] = 25;
            //numbers[3] = 32;
            //numbers[7] = 39;
            //numbers[9] = 22;

            //Console.WriteLine(numbers[7]);

            //****************************************************

            //string[] cities = { "prag", "roma", "amsterdam", "edinburg" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region  Dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "turuncu", "mavi", "yeşil", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //****************************************************

            //int[] numbers = { 4, 85, 75, 125, 635, 488, 520, 7456, 2365, 1120,96,103,15,99 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3==0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //*****************************************************

            //char[] symbols = { 'a', 'b', 'c','*','/','+'};
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //******************************************************

            //int[] myArray = { 12, 82, 783, 124, 895, 636, 777, 258, 985, 150, 1121, 182, 137, 149, 151, 169, 177, 118, 1999, 120, };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //************************************************************

            //string[] persons = { "ali", "Ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            //***************************************************************

            //int[] numbers = { 18, 21, 20, 85, 96, 25, 35, 1 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //*****************************************************************

            //int[] numbers = { 18, 21, 20, 85, 96, 25, 35, 1 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Çınar", "Kaya", "Merve" };
            //int index = Array.IndexOf(customers, "Merve");

            //Console.WriteLine(index);

            //******************************************************************

            //int[] numbers = { 45, 85, 96, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + "  Dizinin en küçük elamanı : " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("------------------------------------");

            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            int[] numbers = { 10, 20, 30, 40, 50, 60 };

            #endregion



            Console.Read();
        }
    }
}
