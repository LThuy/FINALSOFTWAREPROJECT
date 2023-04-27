using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using AgentsWF.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace AgentsWF.Pages
{

    public class IndexModel : PageModel
    {
        readonly IConfiguration _configuration;

        public Account accdb = new Account();

        public string nametag = "";

        public string connectionString;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            nametag = Request.Query["Username"];
        }

        public void OnPost()
        {
            Account acc = new Account();

            acc.Username = Request.Form["Username"];
            acc.Password = Request.Form["Password"];

            connectionString = _configuration.GetConnectionString("ConnectionString");

            acc.checkAccount(connectionString, acc);
            if (acc.checkAccount(connectionString, acc))
            {
                Response.Redirect("./Homepage?username=" + acc.Username);
            }
            else
            {
                Response.Redirect("./Index");
            }

        }


    }
}