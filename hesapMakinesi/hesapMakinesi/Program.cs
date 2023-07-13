using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (1<2) { 
            int sayi1, sayi2;
            string islem;
            Console.WriteLine("1. sayıyı giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yapacağınız işlemi giriniz.");
            islem = Console.ReadLine();

            if (islem == "toplama")
            {
                Console.WriteLine("2. sayiyi giriniz");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("işleminizin sonucu : " + toplama(sayi1, sayi2) + "\n" +
                "**********************"); 
                
            }
            else if (islem == "çıkarma")
            {
                Console.WriteLine("2. sayiyi giriniz");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("işleminizin sonucu : " + cikarma(sayi1, sayi2) + "\n" +
                "**********************");

            }
            else if (islem == "çarpma")
            {
                Console.WriteLine("2. sayiyi giriniz.");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("işleminizin sonucu : " + carpma(sayi1, sayi2) + "\n" +
                "**********************");

            }
            else if (islem == "bölme")
            {
                Console.WriteLine("2. sayiyi giriniz.");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("hiçbir sayı sıfıra bölünmez sıfır dışında bir sayı giriniz!" + "\n" +
                        "**********************************************************");
                    }
                    else
                    {
                        Console.WriteLine("işleminizin sonucu : " + bolme(sayi1, sayi2) + "\n" +
                        "**********************");
                    } 
            }
            }
        }
        static int toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        static int carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        static double bolme(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }

    }
}
