using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBuilder_v1
{
    class Cart
    {
        private Cart() { }

        public static List<CartItem> cart_collection = new List<CartItem>();



        public static void add_to_cart(string id, bool isbuild = false)
        {
            CartItem x1 = new CartItem();

            if(isbuild)
            {
                x1.buildid = id;
                x1.is_build = true;
                x1.set_itemname();
            }
            else
            {
                x1.itemid = id;
                x1.is_build = false;
                x1.set_itemname();

            }

            cart_collection.Add(x1);
        }


        public static void clear_cart()
        {
            cart_collection.Clear();
        }
    }


    class CartItem
    {
        public string itemid { get; set; }
        public string buildid { get; set; }
        public string itemname { get; set; }
        public bool is_build { get; set; }
        public CartItem() 
        {
            itemid = "";
            buildid = "";
            is_build = false;
        }

        public void set_itemname()
        {
            DBconnection c1 = new DBconnection();


            if (!is_build)
            {
                DataTable d1 = c1.Select("select * from Products where ProductID = " + itemid);

                foreach (DataRow row in d1.Rows)
                {
                    if (itemid == row["ProductID"].ToString())
                    {
                        itemname = row["ProductName"].ToString();
                        break;
                    }
                }
            }
            else
            {
                DataTable d1 = c1.Select("select * from Builds where BuildID = " + buildid);


                foreach (DataRow row in d1.Rows)
                {
                    if (buildid == row["BuildID"].ToString())
                    {
                        itemname = row["BuildDescription"].ToString();
                        break;
                    }
                }

            }
        }

        


        

    }
}
