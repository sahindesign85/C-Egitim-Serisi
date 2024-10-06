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

            #endregion

            #region Char Değişkenleri ile Karar Yapıları

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

            #region Örnek Proje Uygulamaları

            //Console.WriteLine("***** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1 Ana Yemekler");
            //Console.WriteLine("2 Çorbalar");
            //Console.WriteLine("3 Pizzalar");
            //Console.WriteLine("4 İçecekler");
            //Console.WriteLine("5 Tatlılar");
            //Console.WriteLine("--------------------------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Ana Yemekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------------------Ana Yemekler-------------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Çorbalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("-------------------Çorbalar-------------------");


            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Pizzalar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("-------------------Pizzalar-------------------");


            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------İçecekler-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("-------------------İçecekler-------------------");


            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------------Tatlılar-------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("-------------------Tatlılar-------------------");


            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi");break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi Yapımı

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol= char.Parse(Console.ReadLine()); 

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //        default:Console.WriteLine("Hatalı İşlem Yaptınız"); break; // Sadece tek karakter olarak farklı işlem
            //        //olursa hatalı veri girişi yaptınız der. Sebebi değişken char. Örneğin 4-5 tane harf yazarsan bu char değişkeni ol
            //        //madığı için hata döndürür.

            //}



            #endregion

            
            Console.Read();
        }
    }
}
