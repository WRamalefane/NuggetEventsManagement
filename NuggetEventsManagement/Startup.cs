using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NuggetEventsManagement.Startup))]
namespace NuggetEventsManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
