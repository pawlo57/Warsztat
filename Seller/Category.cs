using System;
using System.Net;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Seller
{
    [DataContract]

    public class Category : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string NAME { get; set; }
    }
}
