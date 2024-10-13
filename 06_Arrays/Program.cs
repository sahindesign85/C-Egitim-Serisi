using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
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
            //2.4.6.8
            //adana,ankara,istanbul,izmir
            //değişkentürü [] Dizi adı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);




            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[5]); // Dizi 4 sıra olmasına rağmen 5 gibi aşan bir sayı kullanırsak program hata verir.




            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748; //dizinin bütün elemanları doldurulmak zorunda değil.

            //Console.WriteLine(numbers[5]);//dizin sınırları içinde olan ama içi tanımlanmamış
            //                              //dizi elamanı kodlar çalıştırılırsa 0 çıkar. 5 gibi. 
            //                              // Çünkü 5 tanımlı değil.





            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" }; //Diziler böyle de tanımlanabiliyor.

            //Console.WriteLine(cities[2]); //Dizinin 2. öğesini getirir. Prag 0, Roma 1, Atina 2 oluyor.
            //// index sıfırdan başlar unutma.


            #endregion Dizideki Tüm Elmanları Listeleme

            #region Dizideki Tüm Elmanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}





            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) // Dizinin mod 3 olan elemanlaarını yazdırmak için.
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}  





            //char[] symbols = { 'a', 'b', 'c', '*', '/', '_' }; //Char değişkeni ile kullanımı

            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}  
            //int[] myarray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 }; //En yüksek sayıyı bulma
            //int maxnumber = myarray[0];
            //for (int i = 0; i < myarray.Length; i++) 
            //{
            //    if (myarray[i] > maxnumber)
            //    {
            //        maxnumber = myarray[i];
            //    }
            //}  
            //Console.WriteLine(maxnumber);




            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);//array'ın eleman sayısını bulma



            ////**********Elemanları küçükten büyüğe sıralama*************
            //int[] numbers = { 45, 82, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); // Elemanları küçükten büyüğe sıralamak için kullanılır.

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            ////**********Elemanları küçükten büyüğe sıralama*************





            ////**********Son elemandan başlayıp tersten sıralama*************
            //int[] numbers = { 45, 82, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            ////**********Son elemandan başlayıp tersten sıralama*************

            #endregion


            #region Dizi Methotlar

            ////**********Bir elemanın index sırasını bulma*************
            //string[] customers = { "ali", "buse", "ayşe", "merve", "çınar" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);
            ////**********Bir elemanın index sırasını bulma*************


            ////**********Dizinin En Küçük ve En Büyük Elemanını bulma*************
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elamanı: " + numbers.Min());
            ////**********Dizinin En Küçük ve En Büyük Elemanını bulma*************

            #endregion

            #region Kullanıcıdan Değer Alma, Elemanları Toplayıp, Ekrana Yazdırma, Çift ve Tek Sayıları Sıralama

            ////**********Kullanıcıdan Array Elemanlarının isimlerini alma ve listeleme*************
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}). Şehri Giriniz; "); //$ bir parametre. süslü parantezz içinde çift tırnak kullanmaya gerek bırakmayan bir parametre.
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            ////**********Kullanıcıdan Array Elemanlarının isimlerini alma ve listeleme*************




            ////**********Dizinin Tüm int Elemanlarını Toplayıp Ekrana Yazdırma*************
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            // Console.WriteLine(sum);
            ////**********Dizinin Tüm int Elemanlarını Toplayıp Ekrana Yazdırma*************




            //////**********Dizinin İçindeki Çift Ve Tek Sayıları Ayrı Ayrı Sıralama*************
            //int[] numbers = { 21,42,33,54,55,66,897,748,39,220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2 == 0) //İkiye bölümünden 0 kalan yani çift
            //        {
            //    Console.WriteLine(numbers[i]);
            //        }
            //}

            //Console.WriteLine("----------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1) //İkiye bölümünden 1 kalan yani tek
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //////**********Dizinin İçindeki Çift Ve Tek Sayıları Ayrı Ayrı Sıralama*************
            




            #endregion
            Console.Read();
        }
    }
}
