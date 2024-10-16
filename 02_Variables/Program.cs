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
            #region Double Değişkenler
            //double number;
            //number=4.85;
            //Console.WriteLine(number);

            // *******************************************************

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı : " + tomatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün- Elma " + "- Birim Fiyat : " + applePrice + " TL" + "- Gramaj : " + appleGram + " -Toplam Tutar : " + appleTotalPrice + " -TL");
            //Console.WriteLine("Alınan Ürün- Portakal " + "- Birim Fiyat : " + orangePrice + " TL" + "- Gramaj : " + orangeGram + " -Toplam Tutar : " + orangeTotalPrice + " -TL");
            //Console.WriteLine("Alınan Ürün- Çilek " + "- Birim Fiyat : " + strawberryPrice + " TL" + "- Gramaj : " + strawberryGram + " -Toplam Tutar : " + strawberryTotalPrice + " -TL");
            //Console.WriteLine("Alınan Ürün- Patates " + "- Birim Fiyat : " + potatoPrice + " TL" + "- Gramaj : " + potatoGram + " -Toplam Tutar : " + potatoTotalPrice + " -TL");
            //Console.WriteLine("Alınan Ürün- Domates " + "- Birim Fiyat : " + tomatoPrice + " TL" + "- Gramaj : " + tomatoGram + " -Toplam Tutar : " + tomatoTotalPrice + " -TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı : " + shoppingTotalPrice + " -TL");

            #endregion

            #region Char Değişkenler
            //ABCDEFGH

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi Giriniz : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi Giriniz : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşınız : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Numarası Giriniz : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Yolcu Kimlik Numarası :  " + passengerIdentityNumber + "   "+ "Yolcu Adı Soyadı : " + passengerName + " " + passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount,computerCount,chairCount,tvCount;


            //Console.Write("Lütfen aldığınız Ayakkabı sayısını Giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız Bilgisayar sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız Sandalye sayısını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız Televizyon sayısını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesPrice*shoesCount+computerCount*computerPrice+chairCount*chairPrice+tvPrice*tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Tolam ödemeniz gereken tutar : "+ totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.Write("Sınav Ortalamanız : "+result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz : ");

            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : "+gender);


            #endregion


            Console.Read();
        }
    }
}
