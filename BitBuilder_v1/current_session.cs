using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace BitBuilder_v1
{
    class current_session
    {

        private current_session() 
        { }

        public static string emailid;
        public static string current_pass;
        public static string customer_id;
        public static string orderid;
        public static string customer_name;
        public static string customer_addr;
        public static string customer_cityid;
        public static string contact;




        public static void set_customer_details() //assuming customer id is set
        {
            DBconnection x1 = new DBconnection();
            DataTable cust_details = x1.Select("select * from Customer where CustomerID = " + customer_id);

            foreach (DataRow row in cust_details.Rows)
            {
                customer_name = row["CustomerName"].ToString();
                customer_addr = row["CustomerAddress"].ToString();
                customer_cityid = row["CityID"].ToString();
                contact = row["Contact"].ToString();

            }
        }


        public static void log_out_session()
        {
            customer_id = "";
            orderid = "" ;
            customer_name = "" ;
            customer_addr = "" ;
            customer_cityid = "" ;
            contact = "" ;
        }


        public static void FillDataGrid(DataTable table, DataGrid grid)
        {
            grid.Columns.Clear();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                grid.Columns.Add(new DataGridTextColumn()
                {
                    Header = table.Columns[i].ColumnName,
                    Binding = new Binding { Path = new PropertyPath("[" + i.ToString() + "]") }
                });
            }

            var collection = new ObservableCollection<object>();
            foreach (DataRow row in table.Rows)
            {
                collection.Add(row.ItemArray);
            }

            grid.ItemsSource = collection;
        }
    }


    class current_register
    {
        private current_register() { }


        public static string currentpass;
        public static string current_email;

    }

    class current_build
    {
        private current_build() { }

        public static float proc_price;
        public static float mobo_price;
        public static float gpu_price;
        public static float mem_price;
        public static float chassis_price;
        public static float storage_price;
        public static float psu_price;
    }
}
