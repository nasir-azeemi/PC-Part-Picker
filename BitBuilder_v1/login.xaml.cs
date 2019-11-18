﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
//using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BitBuilder_v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool newuserflag = false;
        bool adminflag = false;
        public MainPage()
        {
            this.InitializeComponent();
            List<users> userlst = new List<users>();
            userlst.Add(new users("admin", "1234"));

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private  void signbttn_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to MyNewPage.xaml   
            if (newuserflag && adminflag)
            {

                // Create the message dialog and set its content
                //var messageDialog = new MessageDialog("user cannot be both new user and admin");

                    // Show the message dialog
                    //await messageDialog.ShowAsync();
                
            }

            else if (newuserflag)
            {
                this.Frame.Navigate(typeof(registerform));
            }
            else if(adminflag)
            {
                this.Frame.Navigate(typeof(admin_dash));
            }
            
            else
            {
                this.Frame.Navigate(typeof(user_dash));
            }
        }

        private void newuser_check_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    newuserflag = true;
                }
                else
                {
                    newuserflag = false;
                }
            }
        }

        private void adminToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    adminflag = true;
                }
                else
                {
                    adminflag = false;
                }
            }
        }
    }

    public class users
    {
        public string id;
        public string pass;

        public users (string id1, string pass1)
        {
            this.id = id1;
            this.pass = pass1;
        }
    }


}