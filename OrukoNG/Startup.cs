using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrukoNG.Startup))]
namespace OrukoNG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
