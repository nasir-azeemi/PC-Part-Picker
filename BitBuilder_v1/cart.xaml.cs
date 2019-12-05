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
    public sealed partial class cart : Page
    {
        DBconnection c1;
        public cart()
        {
            this.InitializeComponent();
            cart_list.ItemsSource = Cart.cart_collection;
            c1 = new DBconnection();
        }

        private void returnbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));
        }

        private void InventoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void chkoutbtn_Click(object sender, RoutedEventArgs e)
        {
            c1.Inserts("insert into Orders (CustomerID, OrderDate) values ('" +current_session.customer_id+"', getdate())");

            foreach(var cartitem in Cart.cart_collection)
            {
                if(cartitem.is_build)
                {
                    c1.Inserts("insert into OrderItem(BuildID, OrderID, UnitPrice, Quantity) values ('"+cartitem.buildid+"', (select max(OrderID) from Orders), (select UnitPrice from Builds where BuildID = '"+
                        cartitem.buildid+"'), 1 )");
                }
                else
                {
                    c1.Inserts("insert into OrderItem(ProductID, OrderID, UnitPrice, Quantity) values ('" + cartitem.itemid + "', (select max(OrderID) from Orders), (select UnitPrice from Products where ProductID = '" +
                        cartitem.itemid + "'), 1 )");

                }
            }
            Cart.clear_cart();
            ContentDialog success = new ContentDialog
            {
                Title = "Order Placed",
                Content = "Order Placed for "+ current_session.customer_name,
                CloseButtonText = "Return to Cart"
            };
        }
    }
}
