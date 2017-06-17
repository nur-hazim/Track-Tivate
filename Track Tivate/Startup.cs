using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Track_Tivate.Startup))]
namespace Track_Tivate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
