using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawel.Workshop.Entities
{
    public class Good
    {
        public Good() { }

        public Good(int ID, int categoryID, int customerID, string catalogueNumber, string model, string serialNumber, string description, string name, string unit, 
            decimal bruttoPriceSell, decimal bruttoPriceBuy, int vat)
            : this()
        {
            this.ID = ID;
            this.categoryID = categoryID;
            this.customerID = customerID;
            this.catalogueNumber = catalogueNumber;
            this.model = model;
            this.serialNumber = serialNumber;
            this.description = description;
            this.name = name;
            this.unit = unit;
            this.bruttoPriceSell = bruttoPriceSell;
            this.bruttoPriceBuy = bruttoPriceBuy;
            this.vat = vat;
        }

        public int ID { get; set; }

        public int categoryID { get; set; }

        public int customerID { get; set; }

        public string catalogueNumber { get; set; }

        public string model { get; set; }

        public string serialNumber { get; set; }

        public string description { get; set; }

        public string name { get; set; }

        public string unit { get; set; }

        public decimal bruttoPriceSell { get; set; }

        public decimal bruttoPriceBuy { get; set; }

        public int vat { get; set; }

        public decimal nettoPriceSell
        {
            get
            {
                try 
                {
                    return decimal.Round(bruttoPriceSell / vatMuller, 2);
                }
                catch { return -1; }
            }
        }

        public decimal nettoPriceBuy
        {
            get
            {
                try
                {
                    return decimal.Round(bruttoPriceBuy / vatMuller, 2);
                }
                catch { return -1; }
            }
        }

        private decimal vatMuller
        {
            get
            {
                return ((decimal)100 + vat) / 100;
            }
        }
        
    }
}
