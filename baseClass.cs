using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class baseClass
    {

        public static int sayac = 1; //ilk oluştuğu zaman 1 değerini otomatik olarak alsın..

        public baseClass()
        {
            _id = sayac;
            sayac++;
        }

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                // bir sayaç içerisindeki değerden faydalanmak istiyoruz..
                //_id = sayac;
                //sayac++;
                // nedeni set alanı private olarak işaretlendiği için değer gelmiyor.
            }
        }

        private string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslemi = SanalDatabase.dbBarkodKontrol(value);
                if (!kontrolIslemi)  //değeri sanal database içerisinde bulamadım
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        }   

        public DateTime olusturmaTarihi { get; set; }
        public int olusturanKullanici { get; set; }

        public DateTime guncellemeTarihi { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }
    }
}
