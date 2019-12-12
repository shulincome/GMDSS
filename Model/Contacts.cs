using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Sailor_6300_Radiotelex_D.common;

namespace Sailor_6300_Radiotelex_D.Model
{
    public class _Contacts : INotifyPropertyChanged
    {
        //Name
        private string _str_cName;
        public string str_cName
        {
            get { return _str_cName; }
            set
            {
                _str_cName = value;
                NotifyPropertyChanged("str_cName");
            }
        }
        //MMSI
        private string _str_CallCode;
        public string str_CallCode
        {
            get { return _str_CallCode; }
            set
            {
                _str_CallCode = value;
                NotifyPropertyChanged("str_CallCode");
            }
        }
        //Selcall
        private string _str_SelCall;
        public string str_SelCall
        {
            get { return _str_SelCall; }
            set
            {
                _str_SelCall = value;
                NotifyPropertyChanged("str_SelCall");
            }
        }
        //CheckBox
        private bool _cIsRead;

        public bool cIsRead
        {
            get { return _cIsRead; }
            set
            {
                _cIsRead = value;
                NotifyPropertyChanged("cIsRead");
            }
        }
        
        //临时数据
        private string _str_cName_temp;
        public string str_cName_temp
        {
            get { return _str_cName_temp; }
            set
            {
                _str_cName_temp = value;
                NotifyPropertyChanged("str_cName_temp");
            }
        }
        //MMSI_temp
        private string _str_CallCode_temp;
        public string str_CallCode_temp
        {
            get { return _str_CallCode_temp; }
            set
            {
                _str_CallCode_temp = value;
                NotifyPropertyChanged("str_CallCode_temp");
            }
        }
        //Selcall_temp
        private string _str_SelCall_temp;
        public string str_SelCall_temp
        {
            get { return _str_SelCall_temp; }
            set
            {
                _str_SelCall_temp = value;
                NotifyPropertyChanged("str_SelCall_temp");
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
