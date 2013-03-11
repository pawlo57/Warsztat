using System;
using System.Net;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Seller
{
    [DataContract]

    public class Mgzyn : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int PID { get; set; }

        [DataMember]
        public int UID { get; set; }

        [DataMember]
        public string TYPE { get; set; }

        [DataMember]
        public int COUNT { get; set; }

        [DataMember]
        public string DATA { get; set; }

        [DataMember]
        public int MID { get; set; }

        [DataMember]
        public string MAGAZYN { get; set; }

        [DataMember]
        public string ADRES { get; set; }
    }
}
