using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week16Chatter.Startup))]
namespace Week16Chatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
