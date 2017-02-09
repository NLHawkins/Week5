using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day4_UserAuth.Startup))]
namespace Day4_UserAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
