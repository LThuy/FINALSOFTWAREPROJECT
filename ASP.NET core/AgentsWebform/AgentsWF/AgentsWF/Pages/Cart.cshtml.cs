using AgentsWF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgentsWF.Pages
{
    public class CartModel : PageModel
    {
        public string nametag = "";
        readonly IConfiguration _configuration;

        public List<CartManagement> carts = new List<CartManagement>();

       

        public string connectionString;

        public CartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            carts = GetPhoneList();
        }

        private List<CartManagement> GetPhoneList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<CartManagement> cartList = new List<CartManagement>();

            CartManagement cart = new CartManagement();

            cartList = cart.GetCarts(connectionString);

            return cartList;
        }
    }
}
