using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Urun : baseClass
    {
        public string marka { get; set; }   //* belitmiş olan markalar içerisinde ürün eklenebilsin
        public string model { get; set; }

        private decimal _alisFiyat;
        public decimal alisFiyat    // 0'dan küçük olmamalı
        {
            get
            {
                return _alisFiyat;
            }
            set
            {
                if (alisFiyat <= 0)
                {
                    Console.WriteLine("Alış fiyatı 0'dan küçük veya eşit olamaz.");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        }

        private decimal _satisFiyat;
        public decimal satisFiyat   //alisFiyat'ından küçük olamaz
        {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz");
                }
                else
                {
                    _satisFiyat = satisFiyat;
                }
            }
        }

        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat    //0'dan küçük olamaz
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0'dan küçük olamaz.");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        }


    }
}
