using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_MVC5_Bootstrap3_3_1_LESS.Startup))]
namespace ASP.NET_MVC5_Bootstrap3_3_1_LESS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
