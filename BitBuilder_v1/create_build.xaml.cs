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
    public sealed partial class create_build : Page
    {
        DBconnection c1;
        string ffactor;
        string socket;
        float curr_price;
        string temp_price;


        DataTable mobo_tb, proc_tb, gpu_tb, psu_tb, memory_tb, storage_tb, chassis_tb, temp_tb;

        public create_build()
        {
            this.InitializeComponent();
            c1 = new DBconnection();
            mobo_tb = new DataTable();
            chassis_tb = new DataTable();

            ffactor = ""; socket = "";
            curr_price = 0;

            proc_tb = c1.Select("select * from Processor p1, Products p2 where p1.ProductID = p2.ProductID");
            
            mobo_tb = c1.Select("select * from Motherboard m1, Products p2 where m1.ProductID = p2.ProductID");

            gpu_tb = c1.Select("select * from GPU g1, Products p2 where g1.ProductID = p2.ProductID");

            memory_tb = c1.Select("select * from Memory m2, Products p2 where m2.ProductID = p2.ProductID");


            //chassis_tb = c1.Select("select * from Chassis ch1, Products p2 where ch1.ProductID = p2.ProductID");



            for (int i = 0; i < proc_tb.Rows.Count; i++)
            {
                proc_box.Items.Add(proc_tb.Rows[i]["ProductName"]);
            }
            
            for (int i = 0; i < mobo_tb.Rows.Count; i++)
            {
                mobo_box.Items.Add(mobo_tb.Rows[i]["ProductName"]);
            }

        }


        private void mobo_box_reloaded()
        {
            mobo_box.Items.Clear();
            mobo_tb.Clear();
            mobo_tb = c1.Select("select * from Motherboard m1, Products p2 where m1.ProductID = p2.ProductID and SocketID = '" + socket + "'");

            for (int i = 0; i < mobo_tb.Rows.Count; i++)
            {
                mobo_box.Items.Add(mobo_tb.Rows[i]["ProductName"]);
            }
        }

        private void upd_price()
        {
            curr_price = current_build.proc_price + current_build.mobo_price + current_build.mem_price +
                current_build.gpu_price + current_build.chassis_price + current_build.psu_price + current_build.storage_price;

            cost_valuebox.Text = curr_price.ToString();
  
        }

        private void mobo_box_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void proc_box_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void gpu_box_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void chassis_box_reloaded()
        {
            chassis_box.Items.Clear();
            chassis_tb.Clear();
            chassis_tb = c1.Select("select * from Chassis m1, Products p2 where m1.ProductID = p2.ProductID and FormFactorID = '" + ffactor + "'");

            for (int i = 0; i < chassis_tb.Rows.Count; i++)
            {
                chassis_box.Items.Add(chassis_tb.Rows[i]["ProductName"]);
            }
        }

        private void mobo_box_Loaded_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void mobo_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < mobo_tb.Rows.Count; i++)
            {
                if (mobo_tb.Rows[i]["ProductName"].ToString() == mobo_box.SelectedItem.ToString())
                {
                    current_build.mobo_price = float.Parse(mobo_tb.Rows[i]["UnitPrice"].ToString());
                    ffactor = mobo_tb.Rows[i]["FormFactorID"].ToString();
                    break;
                }
            }
            upd_price();
            chassis_box_reloaded();

        }

        private void gpu_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gpu_tb.Rows.Count; i++)
            {
                if (gpu_tb.Rows[i]["ProductName"].ToString() == gpu_box.SelectedItem.ToString())
                {
                    current_build.gpu_price = float.Parse(gpu_tb.Rows[i]["UnitPrice"].ToString());
                    break;
                }
            }
            upd_price();
        }

        private void memory_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < memory_tb.Rows.Count; i++)
            {
                if (memory_tb.Rows[i]["ProductName"].ToString() == memory_box.SelectedItem.ToString())
                {
                    current_build.mem_price = float.Parse(memory_tb.Rows[i]["UnitPrice"].ToString());
                    break;
                }
            }
            upd_price();
        }

        private void chassis_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < chassis_tb.Rows.Count; i++)
            {
                if (chassis_tb.Rows[i]["ProductName"].ToString() == chassis_box.SelectedItem.ToString())
                {
                    current_build.chassis_price = float.Parse(chassis_tb.Rows[i]["UnitPrice"].ToString());
                    break;
                }
            }
            upd_price();
        }

        private void psu_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < psu_tb.Rows.Count; i++)
            {
                if (psu_tb.Rows[i]["ProductName"].ToString() == psu_box.SelectedItem.ToString())
                {
                    current_build.psu_price = float.Parse(psu_tb.Rows[i]["UnitPrice"].ToString());
                    break;
                }
            }
            upd_price();
        }

        private void storage_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < storage_tb.Rows.Count; i++)
            {
                if (storage_tb.Rows[i]["ProductName"].ToString() == storage_box.SelectedItem.ToString())
                {
                    current_build.storage_price = float.Parse(storage_tb.Rows[i]["UnitPrice"].ToString());
                    break;
                }
            }
            upd_price();
        }

        private void proc_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < proc_tb.Rows.Count; i++)
            {
               if (proc_tb.Rows[i]["ProductName"].ToString() == proc_box.SelectedItem.ToString())
                {
                    socket = proc_tb.Rows[i]["SocketID"].ToString();
                    current_build.proc_price = float.Parse(proc_tb.Rows[i]["UnitPrice"].ToString());
                    break;
                }
            }
            upd_price();
            mobo_box_reloaded();


        }

        private void memory_box_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void chassis_box_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void psu_box_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void storage_box_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void create_btn_Click(object sender, RoutedEventArgs e)
        {
            if (memory_box.Text != "" && proc_box.Text != "" && mobo_box.Text !="" && storage_box.Text!="" && psu_box.Text!="" && chassis_box.Text!="" && gpu_box.Text !="")
            {
                c1.Inserts("insert into builds(unitprice,builddescription) values(" + curr_price.ToString() + ",'" + proc_box.Text + "|" + mobo_box.Text + "|" + memory_box.Text + "|" + gpu_box.Text + "|" + storage_box.Text + "|" + chassis_box.Text + "|" + psu_box.Text + "'");
                
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + memory_box.Text + "'),(select max(buildid) from builds)");
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + proc_box.Text + "'),(select max(buildid) from builds)");
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + mobo_box.Text + "'),(select max(buildid) from builds)");
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + storage_box.Text + "'),(select max(buildid) from builds)");
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + psu_box.Text + "'),(select max(buildid) from builds)");
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + chassis_box.Text + "'),(select max(buildid) from builds)");
                c1.Inserts("insert into builditems(productid,buildid) values((select productid from products where productname like '" + gpu_box.Text + "'),(select max(buildid) from builds)");
            }
            else
            {
                ContentDialog errorDialog = new ContentDialog
                {
                    Title = "Missing Fields",
                    Content = "You must select each component to create a build",
                    CloseButtonText = "Return to Build"
                };
            }
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(user_dash));
            return;
        }
    }
}
