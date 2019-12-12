using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Sailor_6300_Radiotelex_D.common;


namespace Sailor_6300_Radiotelex_D.Model
{


    public class _Msg_Save : INotifyPropertyChanged
    {
        private bool _bIsRead;

        public bool bIsRead
        {
            get { return _bIsRead; }
            set
            {
                _bIsRead = value;
                NotifyPropertyChanged("bIsRead");
            }
        }
        private string _str_Name;
        public string str_Name
        {
            get { return _str_Name; }
            set
            {
                _str_Name = value;
                NotifyPropertyChanged("str_Name");
            }
        }
        private string _str_Content;
        public string str_Content
        {
            get { return _str_Content; }
            set
            {
                _str_Content = value;
                NotifyPropertyChanged("str_Content");
            }
        }
        private string _str_Content_temp;
        public string str_Content_temp
        {
            get { return _str_Content_temp; }
            set
            {
                _str_Content_temp = value;
                NotifyPropertyChanged("str_Content_temp");
            }
        }
        public bool _isAuto;
        public bool isAuto
        {
            get { return _isAuto; }
            set
            {
                _isAuto = value;
                NotifyPropertyChanged("isAuto");
            }
        }
        public bool _isAuto_tmp;
        public bool isAuto_tmp
        {
            get { return _isAuto_tmp; }
            set
            {
                _isAuto_tmp = value;
                NotifyPropertyChanged("isAuto_tmp");
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
