using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalProjectHSN.Startup))]
namespace HospitalProjectHSN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
