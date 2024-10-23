using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach(1,2,3;4)

            //    1. değişken türü
            //    2. değişken adı
            //    3. in
            //    4. liste, koleksiyon, dizi



            //// foreach şehir listeleme (string kullanımı)
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //// foreach şehir listeleme (string kullanımı)



            ////foreach mode 2 rakam listeleme (int kullanımı)
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2  == 0)
            //    {
            //        Console.WriteLine(number);
            //    }  
            //}
            ////foreach mode 2 rakam listeleme (int kullanımı)



            ////Bir dizinin içindeki sayılaarı toplama
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{ 
            //    total += i;
            //}
            //Console.WriteLine(total);
            ////Bir dizinin içindeki sayılaarı toplama


            ////foreach Listelerle çalışma
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers) 
            //{ 
            //    Console.WriteLine(number);
            //}
            ////foreach Listelerle çalışma


            ////foreach char ile klimnin harflerini listeleme
            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            //foreach char ile klimnin harflerini listeleme

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Örnek Sınav Sistemi Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //// Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totatlExamResults = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totatlExamResults += value; //notları topluyoruz

            //    }
            //    Console.WriteLine();

            //    studentExamAvg[i] = totatlExamResults / 3;
            //}

            ////Öğrencilerin ortalamaası ve geçip kalma durumları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilerin ortalamaası ve geçip kalma durumları

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }

            //    else 
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }

            //    Console.WriteLine("------------------------------");


            //}

            
            #endregion
            Console.Read();
        }
    }
}
