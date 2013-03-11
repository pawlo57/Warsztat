using System;
using System.Net;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Seller
{
    [DataContract]

    public class Statystyka : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [DataMember]
        public string Pracownik { get; set; }

        [DataMember]
        public string Ilosc { get; set; }

        [DataMember]
        public string Kwota { get; set; }

    }
}
