using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangfire02.Startup))]
namespace Hangfire02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
