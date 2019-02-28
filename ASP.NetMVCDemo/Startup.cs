using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NetMVCDemo.Startup))]
namespace ASP.NetMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
