using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Infrastructure
{
    public static class IdentityHelpers
    {
        public static string GetUserName(string id)
        {
            ApplicationUserManager mgr = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            return mgr.FindByIdAsync(id).Result.UserName;
        }
    }

}
