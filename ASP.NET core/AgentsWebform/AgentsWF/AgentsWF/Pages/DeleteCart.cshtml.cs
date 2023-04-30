using AgentsWF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace AgentsWF.Pages
{
    public class DeleteCartModel : PageModel
    {
        public string Name = "";
        public string nametag = "";

        readonly IConfiguration _configuration;

        public string connectionString;

        public DeleteCartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            Name = Request.Query["name"];

            connectionString = _configuration.GetConnectionString("ConnectionString");

            CartManagement c = new CartManagement();

            c.DeleteCart(connectionString, Name);

            Response.Redirect("./Cart");
        }
    }
}
