using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AgentsWF.Models
{
    public class CartManagement
    {
        public string Image { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }



        public List<CartManagement> GetCarts(string connectionString)
        {

            List<CartManagement> cartList = new List<CartManagement>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select image, name, quantity, price from Carts";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    CartManagement cart = new CartManagement();
                    cart.Image = dr["image"].ToString();
                    cart.Name = dr["name"].ToString();
                    cart.Quantity = Convert.ToInt32(dr["quantity"]);
                    cart.Price = Convert.ToInt32(dr["price"]);
                    cartList.Add(cart);
                }

            }
            con.Close();

            return cartList;
        }


        public void ManageCart(string connectionString, string image, string name, int quantity, int price)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "INSERT INTO Carts VALUES ('" + image + "', '" + name + "', " + quantity + ", " + price + ")";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();       
            con.Close();         
        }

        public void DeleteCart(string connectionString,  string name)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "DELETE FROM Carts WHERE name= '" + name + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
        }
    }
}
