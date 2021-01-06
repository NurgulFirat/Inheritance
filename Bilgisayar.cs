using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public sealed class Bilgisayar : Urun
    {
        public string islemci { get; set; }
        public string ram { get; set; }
        public string ekranKarti { get; set; }
    }
}
