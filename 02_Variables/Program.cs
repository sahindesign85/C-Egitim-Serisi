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
            #region double Değişkenler
            //Ondalıklı değişkenler
            //    double number;
            //    number = 4.85;
            //    Console.WriteLine(number);

            Console.OutputEncoding = System.Text.Encoding.Unicode; //₺ simgesini encode edebilmek için.
                                                                   //Bu kod sonrası ₺ işareti için Altgr+t tuşlarına birlikte basmak yeterli.

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, PotatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //PotatoPrice = 9.74;
            //tomatoPrice = 6.88;


            //Console.WriteLine("Elma Birim Fiyatı:" + applePrice + " ₺"); // Altgr + t tuşu ile ₺ simgesi çıkıyor.
            //Console.WriteLine("Portakal Birim Fiyatı:" + orangePrice + " ₺");
            //Console.WriteLine("Çilek Birim Fiyatı:" + strawberryPrice + " ₺");
            //Console.WriteLine("Patates Birim Fiyatı:" + PotatoPrice + " ₺");
            //Console.WriteLine("Domates Birim Fiyatı:" + tomatoPrice + " ₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * PotatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " ₺" + " - Gramaj: " + appleGram + " kg " + " - Toplam Tutar: " + appleTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " ₺" + " - Gramaj: " + orangeGram + " kg " + " - Toplam Tutar: " + orangeTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " ₺" + " - Gramaj: " + strawberryGram + " kg " + " - Toplam Tutar: " + strawberryTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + PotatoPrice + " ₺" + " - Gramaj: " + potatoGram + " kg " + " - Toplam Tutar: " + potatoTotalPrice + " ₺");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " ₺" + " - Gramaj: " + tomatoGram + " kg " + " - Toplam Tutar: " + tomatoTotalPrice + " ₺");


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı:" + shoppingTotalPrice + " ₺");

            #endregion

            #region Char Değişkenler 
            // Tek karakter tutan değişken
            // tek tırnak ile tanımlanır. '...'
            // Çift tırnak ile tanımlanan string değişkenler. "...."

            //char symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri ve Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict,
            //    passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + " " +  passengerIdentityNumber  + " - " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / "  + passengerCity + " " + passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice 
            //    + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " " + "₺");
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
