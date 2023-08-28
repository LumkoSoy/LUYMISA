using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LUYMISA.UI.Startup))]
namespace LUYMISA.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
