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
    public sealed partial class accdetails : Page
    {
        DBconnection c1;

        public accdetails()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            emailbox.Text = current_session.emailid;
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            void update_email()
            {
                if (!(emailbox.Text.Equals(current_session.emailid)))
                {
                    c1.Inserts("update AppUser set userid = '" + emailbox.Text + "' where CustomerID = " + current_session.customer_id.ToString());
                }
            }

            if (newpass_box.Text != "")
            {
                if (oldpass_box.Text == current_session.current_pass)
                {
                    c1.Inserts("update AppUser set userpassword = '" + newpass_box.Text + "' where CustomerID = " + current_session.customer_id.ToString());
                }
                update_email();

            }
            else
            {
                update_email();
            }


            this.Frame.Navigate(typeof(user_dash));
            return;
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));
            return;
        }
    }
}
