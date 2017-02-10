using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_Specflow_Webdriver.Data
{
    public class UserData

    {

        public string UserType { get; set; }
        public bool SelectedUserType { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
