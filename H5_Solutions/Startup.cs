using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(H5_Solutions.Startup))]
namespace H5_Solutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
