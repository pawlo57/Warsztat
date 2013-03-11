using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller.Class
{
    public class CmentarzCls
    {
        public int ID { get; set; }

        public string NAZWA { get; set; }

        public string ADRES { get; set; }

        public string CMENTARZ { get { return NAZWA + ", " + ADRES; } }
    }
}
