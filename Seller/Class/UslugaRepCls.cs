using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller.Class
{
    public class UslugaRepCls : UslugaC
    {
        public string DATA { get; set; }

        public string IMIE { get; set; }

        public string NAZWISKO { get; set; }

        public string ADRES { get; set; }

        public string WORKER { get { return IMIE + " " + NAZWISKO + ", " + ADRES; } }

    }
}
