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
        readonly IConfiguration _configuration;

        public List<CartManagement> carts = new List<CartManagement>();

       

        public string connectionString;

        public CartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
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

                List<CartManagement> cartList = new List<CartManagement>();

                CartManagement cart = new CartManagement();
                cart.ManageCart(connectionString, Image, Name, Quantity, Price);
                cartList = cart.GetCarts(connectionString);
                return cartList;
            }
            else
            {
                List<CartManagement> cartList = new List<CartManagement>();
                CartManagement cart = new CartManagement();
                cartList = cart.GetCarts(connectionString);
                return cartList;
            }                           
        }
    }
}
