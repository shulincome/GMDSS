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

namespace Sailor_6300_Radiotelex_D
{
	/// <summary>
    /// Msg_Sendtext.xaml 的交互逻辑
	/// </summary>
	public partial class Msg_Sendtext : UserControl
	{
		public int BL_Call_setup=1;
		public int BL_Channel=1;
		public Msg_Sendtext()
		{
			this.InitializeComponent();
		  Btn_ARQ.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_ARQ_MouseLeftButtonDown), true);
          Btn_ARQ.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_ARQ_MouseLeftButtonUp), true);
          Btn_Selective.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Selective_MouseLeftButtonDown), true);
          Btn_Selective.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Selective_MouseLeftButtonUp), true);
          Btn_Broadcast.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Broadcast_MouseLeftButtonDown), true);
          Btn_Broadcast.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Broadcast_MouseLeftButtonUp), true);
          Btn_Call.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Call_MouseLeftButtonDown), true);
          Btn_Call.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Call_MouseLeftButtonUp), true);
          Btn_Cancel.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Cancel_MouseLeftButtonDown), true);
          Btn_Cancel.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Cancel_MouseLeftButtonUp), true);
          Btn_Manual.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Manual_MouseLeftButtonDown), true);
          Btn_Manual.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Manual_MouseLeftButtonUp), true);
          Btn_Distress.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Distress_MouseLeftButtonDown), true);
          Btn_Distress.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Distress_MouseLeftButtonUp), true);
		  Btn_Intership.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Intership_MouseLeftButtonDown), true);
          Btn_Intership.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Intership_MouseLeftButtonUp), true);
		  Btn_Coaststation.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Coaststation_MouseLeftButtonDown), true);
          Btn_Coaststation.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Coaststation_MouseLeftButtonUp), true);
		  Btn_Contacts.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Contacts_MouseLeftButtonDown), true);
          Btn_Contacts.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Contacts_MouseLeftButtonUp), true);
		  Btn_CoastContacts.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_CoastContacts_MouseLeftButtonDown), true);
          Btn_CoastContacts.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_CoastContacts_MouseLeftButtonUp), true);
		}

		private void Btn_ARQ_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            ARQ.Visibility = Visibility.Collapsed;
            ARQ_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_ARQ_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			ARQ.Visibility = Visibility.Visible;
            ARQ_Copy.Visibility = Visibility.Collapsed;
			//控制绿点的效果
			Elp_A.Visibility=Visibility.Visible;
			Elp_S.Visibility=Visibility.Collapsed;
			Elp_B.Visibility=Visibility.Collapsed;
            Elp_Coast.Visibility = Visibility.Collapsed;
            Elp_Distress.Visibility = Visibility.Collapsed;
            Elp_Intership.Visibility = Visibility.Collapsed;
            Elp_Manual.Visibility = Visibility.Visible;
			//控制频率输入框的效果
			TX_freq.Visibility=Visibility.Visible;
			RX_freq.Visibility=Visibility.Visible;
			Call_code.Visibility=Visibility.Visible;
			TX_freq_B.Visibility=Visibility.Collapsed;
			Channel.Visibility=Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
             BL_Call_setup=1;
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
		}

		private void Btn_Selective_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			selective.Visibility = Visibility.Collapsed;
			selective_Copy.Visibility = Visibility.Visible;
		}

        private void Btn_Selective_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			selective.Visibility = Visibility.Visible;
			selective_Copy.Visibility = Visibility.Collapsed;
			//控制绿点的效果
			Elp_A.Visibility=Visibility.Collapsed;
			Elp_S.Visibility=Visibility.Visible;
			Elp_B.Visibility=Visibility.Collapsed;
            Elp_Coast.Visibility = Visibility.Collapsed;
            Elp_Distress.Visibility = Visibility.Collapsed;
            Elp_Intership.Visibility = Visibility.Collapsed;
            Elp_Manual.Visibility = Visibility.Visible;
			//控制频率输入框的效果
			TX_freq.Visibility=Visibility.Visible;
			RX_freq.Visibility=Visibility.Collapsed;
			Call_code.Visibility=Visibility.Visible;
			TX_freq_B.Visibility=Visibility.Collapsed;
			Channel.Visibility=Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
			BL_Call_setup=2;
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
		}

		private void Btn_Broadcast_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			broadcast.Visibility = Visibility.Collapsed;
			broadcast_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Broadcast_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			broadcast.Visibility = Visibility.Visible;
			broadcast_Copy.Visibility = Visibility.Collapsed;
			//控制绿点的效果
			Elp_A.Visibility=Visibility.Collapsed;
			Elp_S.Visibility=Visibility.Collapsed;
			Elp_B.Visibility=Visibility.Visible;
            Elp_Coast.Visibility = Visibility.Collapsed; 
            Elp_Distress.Visibility = Visibility.Collapsed;
            Elp_Intership.Visibility = Visibility.Collapsed;
            Elp_Manual.Visibility = Visibility.Visible;
			//控制频率输入框的效果
			TX_freq.Visibility=Visibility.Collapsed;
			RX_freq.Visibility=Visibility.Collapsed;
			Call_code.Visibility=Visibility.Collapsed;
			TX_freq_B.Visibility=Visibility.Visible;
			Channel.Visibility=Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
            TB_TX_broad.Text = TB_TX.Text;
			BL_Call_setup=3;
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
		}
        private void Btn_Contacts_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			contacts.Visibility = Visibility.Collapsed;
			contacts_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Contacts_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			contacts.Visibility = Visibility.Visible;
			contacts_Copy.Visibility = Visibility.Collapsed;
		}
		private void Btn_CoastContacts_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			coast_contacts.Visibility = Visibility.Collapsed;
			coast_contacts_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_CoastContacts_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			coast_contacts.Visibility = Visibility.Visible;
			coast_contacts_Copy.Visibility = Visibility.Collapsed;
		}
		private void Btn_Manual_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			manual.Visibility = Visibility.Collapsed;
			manual_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Manual_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{//边框特效
			manual.Visibility = Visibility.Visible;
			manual_Copy.Visibility = Visibility.Collapsed;
			Elp_Manual.Visibility=Visibility.Visible;
			Elp_Intership.Visibility=Visibility.Collapsed;
			Elp_Coast.Visibility=Visibility.Collapsed;
			Elp_Distress.Visibility=Visibility.Collapsed;
            //全局隐藏
            Call_code.Visibility = Visibility.Collapsed;
            TX_freq.Visibility = Visibility.Collapsed;
            RX_freq.Visibility = Visibility.Collapsed;
            TX_freq_B.Visibility = Visibility.Collapsed;
            Channel.Visibility = Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
			if(BL_Call_setup==1)
			{
                Call_code.Visibility = Visibility.Visible;
			    TX_freq.Visibility=Visibility.Visible;
			    RX_freq.Visibility=Visibility.Visible;
			    BL_Channel=1;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
			}
            if (BL_Call_setup == 2)
            {
                Call_code.Visibility = Visibility.Visible;
                TX_freq.Visibility = Visibility.Visible;
                BL_Channel = 1;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
            }
            if (BL_Call_setup == 3)
            {
                TX_freq_B.Visibility = Visibility.Visible;
                BL_Channel = 1;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
            }
		}

		private void Btn_Intership_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{//边框特效
			intership.Visibility = Visibility.Visible;
			intership_Copy.Visibility = Visibility.Collapsed;
			Elp_Manual.Visibility=Visibility.Collapsed;
			Elp_Intership.Visibility=Visibility.Visible;
			Elp_Coast.Visibility=Visibility.Collapsed;
			Elp_Distress.Visibility=Visibility.Collapsed;
			//channel变换
            Call_code.Visibility = Visibility.Collapsed;
            TX_freq.Visibility = Visibility.Collapsed;
            RX_freq.Visibility = Visibility.Collapsed;
            TX_freq_B.Visibility = Visibility.Collapsed;
            Channel.Visibility = Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
			if(BL_Call_setup==1)
			{
                Call_code.Visibility = Visibility.Visible;
			    Channel.Visibility=Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
			    BL_Channel=2;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(2);
			}
            if (BL_Call_setup == 2)
            {
                Call_code.Visibility = Visibility.Visible;                
                TB_TX_load.Visibility = Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Collapsed;
                Channel.Visibility = Visibility.Visible;
                BL_Channel = 2;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(2);
            }
            if (BL_Call_setup == 3)
            {
                Call_code.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Collapsed;
                Channel.Visibility = Visibility.Visible;
                BL_Channel = 2;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(2);
            }

		}
		private void Btn_Intership_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			intership.Visibility = Visibility.Collapsed;
			intership_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Coaststation_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            //边框特效
			coast_station.Visibility = Visibility.Visible;
			coast_station_Copy.Visibility = Visibility.Collapsed;
			Elp_Manual.Visibility=Visibility.Collapsed;
			Elp_Intership.Visibility=Visibility.Collapsed;
			Elp_Coast.Visibility=Visibility.Visible;
			Elp_Distress.Visibility=Visibility.Collapsed;
			//channel变换
            Call_code.Visibility = Visibility.Collapsed;
            TX_freq.Visibility = Visibility.Collapsed;
            RX_freq.Visibility = Visibility.Collapsed;
            TX_freq_B.Visibility = Visibility.Collapsed;
            Channel.Visibility = Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
			if(BL_Call_setup==1)
			{
                Call_code.Visibility = Visibility.Visible;               
                TB_RX_load.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
                Channel.Visibility = Visibility.Visible;
			    BL_Channel=3;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(3);
			}
            if (BL_Call_setup == 2)
            {
                Call_code.Visibility = Visibility.Visible;                
                TB_TX_load.Visibility = Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Collapsed;
                Channel.Visibility = Visibility.Visible;
                BL_Channel = 3;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(3);
            }
            if (BL_Call_setup == 3)
            {
                Call_code.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Collapsed;
                Channel.Visibility = Visibility.Visible;
                BL_Channel = 3;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(3);
            }
		}
		private void Btn_Coaststation_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			coast_station.Visibility = Visibility.Collapsed;
			coast_station_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Distress_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{    //边框特效
			distress.Visibility = Visibility.Visible;
			distress_Copy.Visibility = Visibility.Collapsed;
			Elp_Manual.Visibility=Visibility.Collapsed;
			Elp_Intership.Visibility=Visibility.Collapsed;
			Elp_Coast.Visibility=Visibility.Collapsed;
			Elp_Distress.Visibility=Visibility.Visible;
			//channel变换
            Call_code.Visibility = Visibility.Collapsed;
            TX_freq.Visibility = Visibility.Collapsed;
            RX_freq.Visibility = Visibility.Collapsed;
            TX_freq_B.Visibility = Visibility.Collapsed;
            Channel.Visibility = Visibility.Collapsed;
            Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
			if(BL_Call_setup==1)
			{
                Call_code.Visibility = Visibility.Visible;
			    Channel.Visibility=Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
			    BL_Channel=4;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(4);
			}
            else if (BL_Call_setup == 2)
            {
                Call_code.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Collapsed;
                Channel.Visibility = Visibility.Visible;
                BL_Channel = 4;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(4);
            }
            else if (BL_Call_setup == 3)
            {
                Call_code.Visibility = Visibility.Visible;
                TB_TX_load.Visibility = Visibility.Visible;
                TB_RX_load.Visibility = Visibility.Collapsed;
                Channel.Visibility = Visibility.Visible;
                BL_Channel = 4;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Edit_value.Change_Channel();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Edit_value.Change_Channel();
                ChannelRules(4);
            }
		}
		private void Btn_Distress_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			distress.Visibility = Visibility.Collapsed;
			distress_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Call_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			call.Visibility = Visibility.Visible;
			call_Copy.Visibility = Visibility.Collapsed;
      //      Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.Change_usercontrol(0);
            
		}
		private void Btn_Call_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			call.Visibility = Visibility.Collapsed;
			call_Copy.Visibility = Visibility.Visible;
		}

		private void Btn_Cancel_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			cancel.Visibility = Visibility.Visible;
			cancel_Copy.Visibility = Visibility.Collapsed;
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message") Sailor_6300_Radiotelex.m_UC.Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
			this.Visibility=Visibility.Collapsed;
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Call")
            {
                Sailor_6300_Radiotelex.m_UC.Close_Call();
            
            }
		}
		private void Btn_Cancel_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			cancel.Visibility = Visibility.Collapsed;
			cancel_Copy.Visibility = Visibility.Visible;
			
		}

		private void Btn_Callcode_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if(Sailor_6300_Radiotelex.m_UC.Msg_Send=="Message")Rect_Call_Setupshadow.Visibility = Visibility.Visible;          
			Edit_value.Visibility=Visibility.Visible;
			Storyboard SB = new Storyboard();//创建一个故事版
           SB = (Storyboard)this.FindResource("Storyboard_Edit_value");//从当前xaml的资源中寻找名为Storyboard2的故事版
           SB.Begin();//播放该故事版
		}

		private void Btn_TX_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message") Rect_Call_Setupshadow.Visibility = Visibility.Visible;
			Edit_value.Visibility=Visibility.Visible;
			Storyboard SB = new Storyboard();//创建一个故事版
           SB = (Storyboard)this.FindResource("Storyboard_Edit_value");//从当前xaml的资源中寻找名为Storyboard2的故事版
           SB.Begin();//播放该故事版
		}

		private void Btn_RX_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message") Rect_Call_Setupshadow.Visibility = Visibility.Visible;
			Edit_value.Visibility=Visibility.Visible;
			Storyboard SB = new Storyboard();//创建一个故事版
           SB = (Storyboard)this.FindResource("Storyboard_Edit_value");//从当前xaml的资源中寻找名为Storyboard2的故事版
           SB.Begin();//播放该故事版
		}

        private void Btn_TX_broad_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message") Rect_Call_Setupshadow.Visibility = Visibility.Visible;
            Edit_value.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Edit_value");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
        }
        private void Btn_Channel_Click(object sender, RoutedEventArgs e)
        {
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message") Rect_Call_Setupshadow.Visibility = Visibility.Visible;
            Edit_value.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Edit_value");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
        }

       

// channel变换规则说明
	public void ChannelRules(int BL_channel)
	{
        int Ch=Convert.ToInt32(TB_Channel.Text);
        double TX_freq=4202.5;
        double RX_freq=4202.5;
        if (BL_Call_setup == 1)
        {
            TB_TX_load.Visibility = Visibility.Visible;
            TB_RX_load.Visibility = Visibility.Visible;
        }
        else if (BL_Call_setup == 2)
        {
        TB_TX_load.Visibility = Visibility.Visible;
        TB_RX_load.Visibility = Visibility.Collapsed;
        }
        else if (BL_Call_setup == 3)
        {
            TB_TX_load.Visibility = Visibility.Collapsed;
            TB_RX_load.Visibility = Visibility.Collapsed;
        }
        Cav_Illegal_Channel.Visibility = Visibility.Collapsed;
        if (BL_Channel == 2)
        {
            if (Ch >= 401 && Ch <= 410) TX_freq = RX_freq = (Ch - 401) * 0.5 + 4202.5;
            else if (Ch >= 601 && Ch <= 623) TX_freq = RX_freq = (Ch - 601) * 0.5 + 6300.5;
            else if (Ch >= 801 && Ch <= 836) TX_freq = RX_freq = (Ch - 801) * 0.5 + 8396.5;
            else if (Ch >= 1201 && Ch <= 1234) TX_freq = RX_freq = (Ch - 1201) * 0.5 + 12560.0;
            else if (Ch >= 1601 && Ch <= 1639) TX_freq = RX_freq = (Ch - 1601) * 0.5 + 16785.0;
            else if (Ch >= 1801 && Ch <= 1811) TX_freq = RX_freq = (Ch - 1801) * 0.5 + 18893.0;
            else if (Ch >= 2201 && Ch <= 2245) TX_freq = RX_freq = (Ch - 2201) * 0.5 + 22352.0;
            else if (Ch >= 2501 && Ch <= 2531) TX_freq = RX_freq = (Ch - 2501) * 0.5 + 25193.0;
            else 
            {
                TB_TX_load.Visibility = Visibility.Collapsed;
                TB_RX_load.Visibility = Visibility.Collapsed;
                TB_Illegal_Channel.Text = "Channel " + Ch+" not in ITU intership list";
                Cav_Illegal_Channel.Visibility = Visibility.Visible;
            }
        }
        if (BL_Channel == 3)
        {
            if (Ch >= 401 && Ch <= 419)
            {
                RX_freq = (Ch - 401) * 0.5 + 4210.5;
                TX_freq = (Ch - 401) * 0.5 + 4172.5;
            }
            else if (Ch >= 601 && Ch <= 634)
            {
                RX_freq = (Ch - 601) * 0.5 + 6314.5;
                TX_freq = (Ch - 601) * 0.5 + 6263.0;
            }
            else if (Ch == 801)
            {
                RX_freq = 8376.5;
                TX_freq = 8376.5;
            }
            else if (Ch >= 802 && Ch <= 840)
            {
                RX_freq = (Ch - 802) * 0.5 + 8417.0;
                TX_freq = (Ch - 802) * 0.5 + 8377.0;
            }
            else if (Ch >= 1201 && Ch <= 1299)
            {
                RX_freq = (Ch - 1201) * 0.5 + 12597.5;
                TX_freq = (Ch - 1201) * 0.5 + 12477.0;
            }
            else if (Ch >= 1601 && Ch <= 1699)
            {
                RX_freq = (Ch - 1601) * 0.5 + 16807.0;
                TX_freq = (Ch - 1601) * 0.5 + 16683.5;
            }
            else if (Ch >= 1801 && Ch <= 1845)
            {
                RX_freq = (Ch - 1801) * 0.5 + 19681.0;
                TX_freq = (Ch - 1801) * 0.5 + 18870.5;
            }
            else if (Ch >= 2201 && Ch <= 2299)
            {
                RX_freq = (Ch - 2201) * 0.5 + 22376.5;
                TX_freq = (Ch - 2201) * 0.5 + 22284.5;
            }
            else if (Ch >= 2501 && Ch <= 2540)
            {
                RX_freq = (Ch - 2501) * 0.5 + 26101.0;
                TX_freq = (Ch - 2501) * 0.5 + 25173.0;
            }
            else if (Ch >= 12100 && Ch <= 12156)
            {
                RX_freq = (Ch - 12100) * 0.5 + 12628.5;
                TX_freq = (Ch - 12100) * 0.5 + 12526.5;
            }
            else if (Ch >= 16100 && Ch <= 16193)
            {
                RX_freq = (Ch - 16100) * 0.5 + 16856.0;
                TX_freq = (Ch - 16100) * 0.5 + 16733.0;
            }
            else if (Ch >= 22100 && Ch <= 22135)
            {
                RX_freq = (Ch - 22100) * 0.5 + 22426.0;
                TX_freq = (Ch - 22100) * 0.5 + 22334.0;
            }
            else 
            {
                TB_TX_load.Visibility = Visibility.Collapsed;
                TB_RX_load.Visibility = Visibility.Collapsed;
                TB_Illegal_Channel.Text = "Channel " + Ch + " not in ITU coast station list";
                Cav_Illegal_Channel.Visibility = Visibility.Visible;
            }
        }
     if (BL_Channel == 4)
        {
           if (Ch == 1) TX_freq = RX_freq = 2174.5;
           else if (Ch == 411) TX_freq = RX_freq = 4177.5;
           else if (Ch == 611) TX_freq = RX_freq = 6268.0;
           else if (Ch == 801) TX_freq = RX_freq = 8376.5;
           else if (Ch == 1287) TX_freq = RX_freq = 12520.0;
           else if (Ch == 1624) TX_freq = RX_freq = 16695.0;
           else
           {
               TB_TX_load.Visibility = Visibility.Collapsed;
               TB_RX_load.Visibility = Visibility.Collapsed;
               TB_Illegal_Channel.Text = "Channel " + Ch + " not in ITU distress/safety list";
               Cav_Illegal_Channel.Visibility = Visibility.Visible;
           }
        }
        TB_RX_load.Text = "(Local RX " + RX_freq.ToString("0.0") + " kHz)";
        TB_TX_load.Text = "(Local TX " + TX_freq.ToString("0.0") + " kHz)";
	}


		
	}
}