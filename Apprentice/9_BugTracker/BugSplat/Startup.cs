using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BugSleuth.Startup))]
namespace BugSleuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
