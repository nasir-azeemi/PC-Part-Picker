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
    public sealed partial class orderhistory : Page
    {
        DBconnection c1;
        DataTable ord_tb;
        public orderhistory()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            ord_tb = c1.Select("select o.OrderID, o.CustomerID, o.OrderDate, sum(oi.UnitPrice) as [Total Price] from Orders o, OrderItem oi where o.OrderID = oi.OrderID and CustomerID = " + current_session.customer_id + " group by o.OrderID, o.CustomerID, o.OrderDate");
            current_session.FillDataGrid(ord_tb, order_histgrid);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void returnbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));
            return;
        }
    }
}
