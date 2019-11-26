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
    public sealed partial class admin_dash : Page
    {
        public admin_dash()
        {
            this.InitializeComponent();
        }

        private void add_bttn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(add_prod));
        }

        private void update_pricebtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void view_orderbtn_Click(object sender, RoutedEventArgs e)
        {

        }


        private void update_orderbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void update_productbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(update_prod));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Processor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mobo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gpu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void chassis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void storage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void psu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void memory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void displays_Click(object sender, RoutedEventArgs e)
        {

        }

        private void periph_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
