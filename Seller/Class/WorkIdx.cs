using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller.Class
{
    public class WorkIdx
    {
        public string JEDNOSTKA_CZASU { get; set; }

        public TYPE ID { get; set; }

        public enum TYPE
        {
            SELECT,
            MINUTA,
            GODZINA,
            DZIEN,
            MIESIAC
        }

        
    }
}
