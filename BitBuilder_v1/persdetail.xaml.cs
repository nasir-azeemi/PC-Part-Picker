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
    public sealed partial class persdetail : Page
    {
        DBconnection c1;
        public persdetail()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            namebox.Text = current_session.customer_name;
            address_box.Text = current_session.customer_addr;
            contact_box.Text = current_session.contact;
            
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));


        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));
            return;
        }

        private void namebox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void citycombobox_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable d2 = new DataTable();
            d2 = c1.Select("select * from City");
            
            for (int i = 0; i < d2.Rows.Count; i++)
            {
                citycombobox.Items.Add(d2.Rows[i]["CityName"]);
            }

            string temp = "";

            for (int i = 0; i < d2.Rows.Count; i++)
            {
                if (current_session.customer_cityid == d2.Rows[i]["CityID"].ToString())
                {
                    temp = d2.Rows[i]["CityName"].ToString();
                    break;
                }
            }

            citycombobox.SelectedItem = temp;
        }
    }
}
