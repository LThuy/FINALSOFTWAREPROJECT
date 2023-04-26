using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AgentsWF.Models
{
    public class Phone
    {
        public int PhoneID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Memory { get; set; }
        public int Camera { get; set; }
        public int   Pin { get; set; }
        public string Image { get; set; }

        public List<Phone> GetPhones(string connectionString)
        {

            List<Phone> phoneList = new List<Phone>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select phone_name, price, memory, camera, pin, image  from Products";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Phone phone = new Phone();
                    phone.Name = dr["phone_name"].ToString();
                    phone.Price = Convert.ToInt32(dr["price"]);
                    phone.Memory = Convert.ToInt32(dr["memory"]);
                    phone.Camera = Convert.ToInt32(dr["camera"]);
                    phone.Pin = Convert.ToInt32(dr["pin"]);
                    phone.Image = dr["image"].ToString();

                    phoneList.Add(phone);
                }

            }

            return phoneList;
        }
    }
}
