using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackerApplication.Startup))]
namespace TrackerApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
