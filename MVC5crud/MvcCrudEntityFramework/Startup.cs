using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCrudEntityFramework.Startup))]
namespace MvcCrudEntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
