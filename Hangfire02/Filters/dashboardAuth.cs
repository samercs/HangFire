using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hangfire.Dashboard;
using Microsoft.Owin;

namespace Hangfire02.Filters
{
    public class DashboardAuth: IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            var owin = new OwinContext(context.GetOwinEnvironment());
            return owin.Authentication.User.Identity.IsAuthenticated;
        }
    }
}