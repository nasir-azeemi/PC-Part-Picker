using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
//using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static BitBuilder_v1.App;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BitBuilder_v1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool newuserflag = false;
        bool adminflag = false;
        string userid;
        DBconnection c1;

        //List<AppUsers> login_lst = new List<AppUsers>();
        public MainPage()
        {
            this.InitializeComponent();
            c1 = new DBconnection();

            //login_lst = ((App)Application.Current).UserLogin((App.Current as App).ConnectionString);

        }

         


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private  void signbttn_Click(object sender, RoutedEventArgs e)
        {
            DataTable login_table = c1.Select("select * from AppUser");
            
            if (newuserflag)
            {
                current_register.currentpass = passbox.Password;
                current_register.current_email = emailbox.Text;
                this.Frame.Navigate(typeof(registerform));
                return; 
            }


            foreach(DataRow row in login_table.Rows)
            {
                
                if (emailbox.Text == row["userid"].ToString() && passbox.Password.Equals(row["userpassword"].ToString()))
                {
                    userid = emailbox.Text;
                    System.Diagnostics.Debug.WriteLine(userid);


                    current_session.emailid = emailbox.Text;
                    current_session.current_pass = passbox.Password;
                    current_session.customer_id = row["CustomerID"].ToString();
                    current_session.set_customer_details();


                    if (row["isAdmin"].ToString() == "True")
                    {
                        this.Frame.Navigate(typeof(admin_dash));
                        return;
                    } 
                    else
                    {
                        this.Frame.Navigate(typeof(user_dash));
                        return;
                    }
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("unmatched");
                }


            }



            /*
            if (newuserflag && adminflag)
            {

                // Create the message dialog and set its content
                //var messageDialog = new MessageDialog("user cannot be both new user and admin");

                    // Show the message dialog
                    //await messageDialog.ShowAsync();
                
            }

            else if (newuserflag)
            {
                this.Frame.Navigate(typeof(registerform));
            }
            else if(adminflag)
            {
                this.Frame.Navigate(typeof(admin_dash));
            }

            else
            {
                this.Frame.Navigate(typeof(user_dash));
            }
            */
        }

        private void newuser_check_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    newuserflag = true;
                }
                else
                {
                    newuserflag = false;
                }
            }
        }

        private void adminToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    adminflag = true;
                }
                else
                {
                    adminflag = false;
                }
            }
        }
    }

    public class users
    {
        public string id;
        public string pass;

        public users (string id1, string pass1)
        {
            this.id = id1;
            this.pass = pass1;
        }
    }


}
