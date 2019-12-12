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
    /// Interaction logic for UsrCtrl_Basic.xaml
    /// </summary>
    public partial class UsrCtrl_Basic : UserControl
    {
        public int m_iFunOrder = 0;//逻辑控制变量
        private DispatcherTimer ShowTimer;//时间控制
        public int Image_Index = 0;//电源开关控制变量
        public int m_iMessage = 0;//信箱控制变量
        public int m_iShadow = 0;//界面阴影变量
        public double BL_Dim = 1;
        public string Msg_Send = "null";
        bool m_iCaps = false;
        bool m_iKeyNumber = false;
        bool Model_Idel = true;
        bool IscheckedOn = true;
        bool i_Distress = false;//警报盖处于关闭状态
        public DispatcherTimer m_Timer = new DispatcherTimer(); //菜单定时器
        public int m_TimerCount = 0;//时间计数器

        public UsrCtrl_Basic()
        {
            InitializeComponent();
            ShowTimer = new System.Windows.Threading.DispatcherTimer();
            ShowTimer.Tick += new EventHandler(ShowCurTimer);//起个Timer一直获取当前时间
            ShowTimer.Interval = TimeSpan.FromSeconds(0.1);   //设置刷新的间隔时间
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            ShowTimer.Start();
            m_Timer.Interval = new TimeSpan(0, 0, 0, 0, 400);
            m_Timer.Tick += new EventHandler(Frash_text);
            image_on.Visibility = Visibility.Hidden;
            grid1.Visibility = Visibility.Collapsed;
            grid3.Visibility = Visibility.Collapsed;
            keyboard.Visibility = Visibility.Collapsed;
            Background.Visibility = Visibility.Collapsed;
            Call_Setup.Visibility = Visibility.Collapsed;
            Btn_1.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_1_MouseLeftButtonDown), true);
            Btn_1.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_1_MouseLeftButtonUp), true);
            Btn_2.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_2_MouseLeftButtonDown), true);
            Btn_3.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_3_MouseLeftButtonDown), true);
            Btn_3.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_3_MouseLeftButtonUp), true);
            Btn_4.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_4_MouseLeftButtonDown), true);
            Btn_4.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_4_MouseLeftButtonUp), true);
            Btn_5.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_5_MouseLeftButtonDown), true);
            Btn_5.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_5_MouseLeftButtonUp), true);
            Btn_6.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_6_MouseLeftButtonDown), true);
            Btn_7.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_7_MouseLeftButtonDown), true);
            Btn_7.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_7_MouseLeftButtonUp), true);
            Btn_Msg.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Msg_MouseLeftButtonDown), true);
            Btn_Msg.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Msg_MouseLeftButtonUp), true);
            Btn_home.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_home_MouseLeftButtonDown), true);
            Btn_home.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_home_MouseLeftButtonUp), true);
            Btn_message_new.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_message_new_MouseLeftButtonDown), true);
            Btn_message_sent_items.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_message_sent_items_MouseLeftButtonDown), true);
            Btn_message_inbox.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_message_inbox_MouseLeftButtonDown), true);
            Btn_Options.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Options_MouseLeftButtonDown), true);
            Btn_Print.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Print_MouseLeftButtonDown), true);
            Btn_Print.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Print_MouseLeftButtonUp), true);
            Btn_New.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_New_MouseLeftButtonDown), true);
            Btn_New.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_New_MouseLeftButtonUp), true);
            Btn_Load.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Load_MouseLeftButtonDown), true);
            Btn_Load.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Load_MouseLeftButtonUp), true);
            Btn_Save.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Save_MouseLeftButtonDown), true);
            Btn_Save.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Save_MouseLeftButtonUp), true);
            Btn_print_error_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_print_error_OK_MouseLeftButtonDown), true);
            Btn_print_error_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_print_error_OK_MouseLeftButtonUp), true);
            Btn_load_new.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_new_MouseLeftButtonDown), true);
            Btn_load_new.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_new_MouseLeftButtonUp), true);
            Btn_load_home.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_home_MouseLeftButtonDown), true);
            Btn_load_home.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_home_MouseLeftButtonUp), true);
            Btn_load_parent.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_parent_MouseLeftButtonDown), true);
            Btn_load_parent.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_parent_MouseLeftButtonUp), true);
            Btn_load_close.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_close_MouseLeftButtonDown), true);
            Btn_load_close.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_close_MouseLeftButtonUp), true);
            Btn_load_tools.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_tools_MouseLeftButtonDown), true);
            Btn_load_tools.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_tools_MouseLeftButtonUp), true);
            Btn_load_selectall.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_selectall_MouseLeftButtonDown), true);
            Btn_load_selectall.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_selectall_MouseLeftButtonUp), true);
            Btn_load_clearall.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_clearall_MouseLeftButtonDown), true);
            Btn_load_clearall.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_clearall_MouseLeftButtonUp), true);
            Btn_load_Delete.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_load_Delete_MouseLeftButtonDown), true);
            Btn_load_Delete.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_load_Delete_MouseLeftButtonUp), true);
            Btn_keyboard.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_keyboard_MouseLeftButtonDown), true);
            Btn_keyboard.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_keyboard_MouseLeftButtonUp), true);
            Btn_Q.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Q_MouseLeftButtonDown), true);
            Btn_Q.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Q_MouseLeftButtonUp), true);
            Btn_W.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_W_MouseLeftButtonDown), true);
            Btn_W.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_W_MouseLeftButtonUp), true);
            Btn_E.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_E_MouseLeftButtonDown), true);
            Btn_E.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_E_MouseLeftButtonUp), true);
            Btn_R.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_R_MouseLeftButtonDown), true);
            Btn_R.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_R_MouseLeftButtonUp), true);
            Btn_T.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_T_MouseLeftButtonDown), true);
            Btn_T.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_T_MouseLeftButtonUp), true);
            Btn_Y.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Y_MouseLeftButtonDown), true);
            Btn_Y.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Y_MouseLeftButtonUp), true);
            Btn_U.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_U_MouseLeftButtonDown), true);
            Btn_U.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_U_MouseLeftButtonUp), true);
            Btn_I.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_I_MouseLeftButtonDown), true);
            Btn_I.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_I_MouseLeftButtonUp), true);
            Btn_O.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_O_MouseLeftButtonDown), true);
            Btn_O.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_O_MouseLeftButtonUp), true);
            Btn_P.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_P_MouseLeftButtonDown), true);
            Btn_P.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_P_MouseLeftButtonUp), true);
            Btn_A.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_A_MouseLeftButtonDown), true);
            Btn_A.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_A_MouseLeftButtonUp), true);
            Btn_S.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_S_MouseLeftButtonDown), true);
            Btn_S.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_S_MouseLeftButtonUp), true);
            Btn_D.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_D_MouseLeftButtonDown), true);
            Btn_D.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_D_MouseLeftButtonUp), true);
            Btn_F.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_F_MouseLeftButtonDown), true);
            Btn_F.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_F_MouseLeftButtonUp), true);
            Btn_G.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_G_MouseLeftButtonDown), true);
            Btn_G.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_G_MouseLeftButtonUp), true);
            Btn_H.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_H_MouseLeftButtonDown), true);
            Btn_H.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_H_MouseLeftButtonUp), true);
            Btn_J.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_J_MouseLeftButtonDown), true);
            Btn_J.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_J_MouseLeftButtonUp), true);
            Btn_K.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_K_MouseLeftButtonDown), true);
            Btn_K.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_K_MouseLeftButtonUp), true);
            Btn_L.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_L_MouseLeftButtonDown), true);
            Btn_L.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_L_MouseLeftButtonUp), true);
            Btn_Z.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Z_MouseLeftButtonDown), true);
            Btn_Z.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Z_MouseLeftButtonUp), true);
            Btn_X.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_X_MouseLeftButtonDown), true);
            Btn_X.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_X_MouseLeftButtonUp), true);
            Btn_C.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_C_MouseLeftButtonDown), true);
            Btn_C.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_C_MouseLeftButtonUp), true);
            Btn_V.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_V_MouseLeftButtonDown), true);
            Btn_V.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_V_MouseLeftButtonUp), true);
            Btn_B.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_B_MouseLeftButtonDown), true);
            Btn_B.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_B_MouseLeftButtonUp), true);
            Btn_N.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_N_MouseLeftButtonDown), true);
            Btn_N.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_N_MouseLeftButtonUp), true);
            Btn_M.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_M_MouseLeftButtonDown), true);
            Btn_M.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_M_MouseLeftButtonUp), true);
            Btn_Comma.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Comma_MouseLeftButtonDown), true);
            Btn_Comma.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Comma_MouseLeftButtonUp), true);
            Btn_Dit.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Dit_MouseLeftButtonDown), true);
            Btn_Dit.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Dit_MouseLeftButtonUp), true);
            Btn_Backspace.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Backspace_MouseLeftButtonDown), true);
            Btn_Backspace.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Backspace_MouseLeftButtonUp), true);
            Btn_Enter.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Enter_MouseLeftButtonDown), true);
            Btn_Enter.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Enter_MouseLeftButtonUp), true);
            Btn_Shift.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Shift_MouseLeftButtonDown), true);
            Btn_Shift.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Shift_MouseLeftButtonUp), true);
            Btn_Caps_lock.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Caps_lock_MouseLeftButtonDown), true);
            Btn_Caps_lock.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Caps_lock_MouseLeftButtonUp), true);
            Btn_Number_trans.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Number_trans_MouseLeftButtonDown), true);
            Btn_Number_trans.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Number_trans_MouseLeftButtonUp), true);
            Btn_Space.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Space_MouseLeftButtonDown), true);
            Btn_Space.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Space_MouseLeftButtonUp), true);
            Btn_keyLeft.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_keyLeft_MouseLeftButtonDown), true);
            Btn_keyLeft.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_keyLeft_MouseLeftButtonUp), true);
            Btn_keyUp.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_keyUp_MouseLeftButtonDown), true);
            Btn_keyUp.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_keyUp_MouseLeftButtonUp), true);
            Btn_keyRight.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_keyRight_MouseLeftButtonDown), true);
            Btn_keyRight.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_keyRight_MouseLeftButtonUp), true);
            Btn_keyDown.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_keyDown_MouseLeftButtonDown), true);
            Btn_keyDown.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_keyDown_MouseLeftButtonUp), true);
            Btn_keyboard_close.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_keyboard_close_MouseLeftButtonDown), true);
            Btn_keyboard_close.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_keyboard_close_MouseLeftButtonUp), true);
            Btn_New_yes.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_New_yes_MouseLeftButtonUp), true);
            Btn_New_yes.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_New_yes_MouseLeftButtonDown), true);
            Btn_New_no.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_New_no_MouseLeftButtonUp), true);
            Btn_New_no.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_New_no_MouseLeftButtonDown), true);
            Btn_Send_text.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Send_text_MouseLeftButtonUp), true);
            Btn_Send_text.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Send_text_MouseLeftButtonDown), true);
            Btn_Call.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Call_MouseLeftButtonUp), true);
            Btn_Call.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Call_MouseLeftButtonDown), true);
            Btn_System.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_System_MouseLeftButtonUp), true);
            Btn_System.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_System_MouseLeftButtonDown), true);
            Btn_Battery.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Battery_MouseLeftButtonUp), true);
            Btn_Battery.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Battery_MouseLeftButtonDown), true);
		    Btn_Scan.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Scan_MouseLeftButtonUp), true);
          
			Btn_Contacts.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Contacts_MouseLeftButtonUp), true);
            Btn_Contacts.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Contacts_MouseLeftButtonDown), true);Btn_Scan.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Scan_MouseLeftButtonDown), true);
            //this.DataContext =  m_Data;//2017年5月3日17:39:49 关于MVVM模式
        }
        private void Btn_1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            if (Image_Index == 0)
            {//开机
                image1.Visibility = Visibility.Collapsed;
                grid1.Visibility = Visibility.Visible;
                //   image_on.Visibility = Visibility.Visible;
                Key.Visibility = Visibility.Collapsed;
                image0.Visibility = Visibility.Collapsed;
                img_On_up.Visibility = Visibility.Visible;
                Background.Visibility = Visibility.Visible;
                if (i_Distress == false)
                {
                    Storyboard SB1 = new Storyboard();//创建一个故事版,作为开机动画
                    SB1 = (Storyboard)this.FindResource("Storyboard1");//从当前xaml的资源中寻找名为Storyboard1的故事版
                    SB1.Begin();//播放该故事版
                }
                else
                {
                    Storyboard SB2 = new Storyboard();//创建一个故事版,作为开机动画
                    SB2 = (Storyboard)this.FindResource("Storyboard_open_DY2");//从当前xaml的资源中寻找名为Storyboard1的故事版
                    SB2.Begin();//播放该故事版
                }
                
                Image_Index = 1;
            }
            else //关机
            {
                Background.Visibility = Visibility.Collapsed;
                img_On_up.Visibility = Visibility.Collapsed;
                image1_on.Visibility = Visibility.Collapsed;
                grid1.Visibility = Visibility.Collapsed;
                grid3.Visibility = Visibility.Collapsed;
                // image_on.Visibility = Visibility.Collapsed;
                image0.Visibility = Visibility.Visible;
                Image_Index = 0;
            }
        }
        private void Btn_1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {  //电源按钮 
            if (Image_Index == 0)
            {
              //断电按下电源按钮特效
                image1.Visibility = Visibility.Visible;
            }
            else
                image1_on.Visibility = Visibility.Visible;//通电情况下按下电源按钮


        }
        //开盖
        private void Btn_2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {//开盖事件
          /*  if (Image_Index == 0)//关机状态
            {
                image2.Visibility = Visibility.Visible;
                Btn_7.Visibility = Visibility.Visible;
                i_Distress = true;
            }
            else
            {              
                image_button_on.Visibility = Visibility.Visible;
                Btn_7.Visibility = Visibility.Visible;
                i_Distress = true;
            }*/
            image2.Visibility = Visibility.Visible;
            Btn_7.Visibility = Visibility.Visible;
            i_Distress = true;
        }
        //关盖事件
        private void Btn_6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
          /*  if (Image_Index == 0)//关机状态
            {
                image2.Visibility = Visibility.Collapsed;
                Btn_7.Visibility = Visibility.Collapsed;
                i_Distress = false;
            }
            else//开机状态
              {
                 image2.Visibility = Visibility.Collapsed;
             image_button_on.Visibility = Visibility.Collapsed;
              Btn_7.Visibility = Visibility.Collapsed;
              i_Distress = false;
			}
            */
            image2.Visibility = Visibility.Collapsed;            
            Btn_7.Visibility = Visibility.Collapsed;
            i_Distress = false;
        }
        //test按钮抬起事件
        private void Btn_3_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {         
            if (i_Distress == false)
            {
                m_Timer.Stop();         
                image3.Visibility = Visibility.Collapsed;
                image_Distress_light.Visibility = Visibility.Collapsed;
            }
            else
            {
                m_Timer.Stop();  
                image3.Visibility = Visibility.Collapsed;
                image_clip.Visibility = Visibility.Collapsed;
            }

        }
        //test按钮按下事件
        private void Btn_3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (i_Distress == false)
            {
                m_Timer.Stop();
                m_Timer.Start();
                image3.Visibility = Visibility.Visible;
                image_Distress_light.Visibility = Visibility.Visible;
            }
            else
            {
                m_Timer.Stop();
                m_Timer.Start();
                image3.Visibility = Visibility.Visible;
                image_clip.Visibility = Visibility.Visible;
            }
            
        }
        //dim按钮抬起事件
        private void Btn_4_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        
            image4.Visibility = Visibility.Collapsed;
        }
        //dim按钮按下事件
        private void Btn_4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            image4.Visibility = Visibility.Visible;
            if (BL_Dim == 1)
            {
                MainWindow.Opacity = 0.9;
                BL_Dim = 2;
            }
            else if (BL_Dim == 2)
            {
                MainWindow.Opacity = 0.7;
                BL_Dim = 3;
            }
            else if (BL_Dim == 3)
            {
                MainWindow.Opacity = 0.5;
                BL_Dim = 1;
            }
        }
        //mute按钮按下事件
        private void Btn_5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {            
            image5.Visibility = Visibility.Visible;
        }
        //mute按钮抬起事件
        private void Btn_5_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {            
            image5.Visibility = Visibility.Collapsed;
        }

        private void Btn_7_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Image_Index == 0)
                image_Distress_off.Visibility = Visibility.Visible;
            else
                image_Distress_on.Visibility = Visibility.Visible;
        }
        private void Btn_7_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Image_Index == 0)
                image_Distress_off.Visibility = Visibility.Collapsed;
            else
                image_Distress_on.Visibility = Visibility.Collapsed;
        }
        //message按钮事件，打开信箱
        private void Btn_Msg_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            Msg_normal.Visibility = Visibility.Collapsed;
        }

        private void Btn_Msg_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Msg_normal.Visibility = Visibility.Visible;
            Msg_pressed.Visibility = Visibility.Collapsed;
            Msg_Send = "Message";
            TB_main.Text = "MESSAGE";
            TB_subhead.Text = "INBOX";
            grid3.Visibility = Visibility.Visible;
            if (m_iMessage == 0)
            {
                message_new.Visibility = Visibility.Collapsed;
                message_sent_items.Visibility = Visibility.Collapsed;
                message_inbox.Visibility = Visibility.Visible;
                Storyboard SB2 = new Storyboard();//创建一个故事版
                SB2 = (Storyboard)this.FindResource("Storyboard2");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB2.Begin();//播放该故事版
            }
            else if (m_iMessage == 1)
            {
                message_new.Visibility = Visibility.Visible;
                message_sent_items.Visibility = Visibility.Collapsed;
                message_inbox.Visibility = Visibility.Collapsed;
                Storyboard SB2 = new Storyboard();//创建一个故事版
                SB2 = (Storyboard)this.FindResource("Storyboard2");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB2.Begin();//播放该故事版
            }
            else if (m_iMessage == 2)
            {
                message_new.Visibility = Visibility.Collapsed;
                message_sent_items.Visibility = Visibility.Visible;
                message_inbox.Visibility = Visibility.Collapsed;
                Storyboard SB2 = new Storyboard();//创建一个故事版
                SB2 = (Storyboard)this.FindResource("Storyboard2");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB2.Begin();//播放该故事版
            }
        }
        //从信箱返回主菜单界面
        private void Btn_home_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            message_home_pre.Visibility = Visibility.Visible;
            message_home_normal.Visibility = Visibility.Collapsed;
        }

        private void Btn_home_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            message_home_pre.Visibility = Visibility.Collapsed;
            message_home_normal.Visibility = Visibility.Visible;
            TB_main.Text = "GMDSS";
            TB_subhead.Text = "RADIOTELEX";
            if (m_iMessage == 0)
            {
                message_inbox.Visibility = Visibility.Visible;
                message_new.Visibility = Visibility.Collapsed;
                message_sent_items.Visibility = Visibility.Collapsed;
                Storyboard SB3 = new Storyboard();//创建一个故事版，回到主界面
                SB3 = (Storyboard)this.FindResource("Storyboard3");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB3.Begin();//播放该故事版	
            }
            else if (m_iMessage == 1)
            {
                message_inbox.Visibility = Visibility.Collapsed;
                message_new.Visibility = Visibility.Visible;
                message_sent_items.Visibility = Visibility.Collapsed;
                Storyboard SB3 = new Storyboard();//创建一个故事版，回到主界面
                SB3 = (Storyboard)this.FindResource("Storyboard3");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB3.Begin();//播放该故事版
            }
            else if (m_iMessage == 2)
            {
                message_inbox.Visibility = Visibility.Collapsed;
                message_new.Visibility = Visibility.Collapsed;
                message_sent_items.Visibility = Visibility.Visible;
                Storyboard SB3 = new Storyboard();//创建一个故事版，回到主界面
                SB3 = (Storyboard)this.FindResource("Storyboard3");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB3.Begin();//播放该故事版
            }
        }
        //新建信息按钮按下事件
        private void Btn_message_new_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TB_subhead.Text = "NEW MESSAGE";
            TB_message_new.Text = null;
            message_new.Visibility = Visibility.Visible;
            message_new_pre.Visibility = Visibility.Visible;
            message_inbox_pre.Visibility = Visibility.Collapsed;
            message_sent_pre.Visibility = Visibility.Collapsed;
            if (m_iMessage == 0)
            {
                Storyboard SB4 = new Storyboard();//创建一个故事版
                SB4 = (Storyboard)this.FindResource("Storyboard_InboxtoNew");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB4.Begin();//播放该故事版	
                m_iMessage = 1;
            }
            else if (m_iMessage == 2)
            {
                Storyboard SB5 = new Storyboard();//创建一个故事版
                SB5 = (Storyboard)this.FindResource("Storyboard_SenttoNew");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB5.Begin();//播放该故事版	
                m_iMessage = 1;
            }

        }
        //信箱sent items按钮事件
        private void Btn_message_sent_items_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TB_subhead.Text = "SENT ITEMS";
            message_sent_items.Visibility = Visibility.Visible;
            message_new_pre.Visibility = Visibility.Collapsed;
            message_inbox_pre.Visibility = Visibility.Collapsed;
            message_sent_pre.Visibility = Visibility.Visible;
            if (m_iMessage == 0)
            {
                Storyboard SB6 = new Storyboard();//创建一个故事版
                SB6 = (Storyboard)this.FindResource("Storyboard_InboxtoSent");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB6.Begin();//播放该故事版	
                m_iMessage = 2;
            }
            else if (m_iMessage == 1)
            {
                Storyboard SB7 = new Storyboard();//创建一个故事版
                SB7 = (Storyboard)this.FindResource("Storyboard_NewtoSent");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB7.Begin();//播放该故事版	
                m_iMessage = 2;
            }
        }
        private void Btn_message_inbox_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TB_subhead.Text = "INBOX";
            message_inbox.Visibility = Visibility.Visible;
            message_new_pre.Visibility = Visibility.Collapsed;
            message_inbox_pre.Visibility = Visibility.Visible;
            message_sent_pre.Visibility = Visibility.Collapsed;
            if (m_iMessage == 1)
            {
                Storyboard SB8 = new Storyboard();//创建一个故事版
                SB8 = (Storyboard)this.FindResource("Storyboard_NewtoInbox");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB8.Begin();//播放该故事版	
                m_iMessage = 0;
            }
            else if (m_iMessage == 2)
            {
                Storyboard SB9 = new Storyboard();//创建一个故事版
                SB9 = (Storyboard)this.FindResource("Storyboard_SenttoInbox");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB9.Begin();//播放该故事版	
                m_iMessage = 0;
            }
        }
        private void Btn_Options_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            if (m_iShadow == 0)
            {
                Rct_mesaage_shadow.Visibility = Visibility.Visible;
                op_zhankai.Visibility = Visibility.Visible;
                Storyboard Btn_Options_arrowup = new Storyboard();//创建一个故事版
                Btn_Options_arrowup = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_up");//从当前xaml的资源中寻找名为Storyboard2的故事版
                Btn_Options_arrowup.Begin();//播放该故事版
                m_iShadow = 1;
            }
            else if (m_iShadow == 1)
            {
                Storyboard Btn_Options_arrowdown = new Storyboard();//创建一个故事版
                Btn_Options_arrowdown = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
                Btn_Options_arrowdown.Begin();//播放该故事版
                //op_zhankai.Visibility=Visibility.Collapsed;
                Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
                m_iShadow = 0;
            }

        }
        //message中print按钮的效果
        private void Btn_Print_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_print_pressed.Visibility = Visibility.Visible;
        }

        private void Btn_Print_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_print_pressed.Visibility = Visibility.Collapsed;
            print_error.Visibility = Visibility.Visible;
            //打印机无连接
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_printer_error");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
            //收起菜单栏
            Storyboard Btn_Options_arrowdown = new Storyboard();//创建一个故事版
            Btn_Options_arrowdown = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
            Btn_Options_arrowdown.Begin();//播放该故事版
            m_iShadow = 0;
        }
        //message中new按钮的效果
        private void Btn_New_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_new_pressed.Visibility = Visibility.Visible;
        }

        private void Btn_New_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (String.IsNullOrEmpty(TB_message_new.Text) == false)
            {
                grid_Btn_new_pressed.Visibility = Visibility.Collapsed;
                msg_new_question.Visibility = Visibility.Visible;
                Storyboard SB = new Storyboard();//创建一个故事版
                SB = (Storyboard)this.FindResource("Storyboard_Msg_new_question");//从当前xaml的资源中寻找名为Storyboard2的故事版
                SB.Begin();//播放该故事版
                //收起菜单栏
                Storyboard Btn_Options_arrowdown = new Storyboard();//创建一个故事版
                Btn_Options_arrowdown = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
                Btn_Options_arrowdown.Begin();//播放该故事版
                m_iShadow = 0;
            }
            else
            {
                grid_Btn_new_pressed.Visibility = Visibility.Collapsed;
                //收起菜单栏
                Storyboard Btn_Options_arrowdown = new Storyboard();//创建一个故事版
                Btn_Options_arrowdown = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
                Btn_Options_arrowdown.Begin();//播放该故事版
                Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
                m_iShadow = 0;
            }


        }
        //message中Load按钮的效果
        private void Btn_Load_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_load_pressed.Visibility = Visibility.Visible;
        }

        private void Btn_Load_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_load_pressed.Visibility = Visibility.Collapsed;
            Cav_Msg_Load.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_message_load");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
            op_zhankai.Visibility = Visibility.Collapsed;
            //收起菜单栏
            Storyboard Btn_Options_arrowdown = new Storyboard();//创建一个故事版
            Btn_Options_arrowdown = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
            Btn_Options_arrowdown.Begin();//播放该故事版			
            m_iShadow = 0;
            if (Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count == 0)
            {
                TB_List_empty.Visibility = Visibility.Visible;
            }
            else TB_List_empty.Visibility = Visibility.Collapsed;
        }
        //message中Save按钮的效果
        private void Btn_Save_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_Save_pressed.Visibility = Visibility.Visible;
            
        }

        private void Btn_Save_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_Btn_Save_pressed.Visibility = Visibility.Collapsed;
            //判断输入内容是否为空或者空格
            if (string.IsNullOrWhiteSpace(TB_message_new.Text) == true)
            {

            }
            else
            {
                message_Save.Visibility = Visibility.Visible;
                //收起菜单栏
                Storyboard Btn_Options_arrowdown = new Storyboard();//创建一个故事版
                Btn_Options_arrowdown = (Storyboard)this.FindResource("Storyboard_Btn_op_arrow_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
                Btn_Options_arrowdown.Begin();//播放该故事版
                Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
                m_iShadow = 0; 
            }
            
            Sailor_6300_Radiotelex.m_UC.message_Save.Check_ListBox();
        }

      
        public void ShowCurTimer(object sender, EventArgs e)
        {
            //获得时分
            this.Time.Text = DateTime.Now.ToString("HH:mm");
            this.error_time.Text = DateTime.Now.ToString("HH:mm");

        }

        private void Btn_print_error_OK_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_btn_ok_pressed.Visibility = Visibility.Visible;
        }

        private void Btn_print_error_OK_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            grid_btn_ok_pressed.Visibility = Visibility.Collapsed;
            print_error.Visibility = Visibility.Collapsed;
            Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
        }
        //message中load按钮中的事件与效果
        private void Btn_load_parent_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_parent_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_load_parent_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_parent_Copy.Visibility = Visibility.Collapsed;

        }
        private void Btn_load_home_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_home_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_load_home_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_home_Copy.Visibility = Visibility.Collapsed;

        }
        private void Btn_load_new_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_new_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_load_new_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_new_Copy.Visibility = Visibility.Collapsed;

        }
        private void Btn_load_close_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_close_Copy.Visibility = Visibility.Visible;

        }

        private void Btn_load_close_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_close_Copy.Visibility = Visibility.Collapsed;
            Cav_Msg_Load.Visibility = Visibility.Collapsed;
            Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
        }
        private void Btn_load_tools_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_tools_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_load_tools_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_tools_Copy.Visibility = Visibility.Collapsed;
            if (IscheckedOn)
            {
                ListBox_Load.ItemTemplate = (DataTemplate)this.FindResource("ListItem_Msg_Din");
                ListBox_Load.Items.Refresh();
                ca_btn_select_all.Visibility = Visibility.Visible;
                ca_btn_clear_all.Visibility = Visibility.Visible;
                Cav_Delete.Visibility = Visibility.Visible;
                Btn_load_clearall.Visibility = Visibility.Visible;
                Btn_load_selectall.Visibility = Visibility.Visible;
                Btn_load_Delete.Visibility = Visibility.Visible;
                IscheckedOn = false;

            }
            else
            {
                ListBox_Load.ItemTemplate = (DataTemplate)this.FindResource("ListItem_Msg");
                ListBox_Load.Items.Refresh();
                ca_btn_select_all.Visibility = Visibility.Collapsed;
                ca_btn_clear_all.Visibility = Visibility.Collapsed;
                Cav_Delete.Visibility = Visibility.Collapsed;
                Btn_load_clearall.Visibility = Visibility.Collapsed;
                Btn_load_selectall.Visibility = Visibility.Collapsed;
                Btn_load_Delete.Visibility = Visibility.Collapsed;
                IscheckedOn = true;
            }

        }
        private void Btn_load_Delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Delete_pre.Visibility = Visibility.Visible;
        }
        private void Btn_load_Delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_Delete_pre.Visibility = Visibility.Collapsed;
        }
        private void Btn_load_selectall_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_select_all_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_load_selectall_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_select_all_Copy.Visibility = Visibility.Collapsed;
			//和Btn_load_Clearall形成互斥效果
            Rect_Selectall.Visibility = Visibility.Collapsed;
            Btn_load_selectall.Visibility = Visibility.Collapsed;
            Rect_Clearall.Visibility = Visibility.Visible;
            Btn_load_clearall.Visibility = Visibility.Visible;
			//Btn_delete的显示
            Btn_load_Delete.Visibility = Visibility.Visible;
            Rect_Delete.Visibility = Visibility.Visible;
        }
        private void Btn_load_clearall_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_clear_all_Copy.Visibility = Visibility.Visible;
        }
        private void Btn_load_clearall_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ca_btn_clear_all_Copy.Visibility = Visibility.Collapsed;
			//和Btn_load_Selectall形成互斥效果
            Rect_Clearall.Visibility = Visibility.Collapsed;
            Btn_load_selectall.Visibility = Visibility.Visible;
            Rect_Selectall.Visibility = Visibility.Visible;
            Btn_load_clearall.Visibility = Visibility.Collapsed;
			//Btn_delete的隐藏
            Btn_load_Delete.Visibility = Visibility.Collapsed;
            Rect_Delete.Visibility = Visibility.Collapsed;
        }
        //键盘触发按钮事件
        private void Btn_keyboard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_keypboard_pressed.Visibility = Visibility.Visible;
        }

        private void Btn_keyboard_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_keypboard_pressed.Visibility = Visibility.Collapsed;
            img_keypboard_normal.Visibility = Visibility.Collapsed;
            Btn_keyboard.Visibility = Visibility.Collapsed;
            keyboard.Visibility = Visibility.Collapsed;

            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_keyboard_up");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
        }
        private void Btn_keyboard_close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_keyboard_close_pre.Visibility = Visibility.Visible;
        }
        private void Btn_keyboard_close_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_keyboard_close_pre.Visibility = Visibility.Collapsed;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_keyboard_down");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
            img_keypboard_normal.Visibility = Visibility.Visible;
            Btn_keyboard.Visibility = Visibility.Visible;
        }
        //键盘特效和事件触发
        private void Btn_Q_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Q.Visibility = Visibility.Visible;
        }

        private void Btn_Q_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Q.Visibility = Visibility.Collapsed;
        }
        private void Btn_W_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_W.Visibility = Visibility.Visible;
        }

        private void Btn_W_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_W.Visibility = Visibility.Collapsed;
        }
        private void Btn_E_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_E.Visibility = Visibility.Visible;
        }
        private void Btn_E_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_E.Visibility = Visibility.Collapsed;
        }
        private void Btn_R_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_R.Visibility = Visibility.Visible;
        }
        private void Btn_R_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_R.Visibility = Visibility.Collapsed;
        }
        private void Btn_T_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_T.Visibility = Visibility.Visible;
        }
        private void Btn_T_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_T.Visibility = Visibility.Collapsed;
        }
        private void Btn_Y_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Y.Visibility = Visibility.Visible;
        }
        private void Btn_Y_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Y.Visibility = Visibility.Collapsed;
        }
        private void Btn_U_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_U.Visibility = Visibility.Visible;
        }
        private void Btn_U_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_U.Visibility = Visibility.Collapsed;
        }
        private void Btn_I_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_I.Visibility = Visibility.Visible;
        }
        private void Btn_I_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_I.Visibility = Visibility.Collapsed;
        }
        private void Btn_O_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_O.Visibility = Visibility.Visible;
        }
        private void Btn_O_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_O.Visibility = Visibility.Collapsed;
        }
        private void Btn_P_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_P.Visibility = Visibility.Visible;
        }
        private void Btn_P_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_P.Visibility = Visibility.Collapsed;
        }
        private void Btn_A_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_A.Visibility = Visibility.Visible;
        }
        private void Btn_A_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_A.Visibility = Visibility.Collapsed;
        }
        private void Btn_S_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_S.Visibility = Visibility.Visible;
        }
        private void Btn_S_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_S.Visibility = Visibility.Collapsed;
        }
        private void Btn_D_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_D.Visibility = Visibility.Visible;
        }
        private void Btn_D_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_D.Visibility = Visibility.Collapsed;
        }
        private void Btn_F_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_F.Visibility = Visibility.Visible;
        }
        private void Btn_F_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_F.Visibility = Visibility.Collapsed;
        }
        private void Btn_G_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_G.Visibility = Visibility.Visible;
        }
        private void Btn_G_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_G.Visibility = Visibility.Collapsed;
        }
        private void Btn_H_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_H.Visibility = Visibility.Visible;
        }
        private void Btn_H_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_H.Visibility = Visibility.Collapsed;
        }
        private void Btn_J_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_J.Visibility = Visibility.Visible;
        }
        private void Btn_J_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_J.Visibility = Visibility.Collapsed;
        }
        private void Btn_K_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_K.Visibility = Visibility.Visible;
        }
        private void Btn_K_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_K.Visibility = Visibility.Collapsed;
        }
        private void Btn_L_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_L.Visibility = Visibility.Visible;
        }
        private void Btn_L_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_L.Visibility = Visibility.Collapsed;
        }
        private void Btn_Z_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Z.Visibility = Visibility.Visible;
        }
        private void Btn_Z_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Z.Visibility = Visibility.Collapsed;
        }
        private void Btn_X_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_X.Visibility = Visibility.Visible;
        }
        private void Btn_X_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_X.Visibility = Visibility.Collapsed;
        }
        private void Btn_C_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_C.Visibility = Visibility.Visible;
        }
        private void Btn_C_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_C.Visibility = Visibility.Collapsed;
        }
        private void Btn_V_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_V.Visibility = Visibility.Visible;
        }

        private void Btn_V_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_V.Visibility = Visibility.Collapsed;
        }
        private void Btn_B_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_B.Visibility = Visibility.Visible;
        }

        private void Btn_B_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_B.Visibility = Visibility.Collapsed;
        }
        private void Btn_N_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_N.Visibility = Visibility.Visible;
        }

        private void Btn_N_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_N.Visibility = Visibility.Collapsed;
        }
        private void Btn_M_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_M.Visibility = Visibility.Visible;
        }

        private void Btn_M_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_M.Visibility = Visibility.Collapsed;
        }
        private void Btn_Comma_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Comma.Visibility = Visibility.Visible;
        }

        private void Btn_Comma_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Comma.Visibility = Visibility.Collapsed;
        }
        private void Btn_Dit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Dit.Visibility = Visibility.Visible;
        }

        private void Btn_Dit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Dit.Visibility = Visibility.Collapsed;
        }
        private void Btn_Backspace_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_backspace.Visibility = Visibility.Visible;
        }

        private void Btn_Backspace_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_backspace.Visibility = Visibility.Collapsed;
        }
        private void Btn_Enter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_enter.Visibility = Visibility.Visible;
        }

        private void Btn_Enter_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_enter.Visibility = Visibility.Collapsed;
        }
        private void Btn_Shift_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_shift.Visibility = Visibility.Visible;
        }

        private void Btn_Shift_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_shift.Visibility = Visibility.Collapsed;
        }
        private void Btn_Caps_lock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (m_iCaps == false)
            {
                img_caps.Visibility = Visibility.Visible;

            }
            else
            {
                img_caps.Visibility = Visibility.Collapsed;

            }
        }

        private void Btn_Caps_lock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (m_iCaps == false)
            {
                keyboard_alp_Caps.Visibility = Visibility.Visible;
                keyboard_alphabet.Visibility = Visibility.Collapsed;
                keyboard_number.Visibility = Visibility.Collapsed;
                m_iCaps = true;
            }
            else
            {
                keyboard_alp_Caps.Visibility = Visibility.Collapsed;
                keyboard_alphabet.Visibility = Visibility.Visible;
                keyboard_number.Visibility = Visibility.Collapsed;
                m_iCaps = false;
            }
        }
        private void Btn_Number_trans_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (m_iKeyNumber == false)
                img_123.Visibility = Visibility.Visible;
            else
                img_123.Visibility = Visibility.Collapsed;
        }
        //键盘数字转换
        private void Btn_Number_trans_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (m_iKeyNumber == false)
            {//数字键盘进行显示
                keyboard_number.Visibility = Visibility.Visible;
                keyboard_alp_Caps.Visibility = Visibility.Collapsed;
                keyboard_alphabet.Visibility = Visibility.Collapsed;
                img_caps.Visibility = Visibility.Collapsed;
                Btn_Caps_lock.Visibility = Visibility.Collapsed;
                m_iKeyNumber = true;
            }
            else
            {//数字键盘进行隐藏
                if (m_iCaps == false)
                {//小写
                    keyboard_number.Visibility = Visibility.Collapsed;
                    keyboard_alphabet.Visibility = Visibility.Visible;
                    m_iKeyNumber = false;
                }
                else if (m_iCaps == true)
                {//大写
                    keyboard_number.Visibility = Visibility.Collapsed;
                    keyboard_alp_Caps.Visibility = Visibility.Visible;
                    img_caps.Visibility = Visibility.Visible;
                    m_iKeyNumber = false;
                }
                Btn_Caps_lock.Visibility = Visibility.Visible;
            }

        }
        private void Btn_Space_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_space.Visibility = Visibility.Visible;
        }
        private void Btn_Space_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_space.Visibility = Visibility.Collapsed;
        }
        private void Btn_keyLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Left.Visibility = Visibility.Visible;
        }
        private void Btn_keyLeft_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Left.Visibility = Visibility.Collapsed;
        }
        private void Btn_keyUp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_Up.Visibility = Visibility.Visible;
        }
        private void Btn_keyUp_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_Up.Visibility = Visibility.Collapsed;
        }
        private void Btn_keyRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_right.Visibility = Visibility.Visible;
        }
        private void Btn_keyRight_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_right.Visibility = Visibility.Collapsed;
        }
        private void Btn_keyDown_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_down.Visibility = Visibility.Visible;
        }
        private void Btn_keyDown_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_down.Visibility = Visibility.Collapsed;
        }
        private void Btn_New_yes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gd_new_yes_pre.Visibility = Visibility.Visible;
        }

        private void Btn_New_yes_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {//清空短信内容
            gd_new_yes_pre.Visibility = Visibility.Collapsed;
            msg_new_question.Visibility = Visibility.Collapsed;
            Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
            TB_message_new.Text = null;
        }

        private void Btn_New_no_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gd_new_no_pre.Visibility = Visibility.Visible;
        }

        private void Btn_New_no_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            gd_new_no_pre.Visibility = Visibility.Collapsed;
            msg_new_question.Visibility = Visibility.Collapsed;
            Rct_mesaage_shadow.Visibility = Visibility.Collapsed;
        }
    
        private void Btn_Send_text_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rect_Send_text.Visibility = Visibility.Visible;
        }

        private void Btn_Send_text_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Rct_mesaage_shadow.Visibility = Visibility.Visible;
            Rect_Send_text.Visibility = Visibility.Collapsed;
            msg_Sendtext.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Send_Text");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
        }
        //模式转换
        private void Btn_model_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Model_Idel)
            {
                TB_model.Text = "Occupied";
                Img_Xinhao.Visibility = Visibility.Visible;
                Model_Idel = false;
            }
            else
            {
                TB_model.Text = "Idel";
                Img_Xinhao.Visibility = Visibility.Collapsed;
                Model_Idel = true;
            }

        }
        //报警灯闪烁
        public void Frash_text(object sender, EventArgs e)
        {
            if (i_Distress == false)
            {
                if (m_TimerCount % 2 == 1)
                {
                    image_Distress_light.Visibility = Visibility.Visible;
                    m_TimerCount = 0;
                }
                else
                {
                    image_Distress_light.Visibility = Visibility.Collapsed;
                    m_TimerCount = 1;
                }
            }
            else
            {
                if (m_TimerCount % 2 == 1)
                {
                    image_clip.Visibility = Visibility.Visible;
                    m_TimerCount = 0;
                }
                else
                {
                    image_clip.Visibility = Visibility.Collapsed;
                    m_TimerCount = 1;
                }
            }

        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox_Load.SelectedIndex < 0)
            {
                return;
            }
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.i_ListMsg_Select = ListBox_Load.SelectedIndex;         
            Sailor_6300_Radiotelex.m_UC.TB_message_new.Text = Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[ListBox_Load.SelectedIndex].str_Content;           
            Cav_Msg_Load.Visibility = Visibility.Collapsed;
            Rct_mesaage_shadow.Visibility = Visibility.Collapsed;           
        }
        //删除信箱选中项
        private void Btn_load_Delete_Click(object sender, RoutedEventArgs e)
        {
            int j = 0;
            //获取需要删除的选项名称
            string[] Name = new string[Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count]; 
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {               
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                {
                    Name[j] = Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].str_Name;
                    j++;
                }               
            }
            //进行删除
            for (int m = 0; m < j; m++)
            {
                for (int n = 0; n < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; n++)
                {
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[n].str_Name == Name[m])
                    {
                       //  ListBox_Load.Items.Remove(i);
                       Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Remove(Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[n]);                       
                    }
                }
            }
                ListBox_Load.Items.Refresh();
                Check_ListBox();
        }

        private void Btn_load_selectall_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == false)
                {
                    //  ListBox_Load.Items.Remove(i);
                    Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead = true;
                    
                }

            }
           ListBox_Load.Items.Refresh();
        }

        private void Btn_load_clearall_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                {
                    //  ListBox_Load.Items.Remove(i);
                    Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead = false;

                }

            }
            ListBox_Load.Items.Refresh();
        }
         //保存数据
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        	 FileStream fs = new FileStream(@"G:\test.txt", FileMode.Create);
           StreamWriter sw = new StreamWriter(fs);
           foreach (var l in Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg)
           {
               bool bIsRead = l.bIsRead;
               string str_Name = l.str_Name;
               string _str_Content = l.str_Content;
               l.str_Content_temp = l.str_Content;
               string str_Content_temp = l.str_Content_temp;
               string s = bIsRead.ToString() + " " + str_Name + " " + _str_Content + str_Content_temp + "\r\n";
               sw.Write(s);

           }
           sw.Flush();
           sw.Close();
           fs.Close();
        }

        private void Btn_Call_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Img_Call.Visibility = Visibility.Collapsed;
        }

        private void Btn_Call_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Img_Call.Visibility = Visibility.Visible;
            Call_Setup.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Call_Open");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
            Msg_Send = "Call";
        }

        public void Close_Call()
        {
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_Call_Close");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
            Call_Setup.Visibility = Visibility.Collapsed;
            Call_Setup.Visibility = Visibility.Collapsed;
            Msg_Send = "null";
        }

        private void Btn_System_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Img_System.Visibility = Visibility.Collapsed;
        }

        private void Btn_System_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TB_main.Text = "SYSTEM";
            if (Sailor_6300_Radiotelex.m_UC.Usr_System.m_iSystem == 1) TB_subhead.Text = "ABOUT";
            else if (Sailor_6300_Radiotelex.m_UC.Usr_System.m_iSystem == 2) TB_subhead.Text = "POWER";
            else if (Sailor_6300_Radiotelex.m_UC.Usr_System.m_iSystem == 3) TB_subhead.Text = "SETTINGS";
             else if (Sailor_6300_Radiotelex.m_UC.Usr_System.m_iSystem == 4) TB_subhead.Text = "ADVANCED";
            Img_System.Visibility = Visibility.Visible;
            Storyboard SB = new Storyboard();//创建一个故事版
            SB = (Storyboard)this.FindResource("Storyboard_System_Open");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB.Begin();//播放该故事版
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                {
                    Rect_Delete_pre.Visibility = Visibility.Visible;
                    Btn_load_Delete.Visibility = Visibility.Visible;
                    break;
                }
                else
                {
                    Rect_Delete_pre.Visibility = Visibility.Collapsed;
                    Btn_load_Delete.Visibility = Visibility.Collapsed;
                }
            }
        }
        public void Check_ListBox()
        {
            if (Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count == 0) TB_List_empty.Visibility = Visibility.Visible;
            else TB_List_empty.Visibility = Visibility.Collapsed;
        }

        private void Btn_Battery_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        	Img_battery_pre.Visibility=Visibility.Collapsed;
			Img_System.Visibility = Visibility.Visible;
            Sailor_6300_Radiotelex.m_UC.Usr_System.Open_Battery();
            Storyboard SB1 = new Storyboard();//创建一个故事版
            SB1 = (Storyboard)this.FindResource("Storyboard_System_Open");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB1.Begin();//播放该故事版                                                   
        }

        private void Btn_Battery_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Img_battery_pre.Visibility=Visibility.Visible;
            
        }

        private void Btn_Scan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Scan.Visibility = Visibility.Collapsed;
        }

        private void Btn_Scan_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Scan.Visibility = Visibility.Visible;
            TB_main.Text = "SCAN";
            TB_subhead.Text = "SCAN LIST";
            Storyboard SB1 = new Storyboard();//创建一个故事版
            SB1 = (Storyboard)this.FindResource("Storyboard_UsrCtrl_Scan_Open");//从当前xaml的资源中寻找名为Storyboard2的故事版
            SB1.Begin();//播放该故事版  
        }
        private void Btn_Contacts_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Contacts.Visibility = Visibility.Collapsed;
        }

        private void Btn_Contacts_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Img_Contacts.Visibility = Visibility.Visible;
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.UsrCtrl_Contacts.Visibility = Visibility.Visible;
            TB_main.Text = "CONTACTS";
            TB_subhead.Text = "CONTACTS";
            Storyboard SB1 = new Storyboard();//创建一个故事版
           SB1 = (Storyboard)this.FindResource("Storyboard_Contacts_open");//从当前xaml的资源中寻找名为Storyboard2的故事版
           SB1.Begin();//播放该故事版  
        }



    }

}
