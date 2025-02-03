using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lutfen şifrenizi girinizi:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "1234")  //if ve else yazıldıktan sonra ; konulmaz.
            //{
            //    Console.WriteLine("Giriş Başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş Başarısız");
            //}




            //string capital, country;
            //Console.Write("Başkentin adını giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ülkenin adını giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye") // Not: Büyük-küşük harf duyarlıdır, aynı şekilde yazılmalıdır.
            //{
            //    Console.WriteLine("Veriler Doğru");
            //}
            //else if (capital == "paris" & country == "fransa")
            //{
            //    Console.WriteLine("Veriler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}


            //int number;
            //Console.Write("Lutfen bir sayı girin:");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Doğru Sayı Girildi.");
            //}

            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");

            //}


            //double exam1, exam2, exam3, average;
            //string result = "Hata";
            //Console.Write("1. Sınav Notunuzu Giriniz:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunuzu Giriniz:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunuzu Giriniz:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalamanız:" + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";

            //}

            //if (average > 50 & average <= 75)
            //{
            //    result = " Sonuç Orta";
            //}

            //if (average > 75)
            //{
            //    result = "Sonuç Çok iyi";
            //}

            //veya Kullanımı Örneği

            //string city;
            //Console.Write("Şehir Adını Giriniz:");
            //city = Console.ReadLine();
            //if (city == "ankara" | city == "istanbul" | city == "izmir") 
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else  
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}


            //!= (Eşit DEĞİLSE) Kullanımı Örneği

            //string username;
            //Console.Write("Kullanıcı Adını Giriniz:");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı Adı Doğru");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen birinci sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("Birinci sayının ikinci sayıya bölümünden kalan:" + result);


            //Console.Write("Lütfen bir sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenleri ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen bir takım sembolü giriniz:");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'f' | team == 'F' )
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");

            #endregion

            #region Örnek Proje Uygulaması 


            //Console.WriteLine("****** C# Eğitim Kampı Restorant *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menüyü seçin:");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kuru Fasulye");
            //    Console.WriteLine("2- İzmir Köfte");
            //    Console.WriteLine("3- Tavuklu Pilav");
            //    Console.WriteLine("4- Kuzu Tandır");
            //    Console.WriteLine("5- Kıymalı Pide");
            //    Console.WriteLine("6- Kavurma");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası);
            //    Console.WriteLine("2- Ezogelin");
            //    Console.WriteLine("3- Tarhana");
            //    Console.WriteLine("4- İşkembe");
            //    Console.WriteLine("5- Kellepaça");
            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Vejetaryan Pizza");
            //    Console.WriteLine("2- Sucuklu Pizza");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine("4- Kaşarlı Pizza");
            //    Console.WriteLine("5- Karışık Pizza");
            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Fanta");
            //    Console.WriteLine("3- Sprite");
            //    Console.WriteLine("4- Ice Tea");
            //    Console.WriteLine("5- Ayran");
            //    Console.WriteLine("6- Su");

            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{

            //    Console.WriteLine();
            //    Console.WriteLine("-----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kazandibi");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Revani");
            //    Console.WriteLine("4- Profiterol");
            //    Console.WriteLine("5- Künefe");
            //    Console.WriteLine("6- Pasta");

            //    Console.WriteLine();

            //}



            #endregion

            #region Switch Case/Break

            Console.Write("Lutfen Ay Numarasını Seçiniz:");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak");break;
                case 2:
                    Console.WriteLine("Şubat"); break;
                case 3:
                    Console.WriteLine("Mart"); break;
                case 4:
                    Console.WriteLine("Nisan"); break;
                case 5:
                    Console.WriteLine("Mayıs"); break;
                case 6:
                    Console.WriteLine("Haziran"); break;
                case 7:
                    Console.WriteLine("Temmuz"); break;
                case 8:
                    Console.WriteLine("Ağustos"); break;
                case 9:
                    Console.WriteLine("Eylül"); break;
                case 10:
                    Console.WriteLine("Ekim"); break;
                case 11:
                    Console.WriteLine("Kasım"); break;
                case 12:
                    Console.WriteLine("Aralık"); break;

                default:
                    Console.WriteLine("Hatalı Bilgi Girdiniz");
                    break;







            }




            #endregion
            Console.ReadLine();
        }
    }

}
