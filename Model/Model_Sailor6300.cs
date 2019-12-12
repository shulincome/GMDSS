using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Animation;
using System.Media;
using System.Windows.Navigation;
using System.Timers;
using System.Windows.Threading;
using System.ComponentModel;



using Sailor_6300_Radiotelex_D.common;

namespace Sailor_6300_Radiotelex_D.Model
{
    public class Model_Sailor6300 : INotifyPropertyChanged
    {


        private string _str_Test;
        public string str_Test
        {
            get { return _str_Test; }
            set
            {
                _str_Test = value;
                NotifyPropertyChanged("str_Test");
            }
        }
       

     //短信
        private List<_Msg_Save> _ListMsg = new List<_Msg_Save>();

        public List<_Msg_Save> ListMsg
        {
            get { return _ListMsg; }
            set
            {
                _ListMsg = value;
                NotifyPropertyChanged("ListMsg");
            }
        }

        //通讯录
        private List<_Contacts> _ListContacts = new List<_Contacts>();

        public List<_Contacts> ListContacts
        {
            get { return _ListContacts; }
            set
            {
                _ListContacts = value;
                NotifyPropertyChanged("ListContacts");
            }
        }


        private int _i_ListContacts_Select;
        public int i_ListContacts_Select
        {
            get { return _i_ListContacts_Select; }
            set
            {
                _i_ListContacts_Select = value;
                NotifyPropertyChanged("i_ListContacts_Select");
            }
        }

        private int _i_ListMsg_Select;
        public int i_ListMsg_Select
        {
            get { return _i_ListMsg_Select; }
            set
            {
                _i_ListMsg_Select = value;
                NotifyPropertyChanged("i_ListMsg_Select");
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
