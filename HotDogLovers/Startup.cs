using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotDogLovers.Startup))]
namespace HotDogLovers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
