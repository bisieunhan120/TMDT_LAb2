using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_Lab2.Startup))]
namespace TMDT_Lab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
