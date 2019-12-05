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
    public sealed partial class add_proc : Page
    {
        DBconnection c1;
        DataTable socketdt, branddt, vendordt;
        public add_proc()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            branddt = c1.Select("select * from Brand");
            socketdt = c1.Select("select * from Socket");
            vendordt = c1.Select("select * from Vendor");

            type_box.Text = "Processor";

            for (int i = 0; i < branddt.Rows.Count; i++)
            {
                brand_combobox.Items.Add(branddt.Rows[i]["BrandName"]);
            }

            for (int i = 0; i < socketdt.Rows.Count; i++)
            {
                socket_combobox.Items.Add(socketdt.Rows[i]["SocketName"]);
            }

            for (int i = 0; i < vendordt.Rows.Count; i++)
            {
                vendor_combobox.Items.Add(vendordt.Rows[i]["VendorName"]);
            }
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            c1.Inserts(
                "insert into Products (VendorID, TypeID, BrandID, ProductName, IsAvailable, UnitPrice)"
                + " values ((select VendorID from Vendor where VendorName like '"+vendor_combobox.SelectedItem.ToString() +"'), " +
                "2, (select BrandID from Brand where BrandName like '"+ brand_combobox.SelectedItem.ToString() + "'), '"+namebox.Text+"', 1, "+pricebox.Text+")"
                );

            c1.Inserts(
                "insert into Processor values ((select max(ProductID) from Products), (select SocketID from Socket where SocketName like '" + socket_combobox.SelectedItem.ToString() + "')" +
                ", " +clock_box.Text+")"
                );

            ContentDialog successmsg = new ContentDialog
            {
                Title = "Product Added",
                Content = "Processor succesfully added.",
                CloseButtonText = "OK"
            };
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
    }
}
