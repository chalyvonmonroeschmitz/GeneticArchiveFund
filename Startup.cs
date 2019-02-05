using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gaffgc_App.Startup))]
namespace Gaffgc_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
