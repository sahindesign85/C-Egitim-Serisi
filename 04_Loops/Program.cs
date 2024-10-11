using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler

            //For(x;y;z)
            //x: başlangıç
            // y; bitiş
            //artış azalış
            // yöntem ismini yazdıktan sonra iki defa tab tuşuna basarsan bilgisayar formatı ayarlar.

            //int i;
            //for (i = 1; i <=5; i++) 
            // // i=1 ifadesi i değişkenini 1 arttırmak için
            // // i<5 ifadesi süslü parantez içindeki işlemi 5 defa yap demek.
            // // i++ ifadesi artarak gideceğini ifade etmek için.
            //{
            //    Console.WriteLine("C# Eğitim Kampı");

            //}





            //for (int i = 1; i <= 20; i++) //int değeri ekrana yazdırılarak kullanırsa satır satır 1 arttırır.
            //{
            //Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3) // 3 sayısını 50'ye kadar 3'er 3'er arttırır.
            //{
            //    Console.WriteLine(i);
            //}






            //Console.WriteLine("Ekrana istediğiniz satır kadar 'Yaşasın Cumhuriyet' yazılacaktır.");
            //Console.Write("Lütfen ekrana yazılmasını istediğiniz satır sayısını giriniz: ");
            //int finishvalue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuruiyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //// 1'den 100'e kadar olan sayılardan 5'e bölünebilenleri sıralama
            //for (int i = 1; i <=100; i++)
            //{
            //    if ( i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //// Sayıları 1'den 10'a kadar sayıların tolam değerğnğ bulma
            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);



            //// 1'den 20'ye kadar olan sayıları bulup sıralama ve daha sonra toplamını bulma
            //int totalvalue = 0;
            //for (int i = 1; i < 20; i++)
            //{ 
            //if(i%2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(totalvalue);



            // 1 ie 50 arasında 7'ye bölünebilen kaç tane tam sayı olduğunu bulma ve o sayıları toplama
            //int count = 0;
            //for (int i = 1; i <=50; i++)
            //{
            //    if (i % 7 == 0) //i'nin değeri 7'ye bölümünden kalan sıfır  ise
            //    {
            //        count += 1;
            //    }
            //}

            //Console.WriteLine (count);



            // Bakterilerin her saat iki katına çıkma problemi
            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium + " Bakteri üremiştir.");

            //}

            #endregion

            #region While Döngüsü (Şart sağlandığı Sürece işlem yapar) - (Bunu hiç kullanmadım, örnekleri Organizer'e at!)

            // Bir şart sağlanana kadar süslü parantez içindeki işlemleri gerçekleştirir.
            // if ile for arası bir işlem.
            //while(şart)
            //{
            //    işlemler
            //}

            //int i=1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler"); // i değişkeni 10  sayısına ulaşana kadar süslü parantez içindeki işlemleri gerçekleştirir. 
            //    i++;
            //}



            // 1 ie 10 arasında 3'e tam bölünebilen sayıları bulma
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //// 1'den 10'a kadar olan sayıları bulma ve onları toplama
            //int i = 1;
            //int sum = 0;
            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //    Console.WriteLine(i); // Murat hocanın uygulamasında bu satır yok. Sonuçları görmek için ben ekledim.
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            ////Kalvyeden girilen 3 basamaklı sayının basamaklarının toplamını hesaplayan kodo yazınız.
            ////456
            //Console.WriteLine("*****Girilen Sayının Basamakları Toplamını Bulma*****");
            //Console.Write("Bir Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds, sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
     
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);
            #endregion

            Console.Read();
        }
    }
}
