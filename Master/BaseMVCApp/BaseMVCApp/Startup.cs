using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseMVCApp.Startup))]
namespace BaseMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
