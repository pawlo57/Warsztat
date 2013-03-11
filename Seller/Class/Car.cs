using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller.Class
{
    public class Car
    {
        public int ID { get; set; }

        public int CID { get; set; }

        public string MARKA { get; set; }

        public string MODEL { get; set; }

        public string POJEMNOSC { get; set; }

        public string TYP { get; set; }

        public string ROK { get; set; }

        public string REJESTRACJA { get; set; }

        public string VIN { get; set; }

        public string OPIS { get; set; }

        public string SILNIK { get; set; }

        public string BADANIE { get; set; }

        public int STAN_LICZNIKA { get; set; }

        public int STAN_PALIWA { get; set; }

        public string DATA_PRZYJECIA { get; set; }

        public string DATA_WYDANIA { get; set; }

        public int DOWOD { get; set; }

        public string KONTRAHENT { get; set; }

        public string SAMOCHOD { get { return MARKA + " " + MODEL + " " + POJEMNOSC + " " + REJESTRACJA; } }
    }
}
