using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _03_Making_Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else Yapısı, Şifre Sorgulama

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            #endregion

            #region If Else, Başkent ve Ülke Sorgulama

            //string capital, country;
            //Console.Write("Başkenti Giriniz: "); 
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye") //Küçük büyük harf ayrımı yapıyor.
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}

            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            #endregion

            #region If Else, Girilen Sayıyı Sorgulama

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}


            #endregion

            #region If Else, Sınav Sonucunu Hesaplama ve Değerlendirme

            //int exam1, exam2, exam3, average;
            //string result= "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " +  " " + average);

            //if(average>0 & average <=50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 && average <=70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if(average>70 & average<84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average>84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            #endregion

            #region If Else, Girilen Şehri Sorgulama

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if(city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")  // | işareti Or gate yani veya demek için kullanılır.
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            #endregion

            #region If Else, Kulanıcı Adı Sorgulama ve != İfadesi
            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin" ) // != ifadesi farklıysa anlamında kullanılır. 
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri
            //int number;
            //number= 26;
            //int result =number % 5;
            //Console.WriteLine(result);



            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı girniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümünde kalan: " + result);



            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayi çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayi tektir");
            //}

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='g' | team=='G')
            //{
            //    Console.Write("Galatasaray");

            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");

            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");

            //}


            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("Trabzonspor");

            //}

            





            #endregion
            Console.Read();
        }
    }
}
