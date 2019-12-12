using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Sailor_6300_Radiotelex_D.common;

namespace Sailor_6300_Radiotelex_D.Model
{
    public class _CallCode:INotifyPropertyChanged
    {
        private string _Callcode;
        public string Callcode
        {
            get { return _Callcode; }
            set
            {
                _Callcode = value;
                NotifyPropertyChanged("Callcode");
            }
        }
        private string _TX_freq;
        public string TX_freq
        {
            get { return _TX_freq; }
            set
            {
                _TX_freq = value;
                NotifyPropertyChanged("TX_freq");
            }
        }
        private string _RX_freq;
        public string RX_freq
        {
            get { return _RX_freq; }
            set
            {
                _RX_freq = value;
                NotifyPropertyChanged("RX_freq");
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
