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
    public sealed partial class upd_price : Page
    {
        public upd_price()
        {
            this.InitializeComponent();
        }

        private void curr_priceBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void upd_bttn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));
        }

        private void cancel_bttn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(admin_dash));

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
