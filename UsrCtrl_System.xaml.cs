using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
using Sailor_6300_Radiotelex_D.Model;
using System.Windows.Controls.Primitives;
using System.Globalization;

namespace Sailor_6300_Radiotelex_D
{
	/// <summary>
	/// UsrCtrl_System.xaml 的交互逻辑
	/// </summary>
	public partial class UsrCtrl_System : UserControl
	{
        public int m_iSystem = 1;
        public int m_iDate = 1;
        public int m_iTime = 12;
        public DispatcherTimer ShowTimer = new DispatcherTimer(); //菜单定时器
		public UsrCtrl_System()
		{
			this.InitializeComponent();
            ShowTimer.Tick += new EventHandler(ShowCurTimer);//起个Timer一直获取当前时间
            ShowTimer.Interval = TimeSpan.FromSeconds(0.1);   //设置刷新的间隔时间
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            ShowTimer.Start();
            Btn_Menu.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Menu_MouseLeftButtonDown), true);
            Btn_Menu.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Menu_MouseLeftButtonUp), true);
            Btn_Sailor6006.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Sailor6006_MouseLeftButtonDown), true);
            Btn_Sailor6006.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Sailor6006_MouseLeftButtonUp), true);
            Btn_Sailor6081.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Sailor6081_MouseLeftButtonDown), true);
            Btn_Sailor6081.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Sailor6081_MouseLeftButtonUp), true);
            Btn_Sailor6006_Legal.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Sailor6006_Legal_MouseLeftButtonDown), true);
            Btn_Sailor6006_Legal.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Sailor6006_Legal_MouseLeftButtonUp), true);
            Btn_Sailor6006_Close.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Sailor6006_Close_MouseLeftButtonDown), true);
            Btn_Sailor6006_Close.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Sailor6006_Close_MouseLeftButtonUp), true);
            Btn_Pw_Settings.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Pw_Settings_MouseLeftButtonDown), true);
            Btn_Pw_Settings.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Pw_Settings_MouseLeftButtonUp), true);
            Btn_Power_Close.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Power_Close_MouseLeftButtonDown), true);
            Btn_Power_Close.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Power_Close_MouseLeftButtonUp), true);
            Btn_Date1.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Date1_MouseLeftButtonDown), true);
            Btn_Date1.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Date1_MouseLeftButtonUp), true);
            Btn_Date2.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Date2_MouseLeftButtonDown), true);
            Btn_Date2.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Date2_MouseLeftButtonUp), true);
            Btn_Date3.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Date3_MouseLeftButtonDown), true);
            Btn_Date3.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Date3_MouseLeftButtonUp), true);
            Btn_Date4.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Date4_MouseLeftButtonDown), true);
            Btn_Date4.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Date4_MouseLeftButtonUp), true);
            Btn_Time12.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Time12_MouseLeftButtonDown), true);
            Btn_Time12.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Time12_MouseLeftButtonUp), true);
            Btn_Time24.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Time24_MouseLeftButtonDown), true);
            Btn_Time24.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Time24_MouseLeftButtonUp), true);
            Btn_Date_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Date_OK_MouseLeftButtonDown), true);
            Btn_Date_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Date_OK_MouseLeftButtonUp), true);
            Btn_Date_Cancle.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Date_Cancle_MouseLeftButtonDown), true);
            Btn_Date_Cancle.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Date_Cancle_MouseLeftButtonUp), true);
            Btn_Screen_Cancle.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Screen_Cancle_MouseLeftButtonDown), true);
            Btn_Screen_Cancle.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Screen_Cancle_MouseLeftButtonUp), true);
            Btn_Screen_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Screen_OK_MouseLeftButtonDown), true);
            Btn_Screen_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Screen_OK_MouseLeftButtonUp), true);
            Btn_Call_settings_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Call_settings_OK_MouseLeftButtonDown), true);
            Btn_Call_settings_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Call_settings_OK_MouseLeftButtonUp), true);
            Btn_Call_settings_Cancle.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Call_settings_Cancle_MouseLeftButtonDown), true);
            Btn_Call_settings_Cancle.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Call_settings_Cancle_MouseLeftButtonUp), true);
            Btn_Password_Cancle.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Password_Cancle_MouseLeftButtonDown), true);
            Btn_Password_Cancle.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Password_Cancle_MouseLeftButtonUp), true);
            Btn_Password_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Password_OK_MouseLeftButtonDown), true);
            Btn_Password_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Password_OK_MouseLeftButtonUp), true);

        }
        public void Page_Change(int i)
        {
            Img_About_pre.Visibility = Visibility.Collapsed;
            Img_Advanced_pre.Visibility = Visibility.Collapsed;
            Img_Power_pre.Visibility = Visibility.Collapsed;
            Img_Settings_pre.Visibility = Visibility.Collapsed;
            if (i == 1) Img_About_pre.Visibility = Visibility.Visible;
            else if (i == 2) Img_Power_pre.Visibility = Visibility.Visible;
            else if (i == 3) Img_Settings_pre.Visibility = Visibility.Visible;
            else if (i == 4) Img_Advanced_pre.Visibility = Visibility.Visible;        
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
            SB = (Storyboard)Sailor_6300_Radiotelex.m_UC.FindResource("Storyboard_System_Close");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
        }

        private void Btn_About_Click(object sender, RoutedEventArgs e)
        {
            Sailor_6300_Radiotelex.m_UC.TB_subhead.Text = "ABOUT";
            Page_Change(1);
            if (m_iSystem == 2)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Power_to_About");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 3)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Settings_to_About");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 4)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Advanced_to_About");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            m_iSystem = 1;
        }

        private void Btn_Power_Click(object sender, RoutedEventArgs e)
        {
            Sailor_6300_Radiotelex.m_UC.TB_subhead.Text = "POWER STATUS";
            Page_Change(2);
            if (m_iSystem == 1)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_About_to_Power");//从当前xaml的资源中寻找故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 3)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Settings_to_Power");//从当前xaml的资源中寻找故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 4)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Advanced_to_Power");//从当前xaml的资源中寻找故事版
                SB.Begin();//播放该故事版
            }
            m_iSystem = 2;
        }

        private void Btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            Sailor_6300_Radiotelex.m_UC.TB_subhead.Text = "SETTINGS";
            Page_Change(3);
            if (m_iSystem == 1)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_About_to_Settings");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 2)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Power_to_Settings");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 4)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Advanced_to_Settings");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            m_iSystem = 3;
        }

        private void Btn_Advaced_Click(object sender, RoutedEventArgs e)
        {
            Sailor_6300_Radiotelex.m_UC.TB_subhead.Text = "ADVANCED";
            Page_Change(4);
            if (m_iSystem == 1)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_About_to_Advanced");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 2)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Power_to_Advanced");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 3)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Settings_to_Advanced");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
            }
            m_iSystem = 4;
        }

        private void Btn_Sailor6006_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Sailor_6006.Visibility = Visibility.Visible;
            Rect_Sailor_6006.Visibility = Visibility.Visible;
            Rect_6006.Visibility = Visibility.Collapsed;
        }

        private void Btn_Sailor6006_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Sailor_6006.Visibility = Visibility.Collapsed;
            Rect_Sailor_6006.Visibility = Visibility.Collapsed;
            Rect_6006.Visibility = Visibility.Visible;
            Cav_Message.Visibility = Visibility.Visible;
            Rect_shadow.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Sailor6006_Message_Open");
            SB.Begin();//播放该故事版
        }

        private void Btn_Sailor6081_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Sailor_6081.Visibility = Visibility.Visible;
            Rect_Sailor_6081.Visibility = Visibility.Visible;
            Rect_6081.Visibility = Visibility.Collapsed;
        }

        private void Btn_Sailor6081_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Sailor_6081.Visibility = Visibility.Collapsed;
            Rect_Sailor_6081.Visibility = Visibility.Collapsed;
            Rect_6081.Visibility = Visibility.Visible;
        }

        private void Btn_Sailor6006_Legal_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rect_Legal_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Sailor6006_Legal_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rect_Legal_pre.Visibility = Visibility.Collapsed;
        }

        private void Btn_Sailor6006_Close_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Cav_Btn_close_Pre.Visibility = Visibility.Visible;
        }

        private void Btn_Sailor6006_Close_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Cav_Btn_close_Pre.Visibility = Visibility.Collapsed; 
           Cav_Message.Visibility = Visibility.Collapsed;
           Rect_shadow.Visibility = Visibility.Collapsed;
        }

        private void Btn_Pw_Settings_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rect_Settings.Visibility = Visibility.Visible;
        }

        private void Btn_Pw_Settings_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rect_Settings.Visibility = Visibility.Collapsed;
            Rect_shadow_Power.Visibility = Visibility.Visible;
            Cav_Power_Settings.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Cav_Power_Open");
            SB.Begin();//播放该故事版
        }

        private void Btn_Power_Close_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Cav_Btn_Close_Power_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Power_Close_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Cav_Btn_Close_Power_pre.Visibility = Visibility.Collapsed;
            Cav_Power_Settings.Visibility = Visibility.Collapsed;
            Rect_shadow_Power.Visibility = Visibility.Collapsed;
        }
        private void Btn_Date_Click(object sender, RoutedEventArgs e)
        {
            
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Date_Settings_Open");
            SB.Begin();//播放该故事版
            
        }
        private void Btn_Date1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_date1.Visibility = Visibility.Collapsed;
            Rect_Date1.Visibility = Visibility.Visible;
           
        }

        private void Btn_Date1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_date1.Visibility = Visibility.Visible;
            Rect_Date1.Visibility = Visibility.Collapsed;
            m_iDate = 1;
            Elp_Change();
        }
        private void Btn_Date2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_date2.Visibility = Visibility.Collapsed;
            Rect_Date2.Visibility = Visibility.Visible;
           
        }

        private void Btn_Date2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_date2.Visibility = Visibility.Visible;
            Rect_Date2.Visibility = Visibility.Collapsed;
            m_iDate = 2;
            Elp_Change();
        }
        private void Btn_Date3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_date3.Visibility = Visibility.Collapsed;
            Rect_Date3.Visibility = Visibility.Visible;
        }

        private void Btn_Date3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_date3.Visibility = Visibility.Visible;
            Rect_Date3.Visibility = Visibility.Collapsed;
            m_iDate = 3;
            Elp_Change();
        }
        private void Btn_Date4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_date4.Visibility = Visibility.Collapsed;
            Rect_Date4.Visibility = Visibility.Visible;
        }

        private void Btn_Date4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_date4.Visibility = Visibility.Visible;
            Rect_Date4.Visibility = Visibility.Collapsed;
            m_iDate = 4;
            Elp_Change();
        }
   
        private void Btn_Time12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_time12.Visibility=Visibility.Collapsed;
            Rect_Time12.Visibility = Visibility.Visible;

        }

        private void Btn_Time12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_time12.Visibility = Visibility.Visible;
            Rect_Time12.Visibility = Visibility.Collapsed;
            m_iTime = 12;
            Elp_Change();
        }

        private void Btn_Time24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_time24.Visibility = Visibility.Collapsed;
            Rect_Time24.Visibility = Visibility.Visible;

        }

        private void Btn_Time24_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_time24.Visibility = Visibility.Visible;
            Rect_Time24.Visibility = Visibility.Collapsed;
            m_iTime = 24;
            Elp_Change();
        }


        private void Btn_Date_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Date_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_pre.Visibility = Visibility.Collapsed;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Date_Settings_Close");
            SB.Begin();//播放该故事版
        }

        private void Btn_Date_Cancle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Date_Cancle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_pre.Visibility = Visibility.Collapsed;          
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Date_Settings_Close");
            SB.Begin();//播放该故事版
        }

        //光标变化
        public void Elp_Change()
        {
            int i = m_iDate;
            int n = m_iTime;
            Elp_1.Visibility = Visibility.Collapsed;
            Elp_2.Visibility = Visibility.Collapsed;
            Elp_3.Visibility = Visibility.Collapsed;
            Elp_4.Visibility = Visibility.Collapsed;
            Elp_12.Visibility = Visibility.Collapsed;
            Elp_24.Visibility = Visibility.Collapsed;

            if (i == 1) Elp_1.Visibility = Visibility.Visible;
            else if (i == 2) Elp_2.Visibility = Visibility.Visible;
            else if (i == 3) Elp_3.Visibility = Visibility.Visible;
            else if (i == 4) Elp_4.Visibility = Visibility.Visible;

            if (n == 12) Elp_12.Visibility = Visibility.Visible;
            else if (n == 24) Elp_24.Visibility = Visibility.Visible;
        }

       //时间格式转换
        public void ShowCurTimer(object sender, EventArgs e)
        {
            int m = m_iDate;
            int n = m_iTime;
            if (n == 12)
            {
                if (m == 1)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("dd MMM yyyy hh:mm tt", DateTimeFormatInfo.InvariantInfo);
                }
                else if (m == 2)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("MM/dd-yyyy hh:mm tt", DateTimeFormatInfo.InvariantInfo);
                }
                else if (m == 3)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("dd/MM-yyyy hh:mm tt", DateTimeFormatInfo.InvariantInfo);
                }
                else if (m == 4)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt", DateTimeFormatInfo.InvariantInfo);
                }
            }
            else if (n == 24)
            {
                if (m == 1)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm", DateTimeFormatInfo.InvariantInfo);
                }
                else if (m == 2)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("MM/dd-yyyy HH:mm", DateTimeFormatInfo.InvariantInfo);
                }
                else if (m == 3)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("dd/MM-yyyy HH:mm", DateTimeFormatInfo.InvariantInfo);
                }
                else if (m == 4)
                {
                    this.TB_Date_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm", DateTimeFormatInfo.InvariantInfo);
                }
            }
          
            
        }
        public void Open_Battery()
        {
            Sailor_6300_Radiotelex.m_UC.TB_main.Text = "SYSTEM";
            Sailor_6300_Radiotelex.m_UC.TB_subhead.Text = "POWER STATUS";
            Page_Change(2);
            if (m_iSystem == 1)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_About_to_Power");//从当前xaml的资源中寻找故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 3)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Settings_to_Power");//从当前xaml的资源中寻找故事版
                SB.Begin();//播放该故事版
            }
            else if (m_iSystem == 4)
            {
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Advanced_to_Power");//从当前xaml的资源中寻找故事版
                SB.Begin();//播放该故事版
            }
            m_iSystem = 2;           
        }
		 private void TB_Callcode_PreviewKeyDown_NumberOnly(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.Key == Key.Back
                || e.Key == Key.D0 || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4
                || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9
                || e.Key == Key.NumPad0 || e.Key == Key.NumPad1 || e.Key == Key.NumPad2 || e.Key == Key.NumPad3 || e.Key == Key.NumPad4
                || e.Key == Key.NumPad5 || e.Key == Key.NumPad6 || e.Key == Key.NumPad7 || e.Key == Key.NumPad8 || e.Key == Key.NumPad9
                || e.Key == Key.Delete
                )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
       
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                TextBox tbx = sender as TextBox;
                tbx.SelectAll();
                tbx.PreviewMouseDown -= new MouseButtonEventHandler(TextBox_PreviewMouseDown);

            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.PreviewMouseDown += new MouseButtonEventHandler(TextBox_PreviewMouseDown);
            }
        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.Focus();
                e.Handled = true;
            }
        }

        private void Btn_Screen_Click(object sender, RoutedEventArgs e)
        {
            Edit_Screen.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Edit_Screen_open");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版
        }

        private void Btn_Screen_Cancle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_screen_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Screen_Cancle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_screen_pre.Visibility = Visibility.Collapsed;
            Edit_Screen.Visibility = Visibility.Collapsed;
        }

        private void Btn_Screen_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_screen_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Screen_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_screen_pre.Visibility = Visibility.Collapsed;
            Edit_Screen.Visibility = Visibility.Collapsed;
        }

        private void Btn_Call_Settings_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Edit_Call_settings.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Eridt_Call_settings");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版
        }

        private void Btn_Call_settings_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_call_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Call_settings_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_call_pre.Visibility = Visibility.Collapsed;
            Edit_Call_settings.Visibility = Visibility.Collapsed;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Eridt_Call_settings_close");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版

        }

        private void Btn_Call_settings_Cancle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_call_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Call_settings_Cancle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {            
            Rect_Cancle_call_pre.Visibility = Visibility.Collapsed;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Eridt_Call_settings_close");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版
            Edit_Call_settings.Visibility = Visibility.Collapsed;
        }
        //****************************************************
       
        private void Btn_Password_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_password_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Password_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_OK_password_pre.Visibility = Visibility.Collapsed;
            Password.Visibility = Visibility.Collapsed;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Password_close");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版

        }

        private void Btn_Password_Cancle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_password_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Password_Cancle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_Cancle_password_pre.Visibility = Visibility.Collapsed;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Password_close");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版
            Password.Visibility = Visibility.Collapsed;
        }

        private void Btn_Identification_Click(object sender, RoutedEventArgs e)
        {
            Password.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Password");//从当前xaml的资源中寻找故事版
            SB.Begin();//播放该故事版
        }
     
        
      
        
	}
}