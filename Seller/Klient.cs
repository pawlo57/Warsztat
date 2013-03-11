using System;
using System.Net;

namespace Seller
{
    public class Klient
    {
       
        public int ID { get; set; }

       
        public string FIRMA { get; set; }

        
        public string IMIE { get; set; }

        
        public string NAZWISKO { get; set; }

        
        public string ADRES { get; set; }

        
        public string PESEL { get; set; }

        
        public string NIP { get; set; }

        
        public string BANK { get; set; }

        public string TELEFON { get; set; }


        public string LISTA { get { return FIRMA + ", " + IMIE + " " + NAZWISKO + ", " + ADRES; } }


    }
}
