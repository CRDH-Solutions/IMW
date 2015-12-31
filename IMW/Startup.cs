using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IMW.Startup))]
namespace IMW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
