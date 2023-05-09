using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace AgentsWF.Models
{
    public class OrdersDetails
    {
        public int OrdersID { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }


        public void AddOrdersDetails(string connectionString, string NameProduct, int Quantity, int Price, int Total)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "INSERT INTO orders_details(order_id,name_product,quantity,price,total_price) VALUES ('" + Orders.i + "','" + NameProduct + "', '" + Quantity + "', " + Price + ", " + Total + ")";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
        }

        public void DeleteOrdersDetails(string connectionString, string NameProduct)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "Delete from orders_details Where order_id = '"+Orders.i+ "' and name_product='"+NameProduct+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
        }
    }
}
