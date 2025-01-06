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
            Console.OutputEncoding = System.Text.Encoding.Unicode; //Tl sembolünün gözükmesi için
                                                                   //double number;
                                                                   //number = 10.5;
                                                                   //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 5.5;
            //orangePrice = 6.5;
            //strawberryPrice = 7.5;
            //potato = 10;
            //tomato = 15.7;

            //Console.WriteLine("---Elma Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---Portakal Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("---Çilek Fiyatı: " + strawberryPrice + "₺");
            //Console.WriteLine("---Patates Fiyatı: " + potato + "₺");
            //Console.WriteLine("---Domates Fiyatı: " + tomato + "₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.345;
            //strawberryGram = 3.345;
            //potatoGram = 4.345;
            //tomatoGram = 5.345;

            //double appleTotal,orangeTotal,strawberryTotal,potatoTotal,tomatoTotal;
            //appleTotal= applePrice * appleGram;
            //orangeTotal = orangePrice * orangeGram;
            //strawberryTotal = strawberryPrice * strawberryGram;
            //potatoTotal = potato * potatoGram;
            //tomatoTotal = tomato * tomatoGram;



            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Elma " + "-Birim Fiyat:" + applePrice + "₺" + "-Gramaj:" + appleGram + "-Toplam Tutar:" + appleTotal);
            //Console.WriteLine("Alınan Ürün:Portakal " + "-Birim Fiyat:" + orangePrice + "₺" + "-Gramaj:" + orangeGram + "-Toplam Tutar:" + orangeTotal);
            //Console.WriteLine("Alınan Ürün:Çilek " + "-Birim Fiyat:" + strawberryPrice + "₺" + "-Gramaj:" + strawberryGram + "-Toplam Tutar:" + strawberryTotal);
            //Console.WriteLine("Alınan Ürün:Patates " + "-Birim Fiyat:" + potato + "₺" + "-Gramaj:" + potatoGram + "-Toplam Tutar:" + potatoTotal);
            //Console.WriteLine("Alınan Ürün:Domates " + "-Birim Fiyat:" + tomato + "₺" + "-Gramaj:" + tomatoGram + "-Toplam Tutar:" + tomatoTotal);

            //double shopingTotalPrice;
            //shopingTotalPrice = appleTotal + orangeTotal + strawberryTotal + potatoTotal + tomatoTotal;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar:" + shopingTotalPrice + "₺");

            #endregion

            #region Char Değişkenler
            //Char değişkenler tanımlanırken tek tırnak (') içerisinde tanımlanır.

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerCity, passengerDistrict, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Şehir:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu İlçe:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik Numarası:");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No:" + passengerIdentityNumber + "Yolcu Adı:" + passengerName + "Yolcu Soyadı:" + passengerSurname + "Yolcu Şehir:" + passengerCity + "Yolcu İlçe:" + passengerDistrict + "Yolcu Yaş:" + passengerAge);

            #endregion

            #region Klavyeden  Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, televisionPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //televisionPrice = 12000;

            //int shoesCount, computerCount, chairCount, televisionCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz:");
            //televisionCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + televisionPrice * televisionCount;


            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar:" + totalPrice + "₺");


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri ve Dönüşümler

            //double exam1, exam2, exam3, result;

            //Console.Write("Lutfen birinci sınav notunu girinizi:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen ikinci sınav notunu girinizi:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen üçüncü sınav notunu girinizi:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalama:" + result);
            #endregion

            #region Klavyeden Char Değişken Girişleri

            char gender;

            Console.Write("Lütfen cinsiyetinizi giriniz(Erkek için E, Kadın için K):");

           gender= char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);



            #endregion


            Console.ReadLine();

        }
    }
}
