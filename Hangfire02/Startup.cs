using System.Web;
using Hangfire;
using Hangfire02.Filters;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangfire02.Startup))]
namespace Hangfire02
{
    public partial class Startup
    {
        
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection");
            ConfigureAuth(app);
            app.UseHangfireDashboard("/webjob", new DashboardOptions()
            {
                Authorization = new []{ new DashboardAuth() },
                AppPath = VirtualPathUtility.ToAbsolute("~")
            });
            app.UseHangfireServer();
            
        }
    }
}
