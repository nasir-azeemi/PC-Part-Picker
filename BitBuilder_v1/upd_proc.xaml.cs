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
    public sealed partial class upd_proc : Page
    {
        DBconnection c1;
        DataTable prod_dt, brand_dt, socket_dt;
        public upd_proc()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            prod_dt = new DataTable();

            brand_dt = c1.Select("select * from Brand");
            socket_dt = c1.Select("select * from Socket");

            for (int i = 0; i < brand_dt.Rows.Count; i++)
            {
                brandbox.Items.Add(brand_dt.Rows[i]["BrandName"]);
            }

            for (int i = 0; i < socket_dt.Rows.Count; i++)
            {
                socketbox.Items.Add(socket_dt.Rows[i]["SocketName"]);
            }

        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
        }


        private void cancel_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


        private void type_box_changed(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            prod_dt = c1.Select("select * from Products p inner join Processor p1 on p.ProductID = p1.ProductID inner join Vendor v on p.VendorID = v.VendorID inner join Brand on p.BrandID = Brand.BrandID inner join Socket S on p1.SocketID = S.SocketID");
            //

            foreach(DataRow row in prod_dt.Rows)
            {
                    if (search_box.Text == row["ProductID"].ToString())
                {
                    namebox.Text = row["ProductName"].ToString();
                    price_box.Text = row["UnitPrice"].ToString();
                    type_box.Text = "Processor";
                    clock_box.Text = row["ClockSpeed"].ToString();
                    vendor_box.Text = row["VendorName"].ToString();
                    brandbox.SelectedItem = row["BrandName"].ToString();
                    socketbox.SelectedItem = row["SocketName"].ToString();
                }
            }
        }
    }
}
