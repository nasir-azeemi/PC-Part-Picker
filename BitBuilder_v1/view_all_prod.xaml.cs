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
    public sealed partial class view_all_prod : Page
    {
        DBconnection c1;
        DataTable d1;
        public view_all_prod()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            d1 = c1.Select("select * from Products");

            foreach(DataColumn col in d1.Columns)
            {
                System.Diagnostics.Debug.WriteLine((col.ToString()));
            }

            current_session.FillDataGrid(d1, prod_datagrid);           
            
            //prod_datagrid.CanUserAddRows = false;

        }

        private void returnbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
