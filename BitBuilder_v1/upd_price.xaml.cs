using System;
using System.Collections.Generic;
using System.Data;
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
    public sealed partial class upd_price : Page
    {
        DBconnection c1;
        DataTable d1;
        public upd_price()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
        }

        private void curr_priceBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void upd_bttn_Click(object sender, RoutedEventArgs e)
        {
            c1.Inserts("update Products set UnitPrice = " + new_priceBox.Text + " where ProductID = " + ID_box.Text);

            this.Frame.Navigate(typeof(admin_dash));
            return;
        }

        private void cancel_bttn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));
            return;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void search_bttn_Click(object sender, RoutedEventArgs e)
        {
            d1 = c1.Select("select * from Products where ProductID = " + ID_box.Text);
            string price_old = "";

            foreach (DataRow row in d1.Rows)
            {
                if (ID_box.Text == row["ProductID"].ToString())
                {
                    price_old = row["UnitPrice"].ToString();
                    break;
                }
            }

            curr_priceBox.Text = price_old;
        }
    }
}
