using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller.Class
{
    public class FakturaTyp
    {
        public enum TYPE
        {
            Faktura,
            Korygująca,
            Korygująca_anulowana,
            Paragon,
            Rachunek_uproszczony
        }
    }
}
