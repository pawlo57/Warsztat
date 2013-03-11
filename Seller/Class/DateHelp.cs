using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller.Class
{
    public static class DateHelp
    {
       
        public static string GetDate(DateTime date)
        {
            string data = date.Year + "-";
            if (date.Month < 10) data += "0" + date.Month + "-";
            else data += date.Month + "-";

            if (date.Day < 10) data += "0" + date.Day;
            else data += date.Day;

            return data;
        }
    }
}
