using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TesteGenesis.Startup))]

namespace TesteGenesis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }    
    }
}
