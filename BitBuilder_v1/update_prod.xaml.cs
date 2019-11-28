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
    public sealed partial class update_prod : Page
    {
        public update_prod()
        {
            this.InitializeComponent();
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            // set the initial SelectedItem
            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "processor")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
            /*ContentFrame.Navigate(typeof(add_proc));



            ContentFrame.Navigated += On_Navigated;*/
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
                        this.ContentFrame.Navigate(typeof(add_proc));
                        break;

                    case "motherboard":
                        this.ContentFrame.Navigate(typeof(add_mobo));
                        break;

                    case "gpu":
                        this.ContentFrame.Navigate(typeof(add_gpu));
                        break;

                    case "storage":
                        this.ContentFrame.Navigate(typeof(add_storage));
                        break;

                    case "memory":
                        this.ContentFrame.Navigate(typeof(add_memory));
                        break;
                    case "chassis":
                        this.ContentFrame.Navigate(typeof(upd_chassis));
                        break;
                    case "psu":
                        this.ContentFrame.Navigate(typeof(add_psu));
                        break;
                    case "peripheral":
                        this.ContentFrame.Navigate(typeof(user_dash));
                        break;
                    case "display":
                        this.ContentFrame.Navigate(typeof(upd_display));
                        break;
                }
            }

        }

        private void NavView_BackRequested(NavigationView sender,
                                   NavigationViewBackRequestedEventArgs args)
        {
            On_BackRequested();
        }


        private bool On_BackRequested()
        {
            /* if (!ContentFrame.CanGoBack)
                 return false;

             // Don't go back if the nav pane is overlayed.
             if (NavView.IsPaneOpen &&
                 (NavView.DisplayMode == NavigationViewDisplayMode.Compact ||
                  NavView.DisplayMode == NavigationViewDisplayMode.Minimal))
                 return false;

             ContentFrame.GoBack();
             return true;*/
            frame1.Navigate(typeof(admin_dash));


            return true;
        }

        /*    private void On_Navigated(object sender, NavigationEventArgs e)
            {
                NavView.IsBackEnabled = ContentFrame.CanGoBack;

                if (ContentFrame.SourcePageType != null)
                {
                    var item = _pages.FirstOrDefault(p => p.Page == e.SourcePageType);

                    NavView.SelectedItem = NavView.MenuItems
                        .OfType<NavigationViewItem>()
                        .First(n => n.Tag.Equals(item.Tag));

                    NavView.Header =
                        ((NavigationViewItem)NavView.SelectedItem)?.Content?.ToString();
                }
            }

            private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
            {
                ("processor", typeof(add_proc)),
                ("motherboard", typeof(add_mobo)),
                ("psu", typeof(add_proc)),
                ("gpu", typeof(add_gpu)),
                ("chassis", typeof(add_gpu)),
                ("storage", typeof(add_storage)),
                ("memory", typeof(add_memory)),
                ("peripherals", typeof(add_memory)),
                ("display", typeof(add_memory)),
            };*/
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {

        }
    }
}

