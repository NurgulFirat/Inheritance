using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
           // B1.id = 1;  //değer girmek istemiyorum, uygulamanın bana bu alanı set edilebilir şekilde bırakmasını da istemiyorum.. ÇÖZÜM => 
            B1.marka = "Lenovo";
            B1.model = "z50";
            B1.islemci = "I5";
            B1.alisFiyat = -1;
            B1.satisFiyat = 1600M;
            B1.kampanyaFiyat = 1000M;
            B1.barkod = "1234567890";

            SanalDatabase.yeniUrunEkle(B1);

            Bilgisayar B2 = new Bilgisayar();
            B2.marka = "Lenovo";
            B2.model = "z50";
            B2.islemci = "I5";
            B2.alisFiyat = -1;
            B2.satisFiyat = 1600M;
            B2.kampanyaFiyat = 1000M;
            B2.barkod = "1234567890";

            SanalDatabase.yeniUrunEkle(B2);


        }
    }
}
