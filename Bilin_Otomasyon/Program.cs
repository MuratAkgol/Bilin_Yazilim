using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilin_Otomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool devamEt = true;

            while (devamEt)
            {
                Console.WriteLine("Aracın giriş saatini giriniz:");
                string Giris_saat = Console.ReadLine();
                Console.WriteLine("Aracın çıkış saatini giriniz:");
                string Cikis_saat = Console.ReadLine();
                
                string[] Giris_ayir = Giris_saat.Split(':');
                string[] Cikis_ayir = Cikis_saat.Split(':');

                bool Format = Hesaplar.Format(Giris_saat,Cikis_saat);

                if (Format)
                {
                    Console.WriteLine("Saati istenen formatta girmediniz. (istenilen format= 07:15)");
                    continue;
                }

                var UcretHesaplama = Hesaplar.UcretHesala(Convert.ToInt32(Giris_ayir[0]), Convert.ToInt32(Giris_ayir[1]), Convert.ToInt32(Cikis_ayir[0]), Convert.ToInt32(Cikis_ayir[1]));
                var SaatHesapla = Hesaplar.SaatHesapla(Convert.ToInt32(Giris_ayir[0]), Convert.ToInt32(Giris_ayir[1]), Convert.ToInt32(Cikis_ayir[0]), Convert.ToInt32(Cikis_ayir[1]));
                Console.WriteLine(SaatHesapla + " Ücret: " + UcretHesaplama + " TL");

                Console.WriteLine("Devam etmek istiyor musunuz? (Evet/Hayır)");
                string devamCevabi = Console.ReadLine();

                if (devamCevabi.ToLower() != "evet")
                {
                    devamEt = false;
                }
            }

            Console.WriteLine("Program sona erdi.");
        }
    }
}


