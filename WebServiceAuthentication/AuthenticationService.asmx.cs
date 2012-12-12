using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Security;

namespace WebServiceAuthentication
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://grocerystore.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]   
    public class AuthenticationService : System.Web.Services.WebService
    {

        [WebMethod] //validates a user       
        public Boolean isValidCredentials(string Username, string Password)
        {
            //accesses membership and checks for credential validility
            if (Membership.ValidateUser(Username, Password) == true) return true;

            return false;

        }
    }
}