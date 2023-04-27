using AgentsWF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;


namespace AgentsWF.Pages
{
    public class AddToCartModel : PageModel
    {
        readonly IConfiguration _configuration;

        public string nametag = "";

        public string connectionString;

        public AddToCartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult Action([FromBody] JObject data)
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            string image = (string)data["image"];
            string name = (string)data["name"];
            string quantity = (string)data["quantity"];
            string price = (string)data["price"];

            CartManagement cm = new CartManagement();
            cm.ManageCart(connectionString, image, name, quantity, price);

            return null;



            // Do something with the data


        }
    }
}
