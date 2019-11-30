using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder_v1
{
    class current_session
    {

        private current_session() 
        { }

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

    }
}
