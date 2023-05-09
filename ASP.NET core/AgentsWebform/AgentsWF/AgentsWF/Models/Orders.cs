using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AgentsWF.Models
{
    public class Orders
    {
        public int OrdersID { get; set; }
        public string AgentName { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public int Total { get; set; }
        public static int i = 8;

        public List<Orders> GetOrders(string connectionString, string AgentName)
        {

            List<Orders> orderList = new List<Orders>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select id, name_agent, date, status, total  from orders where name_agent = '" + AgentName + "'";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Orders order = new Orders();
                    order.OrdersID = Convert.ToInt32(dr["id"]);
                    order.AgentName = dr["name_agent"].ToString();
                    order.Date = dr["date"].ToString();
                    order.Status = dr["status"].ToString();
                    order.Total = Convert.ToInt32(dr["total"]);

                    orderList.Add(order);
                }

            }

            return orderList;
        }

        public void AddOrders(string connectionString, string AgentName, string Date, int Total)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "INSERT INTO orders VALUES ('" + AgentName + "','" + Date + "', 'Pending', '" + Total + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
            i++;
        }
    }
}
