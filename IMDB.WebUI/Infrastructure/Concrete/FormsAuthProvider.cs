using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMDB.WebUI.Infrastructure.Abstract;
using System.Web.Security;

namespace IMDB.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);   //this is the method which we wanted to keep out of the controller for less coupling 
            if (result)
            {
                FormsAuthentication.SetAuthCookie(username, false);
            }
            return result;
        }
    }
}