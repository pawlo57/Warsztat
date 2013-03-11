using System;
using System.Net;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Seller
{
   [DataContract]
    public class ErrorCode : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        

        public enum CODE
        {
            EXIST,
            SUCCES,
            FAIL,
            LOGIN
        }
    }
}
