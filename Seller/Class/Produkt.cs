using System;
using System.Net;

namespace Seller
{
    public class Produkt
    {

        public int ID { get; set; }

        public int CID { get; set; }

        
        public string NAME { get; set; }

        
        public string DESCRIPTION { get; set; }


        
        public float PRICE { get; set; }

        
        public float VATPRICE { get; set; }

        public float PRICE2 { get; set; }

        public float VATPRICE2 { get; set; }

        
        public string CNAME { get; set; }

        
        public string NUMERKAT { get; set; }

        
        public string MODEL { get; set; }

        
        public string NUMERSER { get; set; }

        
        public string OPIS { get; set; }

        
        public int CATID { get; set; }

        
        public float COUNT { get; set; }

       
        public string JEDNOSTKA { get; set; }

        
        public float STAN { get; set; }

        
        public float SUMA { get; set; }

        
        public int PID { get; set; }

        
        public int MID { get; set; }

        
        public string MAGAZYN { get; set; }

       
        public string MAGAZYNADRES { get; set; }

        
        public string CATNAME { get; set; }

        
        public int PZWZID { get; set; }

        
        public int UID { get; set; }

        
        public int TYPE { get; set; }

        
        public string DATA { get; set; }

       
        public string UNAME { get; set; }

        
        public int TIID { get; set; }

        
        public int IID { get; set; }

        
        public float SUMA_NETTO { get; set; }

        
        public float SUMA_BRUTTO { get; set; }

       
        public float PROWIZJA { get; set; }

       
        public int PLATNOSC { get; set; }

        
        public string UWAGI { get; set; }

        public float KWOTA_VAT { get; set; }

        public string TOWAR { get { return NAME + ", Magazyn:" + MAGAZYN + ", Cena brutto:" + VATPRICE2 + " zł"; } }

        public string CZESC { get { return "Numer kat.: " + NUMERKAT + ", Nazwa: " + NAME + ", Cena brutto:" + VATPRICE + " zł"; } }



    }
}

