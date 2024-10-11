using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)

            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)

            //{

            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma, her  satırda 10tane yıldız olsun

            //for (int i = 1; i <= 10; i++)

            //{

            //    Console.WriteLine("**********");
            //}

            #endregion


            #region Dik Üçgen Oluşturma (for içinde for döngüsü oluşturma. (ayrıca çalış buna Table'da id döndürürken lazım olacak)

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen Oluşturma 
            ////azalması için i =5 ve küçük eşit yerine büyükeşit yapıldı.

            //for (int i = 5; i >= 1; i--) //gittikçe azalması için ++ yerine -- yapıldı
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen Beraber Uygulama (Üçgen artan şekilde taban sayısına ulaşınca bu sefer gittikçe azalacak)

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--) //Zaten üçgen tabanı 5 olduğu için bir eksiği olan 4 tanımlandı i için
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi Oluşturma


            ////Baklava diliminin üstteki tarafı başlangıç
            //int n = 5;

            //for (int i = 1; i <= n; i++)  // Dik üçgeni 5 satır olana kadar arttırır.

            //{
            //    for (int j = n - 1; j > 0; j--) // satırın başlangıcına 4 boşluk bırakana kadar çevirir. 
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= 2 * i - 1; k++) // sırayla 1-3-5-7 yıldız koymak için formül (2*3=6 6-1=5 şeklinde)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            ////Baklava dilimiminin üstteki tarafı bitiş

            ////BaklavaDilimiminin alttaki tarafı başlangıç

            //for(int i=n-1; i>=1; i--)
            //{
            //    for (int j= n -1; j> 0; j--)
            //    {
            //        Console.Write(" "); 
            //    }

            //    for( int k = 1;k <= 2 * i - 1;k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();

            //}

            ////Baklava dilimiminin alttaki tafı bitiş

            #endregion

            #region Piramit oluşturma

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar için (boşlulşar yukardan aşağı azalarak gidiyor.)
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar için (yıldızşar yukardan aşağı artarak gidiyor)
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit oluşturma

            //int n = 50;
            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluklar için 
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar için 
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            Console.Read();
        }
    }
}
