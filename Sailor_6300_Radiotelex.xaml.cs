using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Media.Animation;
using Sailor_6300_Radiotelex_D.ViewModel;

namespace Sailor_6300_Radiotelex_D
{
    /// <summary>
    /// Interaction logic for Sailor_6300_Radiotelex.xaml
    /// </summary>
    public partial class Sailor_6300_Radiotelex : UserControl
    {
        public static UsrCtrl_Basic m_UC = new UsrCtrl_Basic();
        
        public static ViewModel_Sailor6300 m_Data = new ViewModel_Sailor6300();//2017年5月3日17:38:39关于MVVM模式
        public Sailor_6300_Radiotelex()
        {
            InitializeComponent();
            this.DataContext = m_Data;
            m_SP.Children.Clear();
            m_SP.Children.Add(m_UC);
        }
    }
}
