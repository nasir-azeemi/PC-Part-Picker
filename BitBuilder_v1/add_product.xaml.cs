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
    public sealed partial class add_prod : Page
    {
        public add_prod()
        {
            this.InitializeComponent();
        }

        #region NavigationView event handlers
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            // set the initial SelectedItem
          foreach (NavigationViewItemBase item in NavView.MenuItems)
                {
                    if (item is NavigationViewItem && item.Tag.ToString() == "Processor")
                    {
                        NavView.SelectedItem = item;
                        break;
                    }
                }
                ContentFrame.Navigate(typeof(add_proc));
            }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
        }

       
        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            
            TextBlock ItemContent = args.InvokedItem as TextBlock;
            if (ItemContent != null)
            {
                switch (ItemContent.Tag)
                {
                    case "processor":
                        ContentFrame.Navigate(typeof(add_proc));
                        break;

                    case "motherboard":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;

                    case "gpu":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;

                    case "storage":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;

                    case "memory":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;
                    case "chassis":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;
                    case "psu":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;
                    case "peripheral":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;
                    case "display":
                        ContentFrame.Navigate(typeof(user_dash));
                        break;
                }
            }
            
        }
        #endregion

        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {

        }
    }
}
