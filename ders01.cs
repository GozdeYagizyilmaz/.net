using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");  //imleci alt tarafa atar.
            //Console.Write("selam"); 


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Soğuk Başlangıçlar");
            //Console.WriteLine("3-Ana Yemekler");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion


            #region String Değişkenler

            //Değişken_türü Değişen_adı;

            //string name;
            //name = "Gözde";

            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city ;

            //customerName = "Gözde";
            //customerSurname = "Yağızyılmaz";
            //customerPhone = "0532 123 45 67";
            //customerEmail = "deneme@gmail.com";
            //district = "İzmir";
            //city = "Karşıyaka";

            //Console.WriteLine("**** Rezervasyon Bilgileri ***** " );
            //Console.WriteLine();
            //Console.WriteLine("Müşteri Adı : " + customerName);
            //Console.WriteLine("Müşteri Soyadı : " + customerSurname);
            //Console.WriteLine("Müşteri Telefon : " + customerPhone);
            //Console.WriteLine("Müşteri Email : " + customerEmail);
            //Console.WriteLine("Müşteri Şehir :" + city);
            //Console.WriteLine("Müşteri İlçe : " + district);

            #endregion


            #region Int Değişkenler

            //İnt
            //int number = 25;

            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Yemek Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger : " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola : " + cokePrice + " TL");
            Console.WriteLine("-----Su : " + waterPrice + " TL");
            Console.WriteLine("-----Patates : " + friesPrice + " TL");
            Console.WriteLine("-----Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata : " + lemonadePrice + " TL");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine("Patates Tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Tutar:" + totalPrice + "TL");





















            #endregion

            Console.ReadLine();

        }
    }
}



