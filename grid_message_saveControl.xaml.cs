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
using Sailor_6300_Radiotelex_D.ViewModel;
using Sailor_6300_Radiotelex_D.Model;
using Sailor_6300_Radiotelex_D.common;
namespace Sailor_6300_Radiotelex_D
{
	/// <summary>
	/// grid_message_saveControl.xaml 的交互逻辑
	/// </summary>
    public partial class grid_message_saveControl : UserControl
    {
        bool IscheckedOn = true;//工具栏显示


        public grid_message_saveControl()
        {
            this.InitializeComponent();
            Btn_Save_tools.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Save_tools_MouseLeftButtonDown), true);
            Btn_Save_tools.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Save_tools_MouseLeftButtonUp), true);
            Btn_Save_Selectall.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Save_Selectall_MouseLeftButtonDown), true);
            Btn_Save_Selectall.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Save_Selectall_MouseLeftButtonUp), true);
            Btn_Save_Clearall.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Save_Clearall_MouseLeftButtonDown), true);
            Btn_Save_Clearall.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Save_Clearall_MouseLeftButtonUp), true);
            Btn_Save_Delete.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Btn_Save_Delete_MouseLeftButtonDown), true);
            Btn_Save_Delete.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Btn_Save_Delete_MouseLeftButtonUp), true);
            // Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg
        }

        private void Btn_Save_close_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void Btn_Save_tools_Click(object sender, RoutedEventArgs e)
        {

            if (IscheckedOn)
            {
                ListBox_Save.ItemTemplate = (DataTemplate)this.FindResource("ListItem_Msg_Din");
                ListBox_Save.Items.Refresh();
                ca_btn_select_all.Visibility = Visibility.Visible;
                ca_btn_clear_all.Visibility = Visibility.Visible;
                Cav_Delete.Visibility = Visibility.Visible;
                Btn_Save_Clearall.Visibility = Visibility.Visible;
                Btn_Save_Selectall.Visibility = Visibility.Visible;
                Btn_Save_Delete.Visibility = Visibility.Visible;
                IscheckedOn = false;

            }
            else
            {
                ListBox_Save.ItemTemplate = (DataTemplate)this.FindResource("ListItem_Msg");
                ListBox_Save.Items.Refresh();
                ca_btn_select_all.Visibility = Visibility.Collapsed;
                ca_btn_clear_all.Visibility = Visibility.Collapsed;
                Cav_Delete.Visibility = Visibility.Collapsed;
                Btn_Save_Clearall.Visibility = Visibility.Collapsed;
                Btn_Save_Selectall.Visibility = Visibility.Collapsed;
                Btn_Save_Delete.Visibility = Visibility.Collapsed;
                IscheckedOn = true;
            }

        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            // Sailor_6300_Radiotelex_D.ViewModel.ViewModel_Sailor6300 c = new ViewModel_Sailor6300();
            if (string.IsNullOrWhiteSpace(TB_save_file.Text) == true)
            { 
            
            }
            else
            {
                _Msg_Save Data = new _Msg_Save();
                Data.str_Name = TB_save_file.Text;
                Data.str_Content = Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.TB_message_new.Text;
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Add(Data);
                //  int i = Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count-1;
                // Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].str_Name = TB_save_file.Text;
                ListBox_Save.Items.Refresh();
                Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.ListBox_Load.Items.Refresh();
                TB_save_file.Text = null;
                this.Visibility = Visibility.Collapsed;
            }
         //  Check_ListBox();
            
        }

        private void Btn_Save_Selectall_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ca_btn_select_all_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Save_Selectall_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ca_btn_select_all_pre.Visibility = Visibility.Collapsed;
            //和Btn_Save_Clearall的互斥效果
            Btn_Save_Selectall.Visibility = Visibility.Collapsed;
            Btn_Save_Clearall.Visibility = Visibility.Visible;
            Rect_Clearall.Visibility = Visibility.Visible;
            Rect_Selelctall.Visibility = Visibility.Collapsed;
          //  Check_ListBox();
        }

        private void Btn_Save_Clearall_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ca_btn_clear_all_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Save_Clearall_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ca_btn_clear_all_pre.Visibility = Visibility.Collapsed;
            //和Btn_Save_Selectall的互斥效果
            Btn_Save_Selectall.Visibility = Visibility.Visible;
            Rect_Selelctall.Visibility = Visibility.Visible;
            Btn_Save_Clearall.Visibility = Visibility.Collapsed;
            Rect_Clearall.Visibility = Visibility.Collapsed;
          //  Check_ListBox();
        }

        private void Btn_Save_tools_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ca_btn_tools_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Save_tools_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ca_btn_tools_pre.Visibility = Visibility.Collapsed;
        }

        private void Btn_Save_Selectall_Click(object sender, RoutedEventArgs e)
        {
            //    List<_Msg_Save> hh = new List<_Msg_Save>(); 
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == false)
                {
                    //  ListBox_Load.Items.Remove(i);
                    Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead = true;

                }

            }
            ListBox_Save.Items.Refresh();

        }
        //清空选中项
        private void Btn_Save_Clearall_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                {
                    //  ListBox_Load.Items.Remove(i);
                    Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead = false;

                }

            }
            ListBox_Save.Items.Refresh();
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          /*  if (ListBox_Save.SelectedIndex != -1)
            {
                Rect_Delete.Visibility = Visibility.Visible;
                Btn_Save_Delete.Visibility = Visibility.Visible;
            }
            else
            {
                Rect_Delete.Visibility = Visibility.Collapsed;
                Btn_Save_Delete.Visibility = Visibility.Collapsed;
            }*/
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.i_ListMsg_Select = ListBox_Save.SelectedIndex;
            Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_UC.TB_message_new.Text = Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[ListBox_Save.SelectedIndex].str_Content;
            this.Visibility = Visibility.Collapsed;
        }


        private void Btn_Save_Delete_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Rect_Delete_pre.Visibility = Visibility.Visible;
        }

        private void Btn_Save_Delete_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Rect_Delete_pre.Visibility = Visibility.Collapsed;
        }

        private void TB_save_file_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TB_save_file.Text == null)
            {
                Btn_Save.Visibility = Visibility.Collapsed;
            }
            else
            {
                Btn_Save.Visibility = Visibility.Visible;
            }
        }
        private void Btn_Save_Delete_Click(object sender, RoutedEventArgs e)
        {
            int j = 0;
            //获取需要删除的选项名称
            string[] Name = new string[Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count];
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                {
                    //  ListBox_Load.Items.Remove(i);
                    //  Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Remove(Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i]);
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
                        Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Remove(Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[n]);
                    }
                }
            }
            Check_ListBox();

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
            {
                if (Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                {
                    Rect_Delete_pre.Visibility = Visibility.Visible;
                    Btn_Save_Delete.Visibility = Visibility.Visible;
                    break;
                }
                else
                {
                    Rect_Delete_pre.Visibility = Visibility.Collapsed;
                    Btn_Save_Delete.Visibility = Visibility.Collapsed;
                    
                }
            }
           // Check_ListBox();
        }
        public void Check_ListBox()
        { 
            if (Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count == 0) 
                TB_List_empty.Visibility = Visibility.Visible;
            else 
                TB_List_empty.Visibility = Visibility.Collapsed;
                
        }

   /*    public void Check_ListBox2()
        {
            Btn_Save_Delete.Visibility = Visibility.Collapsed;
            Rect_Delete.Visibility = Visibility.Collapsed;
            if (Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count == 0)
            {
                TB_List_empty.Visibility = Visibility.Visible;
                Btn_Save_Selectall.Visibility = Visibility.Collapsed;
                Btn_Save_Clearall.Visibility = Visibility.Collapsed;
                Rect_Selelctall.Visibility = Visibility.Collapsed;
                Rect_Clearall.Visibility = Visibility.Collapsed;
                Btn_Save_Delete.Visibility = Visibility.Collapsed;
                Rect_Delete.Visibility = Visibility.Collapsed;
            }
            else
            {
                TB_List_empty.Visibility = Visibility.Collapsed;
             // Btn_Save_Clearall.Visibility = Visibility.Collapsed;
             //   Btn_Save_Selectall.Visibility = Visibility.Visible;
             //   Rect_Selelctall.Visibility = Visibility.Visible;
            //  Rect_Clearall.Visibility = Visibility.Visible;
                for (int i = 0; i < Sailor_6300_Radiotelex_D.Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg.Count; i++)
                {
                    if (Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == true)
                    {
                        Btn_Save_Clearall.Visibility = Visibility.Visible;
                        Rect_Clearall.Visibility = Visibility.Visible;
                        Btn_Save_Delete.Visibility = Visibility.Visible;
                        Rect_Delete.Visibility = Visibility.Visible;
                        break;
                    }
                    else
                    {
                        Btn_Save_Clearall.Visibility = Visibility.Collapsed;
                        Rect_Clearall.Visibility = Visibility.Collapsed;
                        Btn_Save_Delete.Visibility = Visibility.Collapsed;
                        Rect_Delete.Visibility = Visibility.Collapsed;
                    }
                    if (Sailor_6300_Radiotelex.m_Data.m_Info.ListMsg[i].bIsRead == false)
                    {
                        Btn_Save_Selectall.Visibility = Visibility.Visible;
                        Rect_Selelctall.Visibility = Visibility.Visible;
                        break;
                    }
                    else
                    {
                        Btn_Save_Selectall.Visibility = Visibility.Collapsed;
                        Rect_Selelctall.Visibility = Visibility.Collapsed;
                        Btn_Save_Delete.Visibility = Visibility.Visible;
                        Rect_Delete.Visibility = Visibility.Visible;
                    }
                    

                }
            }
            
                
            
        }*/
        
    }
}