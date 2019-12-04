using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BitBuilder_v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class user_dash : Page
    {
        public user_dash()
        {
            this.InitializeComponent();
            welcome_txt.Text = "Welcome " + current_session.customer_name + "!";
        }

        private void newuser_check_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(cart));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void p_search_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(product_search));
            return;

        }

        private void view_cartbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cart));
            return;

        }

        private void order_historybtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(orderhistory));
            return;

        }

        private void acc_settingbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(accdetails));
            return;
        }

        private void upd_detailbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(persdetail));
            return;

        }

        private void create_bldbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(create_build));
            return;
        }

        private void prebuiltbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(view_build));
            return;
        }
    }
}
