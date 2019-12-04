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
    public sealed partial class product_search : Page
    {
        DBconnection c1;
        DataTable d1, d2;

        

        public product_search()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            d2 = c1.Select("select * from ProductType");
        }

        private void close_bttn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));
        }

        private void categ_box_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < d2.Rows.Count; i++)
            {
                categ_box.Items.Add(d2.Rows[i]["TypeName"]);
            }
        }

        private void cart_add_bttn_Copy_Click(object sender, RoutedEventArgs e)
        {
            string x = buildid_box.Text;
            Cart.add_to_cart(x);
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            if(categ_box.SelectedIndex != -1)
            {
                d1 = c1.Select("select ProductID, TypeName as 'Product Type', BrandName, ProductName as 'Product Name', isAvailable as 'Available', UnitPrice as 'Price'"
                    + " from Products, ProductType, Brand "
                    + "where Products.TypeID = ProductType.TypeID and Products.BrandID = Brand.BrandID and TypeName = '"+ categ_box.SelectedItem.ToString()+"'");


                current_session.FillDataGrid(d1, search_grid);
            }
            else
            {
                string x = prod_namebox.Text;
                d1 = c1.Select("select ProductID, TypeName as 'Product Type', BrandName, ProductName as 'Product Name', isAvailable as 'Available', UnitPrice as 'Price'"
                    + " from Products, ProductType, Brand "
                    + "where Products.TypeID = ProductType.TypeID and Products.BrandID = Brand.BrandID and ProductName like '%" + x + "%'");
                
                current_session.FillDataGrid(d1, search_grid);


            }
        }
    }
}
