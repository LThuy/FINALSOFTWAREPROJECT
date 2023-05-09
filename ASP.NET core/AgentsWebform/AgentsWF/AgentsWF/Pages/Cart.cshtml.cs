using AgentsWF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;

namespace AgentsWF.Pages
{
    public class CartModel : PageModel
    {
        public string nametag = "";
        public string Image = "";
        public string Name = "";
        public int Quantity;
        public int Price;
        public int Total;
        readonly IConfiguration _configuration;

        public List<CartManagement> carts = new List<CartManagement>();

       

        public string connectionString;

        public CartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            nametag = Request.Query["Username"];
            carts = GetCartList();
        }

        private List<CartManagement> GetCartList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            if (Request.Query.ContainsKey("image") && Request.Query.ContainsKey("name") && Request.Query.ContainsKey("quantity") && Request.Query.ContainsKey("price"))
            {
                // Retrieve values from query parameters
                Image = Request.Query["image"].ToString();
                Name = Request.Query["name"].ToString();
                Quantity = Convert.ToInt32(Request.Query["quantity"]);
                Price = Convert.ToInt32(Request.Query["price"]);
                Total = Quantity * Price;

                List<CartManagement> cartList = new List<CartManagement>();

                CartManagement cart = new CartManagement();
                OrdersDetails ODT = new OrdersDetails();
                cart.ManageCart(connectionString, nametag, Image, Name, Quantity, Price);
                ODT.AddOrdersDetails(connectionString, Name, Quantity, Price, Total);
                cartList = cart.GetCarts(connectionString, nametag);
                return cartList;
            }
            else
            {
                List<CartManagement> cartList = new List<CartManagement>();
                CartManagement cart = new CartManagement();
                cartList = cart.GetCarts(connectionString, nametag);
                return cartList;
            }                           
        }
    }
}
