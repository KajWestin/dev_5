using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dev_5.Web.Startup))]
namespace dev_5.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
