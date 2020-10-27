using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Group5_GameStore.Startup))]
namespace Group5_GameStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
