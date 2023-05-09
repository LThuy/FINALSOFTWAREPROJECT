using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using AgentsWF.Models;

namespace AgentsWF.Pages
{
    public class orderHistoryModel : PageModel
    {
        readonly IConfiguration _configuration;

        public List<Orders> orders = new List<Orders>();

        public string nametag = "";

        public string connectionString;

        public orderHistoryModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            nametag = Request.Query["Username"]; 
            orders = GetOrderList();
        }

       

        private List<Orders> GetOrderList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");
            string AgentName = Request.Query["Username"];

            List<Orders> orderList = new List<Orders>();

            Orders order = new Orders();

            orderList = order.GetOrders(connectionString, AgentName);

            return orderList;
        }
    }
}
