using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Sailor_6300_Radiotelex_D.common;

namespace Sailor_6300_Radiotelex_D.Model
{
    public class _Sendtext : INotifyPropertyChanged
    {
        
        private string _str_Callcode;
        public string str_Callcode
        {
            get { return _str_Callcode; }
            set
            {
                _str_Callcode = value;
                NotifyPropertyChanged("str_Callcode");
            }
        }
        private string _str_TX;
        public string str_TX
        {
            get { return _str_TX; }
            set
            {
                _str_TX = value;
                NotifyPropertyChanged("str_TX");
            }
        }
        private string _str_RX;
        public string str_RX
        {
            get { return _str_RX; }
            set
            {
                _str_RX = value;
                NotifyPropertyChanged("str_RX");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
