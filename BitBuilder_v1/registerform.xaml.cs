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
    public sealed partial class registerform : Page
    {
        DBconnection c2;
        DataTable d2;
        bool checks_passed;
        public registerform()
        {
            this.InitializeComponent();
            c2 = new DBconnection();
            d2 = c2.Select("select * from City");
            checks_passed = true;
            emailbox.Text = current_register.current_email;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void citycombobox_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < d2.Rows.Count; i++)
            {
                citycombobox.Items.Add(d2.Rows[i]["CityName"]);
            }
        }

        private void registerbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(citycombobox.SelectedItem.ToString());
            c2.Inserts(
                "insert into Customer (CityID, CustomerName, CustomerAddress, Contact)"
                + " values((select CityID from City where CityName like '"+ citycombobox.SelectedItem.ToString() + "'), '"+ namebox.Text +"', '"+ addressbox.Text +"', '" + contactbox.Text + "')"
                );

            c2.Inserts(
                "insert into AppUser (userid, userpassword, isAdmin, CustomerID) values ( '"+ emailbox.Text +"', '"+current_register.currentpass+"', 0, (select max(CustomerID) from Customer) )"
                );
            this.Frame.Navigate(typeof(MainPage));
            return;
        }
    }
}
