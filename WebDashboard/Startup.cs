using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDashboard.Startup))]
namespace WebDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
