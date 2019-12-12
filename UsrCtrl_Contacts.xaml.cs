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


namespace Sailor_6300_Radiotelex_D
{
	/// <summary>
	/// UsrCtrl_Contacts.xaml 的交互逻辑
	/// </summary>
	public partial class UsrCtrl_Contacts : UserControl
	{
		public UsrCtrl_Contacts()
		{
			this.InitializeComponent();
		    Btn_Menu.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Menu_MouseLeftButtonDown), true);
            Btn_Menu.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Menu_MouseLeftButtonUp), true);
            Btn_Contacts_New.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Contacts_New_MouseLeftButtonDown), true);
            Btn_Contacts_New.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Contacts_New_MouseLeftButtonUp), true);
            Btn_New_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_New_OK_MouseLeftButtonDown), true);
            Btn_New_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_New_OK_MouseLeftButtonUp), true);
            Btn_New_Cancle.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_New_Cancle_MouseLeftButtonDown), true);
            Btn_New_Cancle.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_New_Cancle_MouseLeftButtonUp), true);
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
            SB = (Storyboard)Sailor_6300_Radiotelex.m_UC.FindResource("Storyboard_Contacts_close");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
			//this.Visibility=Visibility.Collapsed;
		}
         public void Page_Change(int i)
        {
            Img_Backup.Visibility = Visibility.Collapsed; 
            Img_Coast.Visibility = Visibility.Collapsed;
            Img_Contacts.Visibility = Visibility.Collapsed;
            if (i == 1) Img_Contacts.Visibility = Visibility.Visible;
            else if (i == 2) Img_Coast.Visibility = Visibility.Visible;
            else if (i == 3) Img_Backup.Visibility = Visibility.Visible;
                  
        }

         private void Btn_Contacts_New_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
         {
             Rect_New_pre.Visibility = Visibility.Visible;
         }

         private void Btn_Contacts_New_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
         {
             Rect_New_pre.Visibility = Visibility.Collapsed;
         /*    int j = 0;
                for (int i = 0; i < Sailor_6300_Radiotelex.m_Data.m_Info.ListContacts.Count; i++)
                 {
                     if (Sailor_6300_Radiotelex.m_Data.m_Info.ListContacts[i].cIsRead == true)
                     {
                         j++;
                     }                     
                 }
                if (j == 1)
                {
                    
                }*/
             Storyboard SB2 = new Storyboard();//创建一个故事版
             SB2 = (Storyboard)this.FindResource("Storyboard_Add_new");//从当前xaml的资源中寻找名为Storyboard2的故事版
             SB2.Begin();//播放该故事版
         }

        

        

         private void Btn_New_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
         {
             Rect_OK_pre.Visibility = Visibility.Visible;
         }

         private void Btn_New_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
         {
             Rect_OK_pre.Visibility = Visibility.Collapsed;
         }

         private void Btn_New_Cancle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
         {
             Rect_Cancle_pre.Visibility = Visibility.Visible;
         }

         private void Btn_New_Cancle_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
         {
             Rect_Cancle_pre.Visibility = Visibility.Collapsed;
             Storyboard SB2 = new Storyboard();//创建一个故事版
             SB2 = (Storyboard)this.FindResource("Storyboard_Add_new_close");//从当前xaml的资源中寻找名为Storyboard2的故事版
             SB2.Begin();//播放该故事版
         }

        

        
      
	}
}