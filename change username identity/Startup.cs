using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(change_username_identity.Startup))]
namespace change_username_identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
