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
using System.Runtime.InteropServices;
using System.Windows.Interop;


namespace Sailor_6300_Radiotelex_D
{
    /// <summary>
    /// Edit_value.xaml 的交互逻辑
    /// </summary>
    public partial class Edit_value : UserControl
    {
        public int m_iTB=2;
        
        public Edit_value()
        {
            this.InitializeComponent();
            Btn_1.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_1_MouseLeftButtonDown), true);
            Btn_1.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_1_MouseLeftButtonUp), true);
            Btn_2.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_2_MouseLeftButtonDown), true);
            Btn_2.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_2_MouseLeftButtonUp), true);
            Btn_3.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_3_MouseLeftButtonDown), true);
            Btn_3.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_3_MouseLeftButtonUp), true);
            Btn_4.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_4_MouseLeftButtonDown), true);
            Btn_4.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_4_MouseLeftButtonUp), true);
            Btn_5.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_5_MouseLeftButtonDown), true);
            Btn_5.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_5_MouseLeftButtonUp), true);
            Btn_6.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_6_MouseLeftButtonDown), true);
            Btn_6.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_6_MouseLeftButtonUp), true);
            Btn_7.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_7_MouseLeftButtonDown), true);
            Btn_7.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_7_MouseLeftButtonUp), true);
            Btn_8.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_8_MouseLeftButtonDown), true);
            Btn_8.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_8_MouseLeftButtonUp), true);
            Btn_9.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_9_MouseLeftButtonDown), true);
            Btn_9.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_9_MouseLeftButtonUp), true);
            Btn_0.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_0_MouseLeftButtonDown), true);
            Btn_0.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_0_MouseLeftButtonUp), true);
            Btn_Cancel.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Cancel_MouseLeftButtonDown), true);
            Btn_Cancel.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Cancel_MouseLeftButtonUp), true);
            Btn_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_OK_MouseLeftButtonDown), true);
            Btn_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_OK_MouseLeftButtonUp), true);
            Btn_Back_space.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Back_space_MouseLeftButtonDown), true);
            Btn_Back_space.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Back_space_MouseLeftButtonUp), true);
            Btn_CallCode_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_CallCode_OK_MouseLeftButtonDown), true);
            Btn_CallCode_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_CallCode_OK_MouseLeftButtonUp), true);
            Btn_TX_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_TX_OK_MouseLeftButtonDown), true);
            Btn_TX_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_TX_OK_MouseLeftButtonUp), true);
            Btn_RX_OK.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_RX_OK_MouseLeftButtonDown), true);
            Btn_RX_OK.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_RX_OK_MouseLeftButtonUp), true);
            TB_Callcode.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TB_Callcode_MouseLeftButtonDown), true);
            TB_TX.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TB_TX_MouseLeftButtonDown), true);
            TB_TX_dec.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TB_TX_dec_MouseLeftButtonDown), true);
            TB_RX.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TB_RX_MouseLeftButtonDown), true);
            TB_RX_dec.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TB_RX_dec_MouseLeftButtonDown), true);
        }

        private void Btn_1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_1.Visibility = Visibility.Visible;
        }

        private void Btn_1_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_1.Visibility = Visibility.Collapsed;
            InputNum(1);
                                      
        }
        private void Btn_2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_2.Visibility = Visibility.Visible;
        }

        private void Btn_2_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_2.Visibility = Visibility.Collapsed;
            InputNum(2);
            
           
        }
        private void Btn_3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_3.Visibility = Visibility.Visible;
        }

        private void Btn_3_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_3.Visibility = Visibility.Collapsed;
            InputNum(3);
           
        }
        private void Btn_4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_4.Visibility = Visibility.Visible;
        }

        private void Btn_4_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_4.Visibility = Visibility.Collapsed;
        
            InputNum(4);
        }
        private void Btn_5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_5.Visibility = Visibility.Visible;
        }

        private void Btn_5_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_5.Visibility = Visibility.Collapsed;
            InputNum(5);
           
        }
        private void Btn_6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_6.Visibility = Visibility.Visible;
        }

        private void Btn_6_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_6.Visibility = Visibility.Collapsed;
            InputNum(6);
           
        }
        private void Btn_7_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_7.Visibility = Visibility.Visible;
        }

        private void Btn_7_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_7.Visibility = Visibility.Collapsed;
            InputNum(7);
            
        }
        private void Btn_8_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_8.Visibility = Visibility.Visible;
        }

        private void Btn_8_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_8.Visibility = Visibility.Collapsed;
            InputNum(8);
           
        }
        private void Btn_9_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_9.Visibility = Visibility.Visible;
        }

        private void Btn_9_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_9.Visibility = Visibility.Collapsed;
            InputNum(9);
            
        }
        private void Btn_0_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_0.Visibility = Visibility.Visible;
        }

        private void Btn_0_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_0.Visibility = Visibility.Collapsed;
            InputNum(0);
            
        }
        private void Btn_Back_space_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_back_space.Visibility = Visibility.Visible;
        }

        private void Btn_Back_space_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            img_back_space.Visibility = Visibility.Collapsed;
       /*     if (i == -1)
            {
               
            }*/
         //   TB_Callcode.Text.Substring(0, TB_Callcode.Text.Length - 2);
         //   TB_Callcode.Text.Remove(TB_Callcode.Text.Length-1,1);
        }
        private void Btn_Cancel_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cancel_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_Cancel_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cancel_Copy.Visibility = Visibility.Collapsed;
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message") Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Rect_Call_Setupshadow.Visibility = Visibility.Collapsed;

            this.Visibility = Visibility.Collapsed;

        }
        private void Btn_OK_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OK_Copy.Visibility = Visibility.Visible;
        }

        private void Btn_OK_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OK_Copy.Visibility = Visibility.Collapsed;
            int TB1_length = TB_Callcode.Text.Length;	//Callcode的长度
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message")
            {
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 1)
                {
                    float TB2;//TX的频率值
                    float TB3;//RX的频率值
                    int TB2_Int, TB2_dec;//TX和RX的整数和小数部分
                    int TB3_Int, TB3_dec;//TX和RX的整数和小数部分
                    TB1_length = (int)TB_Callcode.Text.Length;
                    TB2_Int = Convert.ToInt32(TB_TX.Text);
                    TB2_dec = Convert.ToInt32(TB_TX_dec.Text);
                    TB3_Int = Convert.ToInt32(TB_RX.Text);
                    TB3_dec = Convert.ToInt32(TB_RX_dec.Text);
                    TB2 = (float)(TB2_Int + TB2_dec / 10);
                    TB3 = (float)(TB3_Int + TB3_dec / 10);
                    Check_Textbox(TB1_length, TB2, TB3);
                }
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 2)
                {
                    if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
                    {
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Rect_Call_Setupshadow.Visibility = Visibility.Collapsed;
                        this.Visibility = Visibility.Collapsed;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Tb_CallCode.Text = TB_Callcode.Text;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_Channel.Text = TB_Channel.Text;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.ChannelRules(2);
                    }
                    else
                    {
                        Call_code_Warning.Visibility = Visibility.Visible;
                        Storyboard SB1 = new Storyboard();//创建一个故事版
                        SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                        SB1.Begin();//播放该故事版
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 3)
                {
                    if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
                    {
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Rect_Call_Setupshadow.Visibility = Visibility.Collapsed;
                        this.Visibility = Visibility.Collapsed;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Tb_CallCode.Text = TB_Callcode.Text;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_Channel.Text = TB_Channel.Text;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.ChannelRules(3);
                    }
                    else
                    {
                        Call_code_Warning.Visibility = Visibility.Visible;
                        Storyboard SB1 = new Storyboard();//创建一个故事版
                        SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                        SB1.Begin();//播放该故事版
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 4)
                {
                    int Ch = 0;
                    Ch = Convert.ToInt32(TB_Channel.Text);
                    if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
                    {
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Rect_Call_Setupshadow.Visibility = Visibility.Collapsed;
                        this.Visibility = Visibility.Collapsed;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Tb_CallCode.Text = TB_Callcode.Text;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_Channel.Text = TB_Channel.Text;
                        Sailor_6300_Radiotelex.m_UC.msg_Sendtext.ChannelRules(4);
                    }
                    else
                    {
                        Call_code_Warning.Visibility = Visibility.Visible;
                        Storyboard SB1 = new Storyboard();//创建一个故事版
                        SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                        SB1.Begin();//播放该故事版
                    }

                }
            }
            else if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Call")
            {
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 1)
                {
                    float TB2;//TX的频率值
                    float TB3;//RX的频率值
                    int TB2_Int, TB2_dec;//TX和RX的整数和小数部分
                    int TB3_Int, TB3_dec;//TX和RX的整数和小数部分
                    TB1_length = (int)TB_Callcode.Text.Length;
                    TB2_Int = Convert.ToInt32(TB_TX.Text);
                    TB2_dec = Convert.ToInt32(TB_TX_dec.Text);
                    TB3_Int = Convert.ToInt32(TB_RX.Text);
                    TB3_dec = Convert.ToInt32(TB_RX_dec.Text);
                    TB2 = (float)(TB2_Int + TB2_dec / 10);
                    TB3 = (float)(TB3_Int + TB3_dec / 10);
                    Check_Textbox(TB1_length, TB2, TB3);
                }
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 2)
                {
                    if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
                    {

                        this.Visibility = Visibility.Collapsed;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.Tb_CallCode.Text = TB_Callcode.Text;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_Channel.Text = TB_Channel.Text;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.ChannelRules(2);
                    }
                    else
                    {
                        Call_code_Warning.Visibility = Visibility.Visible;
                        Storyboard SB1 = new Storyboard();//创建一个故事版
                        SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                        SB1.Begin();//播放该故事版
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 3)
                {
                    if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
                    {

                        this.Visibility = Visibility.Collapsed;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.Tb_CallCode.Text = TB_Callcode.Text;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_Channel.Text = TB_Channel.Text;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.ChannelRules(3);
                    }
                    else
                    {
                        Call_code_Warning.Visibility = Visibility.Visible;
                        Storyboard SB1 = new Storyboard();//创建一个故事版
                        SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                        SB1.Begin();//播放该故事版
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 4)
                {
                    int Ch = 0;
                    Ch = Convert.ToInt32(TB_Channel.Text);
                    if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
                    {

                        this.Visibility = Visibility.Collapsed;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.Tb_CallCode.Text = TB_Callcode.Text;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_Channel.Text = TB_Channel.Text;
                        Sailor_6300_Radiotelex.m_UC.Call_Setup.ChannelRules(4);
                    }
                    else
                    {
                        Call_code_Warning.Visibility = Visibility.Visible;
                        Storyboard SB1 = new Storyboard();//创建一个故事版
                        SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                        SB1.Begin();//播放该故事版
                    }

                }
            }




        }
        public void Check_Textbox(int TB1_length, float TB2, float TB3)
        {
            if (TB1_length == 4 || TB1_length == 5 || TB1_length == 9)
            {
                if (TB3 >= 490.0 && TB3 <= 27500.0)
                {
                    if (TB2 >= 1605.0 && TB2 <= 26175.0)
                    {
                        if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message")
                        {
                            Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Rect_Call_Setupshadow.Visibility = Visibility.Collapsed;
                            this.Visibility = Visibility.Collapsed;
                            Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Tb_CallCode.Text = TB_Callcode.Text;
                        }
                        else if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Call")
                        {
                            this.Visibility = Visibility.Collapsed;
                            Sailor_6300_Radiotelex.m_UC.Call_Setup.Tb_CallCode.Text = TB_Callcode.Text;
                        }
                    }
                    else
                    {
                        TX_Warning.Visibility = Visibility.Visible;
                        Storyboard SB3 = new Storyboard();//创建一个故事版,作为开机动画
                        SB3 = (Storyboard)this.FindResource("Storyboard_TX_warning");//从当前xaml的资源中寻找
                        SB3.Begin();//播放该故事版
                    }
                }
                else
                {
                    RX_Warning.Visibility = Visibility.Visible;
                    Storyboard SB2 = new Storyboard();//创建一个故事版
                    SB2 = (Storyboard)this.FindResource("Storyboard_RX_warning");//从当前xaml的资源中寻找
                    SB2.Begin();//播放该故事版	
                }
            }
            else
            {
                Call_code_Warning.Visibility = Visibility.Visible;
                Storyboard SB1 = new Storyboard();//创建一个故事版
                SB1 = (Storyboard)this.FindResource("Storyboard_Callcode_warning");//从当前xaml的资源中寻找
                SB1.Begin();//播放该故事版
            }
        }
        private void Btn_TX_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_TX_warning_OK.Visibility = Visibility.Visible;
        }

        private void Btn_TX_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_TX_warning_OK.Visibility = Visibility.Collapsed;
            TX_Warning.Visibility = Visibility.Collapsed;
        }

        private void Btn_RX_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_RX_warning_OK.Visibility = Visibility.Visible;
        }

        private void Btn_RX_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_RX_warning_OK.Visibility = Visibility.Collapsed;
            RX_Warning.Visibility = Visibility.Collapsed;
        }

        private void Btn_CallCode_OK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_callCode_warning_OK.Visibility = Visibility.Visible;
        }

        private void Btn_CallCode_OK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_callCode_warning_OK.Visibility = Visibility.Collapsed;
            Call_code_Warning.Visibility = Visibility.Collapsed;
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
        #region  TextBox能够全选
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
        #endregion
        #region  模拟键盘事件
        public static class SendKeys
        {
            /// <summary>
            ///   Sends the specified key.
            /// </summary>
            /// <param name="key">The key.</param>
            public static void Send(Key key)
            {
                if (Keyboard.PrimaryDevice != null)
                {
                    if (Keyboard.PrimaryDevice.ActiveSource != null)
                    {
                        var e1 = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.Down) { RoutedEvent = Keyboard.KeyDownEvent };
                        InputManager.Current.ProcessInput(e1);
                    }
                }
            }
        }
        #endregion


        private void Btn_OK_Click_1(object sender, RoutedEventArgs e)
        {
            double text_RX = 0;
            double text_TX = 0;
            
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message")
            {
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.Tb_CallCode.Text = TB_Callcode.Text;
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 1)
                {
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Call_setup == 1)
                    {
                        text_RX = Convert.ToDouble(TB_RX.Text) + 0.1 * Convert.ToDouble(TB_RX_dec.Text);
                        text_TX = Convert.ToDouble(TB_TX.Text) + 0.1 * Convert.ToDouble(TB_TX_dec.Text);
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_RX.Text = text_RX.ToString();
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_TX.Text = text_TX.ToString();
                    }
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Call_setup == 2)
                    {
                        text_TX = Convert.ToDouble(TB_TX.Text) + 0.1 * Convert.ToDouble(TB_TX_dec.Text);
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_TX.Text = text_TX.ToString();
                    }
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Call_setup == 3)
                    {
                        text_TX = Convert.ToDouble(TB_TX.Text) + 0.1 * Convert.ToDouble(TB_TX_dec.Text);
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.msg_Sendtext.TB_TX_broad.Text = text_TX.ToString();
                    }

                }
            }
            else if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Call")
            {
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.Tb_CallCode.Text = TB_Callcode.Text;
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 1)
                {
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Call_setup == 1)
                    {
                        text_RX = Convert.ToDouble(TB_RX.Text) + 0.1 * Convert.ToDouble(TB_RX_dec.Text);
                        text_TX = Convert.ToDouble(TB_TX.Text) + 0.1 * Convert.ToDouble(TB_TX_dec.Text);
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_RX.Text = text_RX.ToString();
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_TX.Text = text_TX.ToString();
                    }
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Call_setup == 2)
                    {
                        text_TX = Convert.ToDouble(TB_TX.Text) + 0.1 * Convert.ToDouble(TB_TX_dec.Text);
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_TX.Text = text_TX.ToString();
                    }
                    if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Call_setup == 3)
                    {
                        text_TX = Convert.ToDouble(TB_TX.Text) + 0.1 * Convert.ToDouble(TB_TX_dec.Text);
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.Call_Setup.TB_TX_broad.Text = text_TX.ToString();
                    }

                }
            }



        }

        public void Change_Channel()
        {
            Call_code.Visibility = Visibility.Collapsed;
            Cav_Channel.Visibility = Visibility.Collapsed;
            Cav_RXfreq.Visibility = Visibility.Collapsed;
            Cav_TXfreq.Visibility = Visibility.Collapsed;
            Cav_TXfreq_Broad.Visibility = Visibility.Collapsed;
            Lb_Coast.Visibility = Visibility.Collapsed;
            Lb_Distress.Visibility = Visibility.Collapsed;
            Lb_Intership.Visibility = Visibility.Collapsed;
            if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Message")
            {
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Call_setup == 1)
                {
                    if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 1)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_RXfreq.Visibility = Visibility.Visible;
                        Cav_TXfreq.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 2)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Intership.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 3)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Coast.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 4)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Distress.Visibility = Visibility.Visible;
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Call_setup == 2)
                {
                    if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 1)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_TXfreq.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 2)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Intership.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 3)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Coast.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 4)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Distress.Visibility = Visibility.Visible;
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Call_setup == 3)
                {
                    if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 1)
                    {
                        Cav_TXfreq_Broad.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 2)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Intership.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 3)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Coast.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.msg_Sendtext.BL_Channel == 4)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Distress.Visibility = Visibility.Visible;
                    }
                }
            }
            else if (Sailor_6300_Radiotelex.m_UC.Msg_Send == "Call")
            {
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Call_setup == 1)
                {
                    if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 1)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_RXfreq.Visibility = Visibility.Visible;
                        Cav_TXfreq.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 2)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Intership.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 3)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Coast.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 4)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Distress.Visibility = Visibility.Visible;
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Call_setup == 2)
                {
                    if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 1)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_TXfreq.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 2)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Intership.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 3)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Coast.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 4)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Distress.Visibility = Visibility.Visible;
                    }
                }
                if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Call_setup == 3)
                {
                    if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 1)
                    {
                        Cav_TXfreq_Broad.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 2)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Intership.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 3)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Coast.Visibility = Visibility.Visible;
                    }
                    else if (Sailor_6300_Radiotelex.m_UC.Call_Setup.BL_Channel == 4)
                    {
                        Call_code.Visibility = Visibility.Visible;
                        Cav_Channel.Visibility = Visibility.Visible;
                        Lb_Distress.Visibility = Visibility.Visible;
                    }
                }
            }


        }

        private void TB_Callcode_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            m_iTB = 1;
            TB_Callcode.Focus();
        }

        private void TB_TX_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            m_iTB = 2;
            TB_TX.Focus();
        }

        private void TB_TX_dec_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            m_iTB = 3;
            TB_TX_dec.Focus();
        }

        private void TB_RX_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            m_iTB = 4;
            TB_RX.Focus();
        }

        private void TB_RX_dec_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            m_iTB = 5;
            TB_RX_dec.Focus();
        }

        public void InputNum(int i)
        {
            if (m_iTB == 1)
            {
                if (TB_Callcode.Text.Length < 9)
                {
                    TB_Callcode.SelectedText = i.ToString();   // 插入文本
                    TB_Callcode.SelectionLength = 0;           // 在插入符处
                    TB_Callcode.SelectionStart += 1;
                    TB_Callcode.Focus();
                }

            }
            else if (m_iTB == 2)
            {
                if (TB_TX.Text.Length < 5)
                {
                    TB_TX.SelectedText = i.ToString();   // 插入文本
                    TB_TX.SelectionLength = 0;           // 在插入符处
                    TB_TX.SelectionStart += 1;
                    TB_TX.Focus();
                }

            }
            else if (m_iTB == 3)
            {
                if (TB_TX_dec.Text.Length < 1)
                {
                    TB_TX_dec.SelectedText = i.ToString();   // 插入文本
                    TB_TX_dec.SelectionLength = 0;           // 在插入符处
                    TB_TX_dec.SelectionStart += 1;
                    TB_TX_dec.Focus();
                }
            }
            else if (m_iTB == 4)
            {
                if (TB_RX.Text.Length < 5)
                {
                    TB_RX.SelectedText = i.ToString();   // 插入文本
                    TB_RX.SelectionLength = 0;           // 在插入符处
                    TB_RX.SelectionStart += 1;
                    TB_RX.Focus();
                }
            }
            else if (m_iTB == 5)
            {
                if (TB_RX_dec.Text.Length < 1)
                {
                    TB_RX_dec.SelectedText = i.ToString();   // 插入文本
                    TB_RX_dec.SelectionLength = 0;           // 在插入符处
                    TB_RX_dec.SelectionStart += 1;
                    TB_RX_dec.Focus();
                }
            }
            else if (m_iTB == 6)
            {
                if (TB_Channel.Text.Length < 9)
                {
                    TB_Channel.SelectedText = i.ToString();   // 插入文本
                    TB_Channel.SelectionLength = 0;           // 在插入符处
                    TB_Channel.SelectionStart += 1;
                    TB_Channel.Focus();
                }              
            }
           
        }

        private void TB_Channel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            m_iTB = 6;
            TB_Channel.Focus();
        }

    
      

 
  


    }
}