using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilin_Otomasyon
{
    public class Hesaplar
    {
        public static int UcretHesala(int GirSaat, int GirDakika, int CikSaat, int CikDakika)
        {
            int Ucret = 0;
            
            if (CikDakika < GirDakika && CikSaat > GirSaat)
            {
                int a = CikSaat - 1;
                int GecenSureSaatHesabi = (a * 60) - (GirSaat * 60);
                int GecenSureSaati = GecenSureSaatHesabi / 60;

                if (GecenSureSaati <= 3)
                {
                    Ucret = GecenSureSaati * 3;
                }
                else if (GecenSureSaati >= 3 && GecenSureSaati < 6)
                {
                    int c = GecenSureSaati - 2;
                    Ucret = (c * 2) + 9;
                }
                else
                {
                    int c = GecenSureSaati - 5;
                    c = (c / 3) +1 ;
                    Ucret = (c * 5) + 15;
                }
            }
            else if (GirSaat > CikSaat)
            {
                int a = CikSaat;
                int GecenSureSaatHesabi = (a * 60) - (GirSaat * 60);
                int GecenSureSaati = GecenSureSaatHesabi / 60;
                GecenSureSaati += 24;

                if (GecenSureSaati <= 3)
                {
                    Ucret = GecenSureSaati * 3;
                }
                else if (GecenSureSaati >= 3 && GecenSureSaati < 6)
                {
                    int c = GecenSureSaati - 2;
                    Ucret = (c * 2) + 9;
                }
                else
                {
                    int c = GecenSureSaati - 5;
                     c =(c / 3) +1;
                    Ucret = (c * 5) + 15;
                }

                
            }
            else
            {
                int GecenSureSaatHesabi = (CikSaat) - (GirSaat);
                int b = (CikDakika - GirDakika);

                if (b < 0)
                {
                    b = b + 60;
                }

                if (GecenSureSaatHesabi == 0)
                {
                    Ucret = 3;
                }
                else if (GecenSureSaatHesabi <= 3)
                {

                    Ucret = GecenSureSaatHesabi * 3;
                }
                else if (GecenSureSaatHesabi >= 3 && GecenSureSaatHesabi < 6)
                {
                    int a = GecenSureSaatHesabi - 2;
                    Ucret = (a * 2) + 9;
                }
                else
                {
                    int a = GecenSureSaatHesabi - 5;
                     a =(a / 3) +1 ;

                    Ucret = (a * 5) + 15;
                }
            }
            return Ucret;
        }

        public static string SaatHesapla(int GirSaat, int GirDakika, int CikSaat, int CikDakika)
        {
            string DakikaHesabi = "";
            if (CikDakika < GirDakika && CikSaat > GirSaat)
            {
                int saat = CikSaat - 1;
                int GecenSureSaatHesabi = (saat * 60) - (GirSaat * 60);
                int GecenSureSaati = GecenSureSaatHesabi / 60;
                int b = (CikDakika - GirDakika) + 60;
                DakikaHesabi = "Geçirilen süre: " + GecenSureSaati + " saat " + b + " dakika. ";
            }
            else if (GirSaat > CikSaat)
            {
                int saat = CikSaat;
                int GecenSureSaatHesabi = (saat * 60) - (GirSaat * 60);
                int GecenSureSaati = GecenSureSaatHesabi / 60;
                GecenSureSaati += 24;
                DakikaHesabi = "Geçirilen süre: " + GecenSureSaati + " saat " + saat + " dakika. ";
            }
            else
            {
                int GecenSureSaatHesabi = (CikSaat) - (GirSaat);
                int b = (CikDakika - GirDakika);

                if (b < 0)
                {
                    b = b + 60;
                }
                DakikaHesabi = "Geçirilen süre: " + GecenSureSaatHesabi + " saat " + b + " dakika. ";
            }

            return DakikaHesabi;
        }

        public static bool Format(string GirSaat, string CikSaat)
        {
            bool Format = false;

            if (GirSaat.Length != 5 || CikSaat.Length != 5 || !GirSaat.Contains(":") || !CikSaat.Contains(":") )
            {
                Format = true;
            }

            return Format;
        }
    }
}
