using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace tcKimlikNo
{
    internal class Program
    {

        static SqlConnection baglanti = new SqlConnection(@"Data source=OMER\SQLEXPRESS; initial catalog=tcNo; integrated security=true");
        static void Main(string[] args)
        {
            baslangic:
            string ad;
            string soyad;
            long tcKimlikNo;
            long basamak1,basamak2,basamak3,basamak4,basamak5, basamak6, basamak7, basamak8, basamak9, basamak10,
                tekliBasamaklar , ciftliBasamaklar;


            Console.WriteLine("Adınızı giriniz");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            soyad = Console.ReadLine();
            Console.WriteLine("TC Kimlik No'nuzu giriniz , 11 haneli olacak şekilde");
            tcKimlikNo = Convert.ToInt64(Console.ReadLine());

            basamak10 = (tcKimlikNo / 10) % 10; 
            basamak9 = (tcKimlikNo / 100) % 10;
            basamak8 = (tcKimlikNo / 1000) % 10;
            basamak7 = (tcKimlikNo / 10000) % 10;
            basamak6 = (tcKimlikNo / 100000) % 10;
            basamak5 = (tcKimlikNo / 1000000) % 10;
            basamak4 = (tcKimlikNo / 10000000) % 10;
            basamak3 = (tcKimlikNo / 100000000) % 10;
            basamak2 = (tcKimlikNo / 1000000000) % 10;
            basamak1 = (tcKimlikNo / 10000000000) % 10;

            tekliBasamaklar = basamak1 + basamak3 + basamak5 + basamak7 + basamak9;
            ciftliBasamaklar = basamak2 + basamak4 + basamak6 + basamak8;

            if (tcKimlikNo < 10000000000 && tcKimlikNo > 99999999999)
            {
                Console.WriteLine("TC Kimlik no'nuz 11 haneli olmalıdır lütfen bilgilerinizi tekrar giriniz");
                goto baslangic;
            }
            else if ((tekliBasamaklar * 7 - ciftliBasamaklar) % 10 == basamak10)
            {
                Console.WriteLine("verileriniz kaydedildi");
                baglanti.Open();
                string veriler = "insert into Kisiler(İsim , Soyisim , TCKimlikNo) values ('" + ad + "' , '"+soyad+"' , '"+tcKimlikNo+"')";
                SqlCommand komut = new SqlCommand(veriler, baglanti);


                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (basamak1 == 0)
            {
                Console.WriteLine("TC Kimlik No'nuzun 1. basamağı 0 olamaz lütfen bilgilerinizi tekrar giriniz");
                goto baslangic;
            }
            else
            {
                Console.WriteLine("girdiğiniz TC kimlik No geçersiz lütfen bilgilerinizi tekrar giriniz");
                goto baslangic;
            }

            Console.ReadLine();
        }
    }
}
