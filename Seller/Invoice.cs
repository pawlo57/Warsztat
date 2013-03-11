using System;
using System.Net;
using Seller.Class;

namespace Seller
{
    public class Invoice
    {
       
        public int ID { get; set; }

    
        public string NUMER { get; set; }

        
        public float PRICE { get; set; }

        
        public float VATPRICE { get; set; }

        
        public int CID { get; set; }

        
        public string CNAME { get; set; }

        
        public int WID { get; set; }

        
        public string WNAME { get; set; }

        
        public int UID { get; set; }

        
        public string UNAME { get; set; }

        
        public string DATA { get;set; }

        
        public string DATA_ZWROTU { get; set; }

        
        public int STATUS { get; set; }

        
        public string ACTIVATED { get; set; }

        
        public string ACTIVDATA { get; set; }

        public string TERMIN { get; set; }

        public string TERMIN_UKONCZENIA { get; set; }

        
        public float SUMA_PROWIZJI { get; set; }

        
        public int PLATNOSC { get; set; }

        
        public string UWAGI { get; set; }

        
        public FakturaTyp.TYPE TYP_FAKTURY { get; set; }

        public string TYP_FAKTURY_NAZWA { get; set; }

        public float ILOSC_SZTUK { get; set; }

        public int CARID { get; set; }

        public string CAR_NAME { get; set; }

        public int Licznik { get; set; }

        public int Paliwo { get; set; }

        public int Dowod { get; set; }
    }
}
 