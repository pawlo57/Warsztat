using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller.Class
{
    public class UslugaC
    {
        public int ID { get; set; }

        public string NUMER { get; set; }

        public string NAZWA { get; set; }

        public string OPIS { get; set; }

        public float Netto { get; set; }

        public int VAT { get; set; }

        public float KWOTA_VAT { get; set; }

        public float Brutto { get; set; }

        public float SumaBrutto { get; set; }

        public float SumaNetto { get; set; }

        public WorkIdx.TYPE TIME_INDEX { get; set; }

        public int WID { get; set; }

        public string W_NAME { get; set; }

        public int CZAS { get; set; }

        public string USLUGA { get { return NUMER + "   " + NAZWA + ", Cena brutto:" + Brutto + " zł"; }  }

        

    }
}
