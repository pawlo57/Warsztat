//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pawel.Workshop.Database.Database_model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uslugi
    {
        public string Opis { get; set; }
        public int ID { get; set; }
        public Nullable<decimal> Netto { get; set; }
        public Nullable<int> VAT { get; set; }
        public Nullable<decimal> Brutto { get; set; }
        public string Numer { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> TimeIndex { get; set; }
    }
}
