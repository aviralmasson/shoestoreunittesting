using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shoestore.Startup))]
namespace Shoestore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
