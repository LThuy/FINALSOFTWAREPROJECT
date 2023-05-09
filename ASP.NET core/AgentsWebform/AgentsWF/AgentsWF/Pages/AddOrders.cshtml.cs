using AgentsWF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgentsWF.Pages
{
    public class AddOrdersModel : PageModel
    {
        public string nametag = "";
        public string date = "";
        public int total;

        readonly IConfiguration _configuration;

        public string connectionString;

        public AddOrdersModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            AddOrders();
        }

        public void AddOrders()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            nametag = Request.Query["Username"];
            date = Request.Query["date"];
            total = Convert.ToInt32(Request.Query["total"]);
            Orders OD = new Orders();
            OD.AddOrders(connectionString, nametag, date, total);
            Response.Redirect("https://sandbox.vnpayment.vn/tryitnow/Home/CreateOrder");            
        }
    }
}
