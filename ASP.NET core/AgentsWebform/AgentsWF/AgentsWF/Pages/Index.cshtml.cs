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

        public List<Phone> phones = new List<Phone>();

        public string connectionString;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            phones = GetPhoneList();
        }

        private List<Phone> GetPhoneList()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<Phone> phoneList = new List<Phone>();

            Phone phone = new Phone();

            phoneList = phone.GetPhones(connectionString);

            return phoneList;
        }
    }
}