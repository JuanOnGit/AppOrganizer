using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppOrganizer.Startup))]
namespace AppOrganizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
