using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawel.Workshop.Entities
{
    public class Good
    {
        public Good() { }

        public Good(int Id, int categoryID, string catalogueNumber, string model, string serialNumber, string description, string name, string unit, 
            decimal bruttoPriceSell, decimal bruttoPriceBuy, int vat)
            : this()
        {
            this.Id = Id;
            this.categoryID = categoryID;
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

        public int Id { get; set; }

        public int categoryID { get; set; }

        public Kontrahent kontrahent { get; set; }

        public string catalogueNumber { get; set; }

        public string model { get; set; }

        public string serialNumber { get; set; }

        public string description { get; set; }

        public string name { get; set; }

        public string unit { get; set; }

        public int priceId { get; set; }

        public bool isGoodName
        {
            get
            {
                return string.IsNullOrWhiteSpace(this.name);
            }
        }

        private decimal _nettoPriceSell = -1;
        public decimal nettoPriceSell
        {
            get
            {
                return _bruttoPriceSell < 0 ? _nettoPriceSell : (vatMuller == 0 ? _bruttoPriceSell : decimal.Round(_bruttoPriceSell / vatMuller, 2));
            }
            set
            {
                _nettoPriceSell = value;
            }
        }

        private decimal _bruttoPriceSell = -1;
        public decimal bruttoPriceSell
        {
            get
            {
                return _nettoPriceSell <= 0 ? _bruttoPriceSell : decimal.Round(_nettoPriceSell * vatMuller, 2);   
            }
            set
            {
                _bruttoPriceSell = value;
            }
        }

        private decimal _nettoPriceBuy = -1;
        public decimal nettoPriceBuy
        {
            get
            {
                return decimal.Round(vatMuller == 0.00M ? _bruttoPriceBuy : _bruttoPriceBuy / vatMuller, 2);
            }
            set
            {
                _nettoPriceBuy = value;
            }

        }

        private decimal _bruttoPriceBuy;
        public decimal bruttoPriceBuy
        {
            get
            {
                return _nettoPriceBuy < 0.00M ? _bruttoPriceBuy : decimal.Round(_nettoPriceBuy * vatMuller, 2);
            }

            set
            {
                _bruttoPriceBuy = value;
            }
        }

        public int vat { get; set; }

        private decimal vatMuller
        {
            get
            {
                return ((decimal)100 + vat) / 100;
            }
        }
        
    }
}
