using System;
using System.Collections.Generic;
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
using System.Windows.Media.Animation;
using Sailor_6300_Radiotelex_D.ViewModel;
using Sailor_6300_Radiotelex_D.Model;
using System.Windows.Controls.Primitives;
using System.Globalization;

namespace Sailor_6300_Radiotelex_D
{
	/// <summary>
	/// UsrCtrl_Scan.xaml 的交互逻辑
	/// </summary>
	public partial class UsrCtrl_Scan : UserControl
	{
		public UsrCtrl_Scan()
		{
			this.InitializeComponent();
            Btn_Menu.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Menu_MouseLeftButtonDown), true);
            Btn_Menu.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Menu_MouseLeftButtonUp), true);
            Btn_Scan_list.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Scan_list_MouseLeftButtonDown), true);
            Btn_Scan_list.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Scan_list_MouseLeftButtonUp), true);
            Btn_Edit_list.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Edit_list_MouseLeftButtonDown), true);
            Btn_Edit_list.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Edit_list_MouseLeftButtonUp), true);

		}

        private void Btn_Menu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Img_Menu_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Menu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Img_Menu_pre.Visibility = Visibility.Collapsed;
            Sailor_6300_Radiotelex.m_UC.TB_main.Text = "GMDSS";
            Sailor_6300_Radiotelex.m_UC.TB_subhead.Text = "RADIOTELEX";
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)Sailor_6300_Radiotelex.m_UC.FindResource("Storyboard_UsrCtrl_Scan_Close");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
			this.Visibility=Visibility.Collapsed;
        }
        private void Btn_Scan_list_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Img_Scan_list_pre.Visibility = Visibility.Collapsed;
        }

        private void Btn_Scan_list_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Img_Scan_list_pre.Visibility = Visibility.Visible;
        }
        private void Btn_Edit_list_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Edit_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Edit_list_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_Edit_pre.Visibility = Visibility.Collapsed;
        }
	}
}