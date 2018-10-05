using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfirmEmail.Startup))]
namespace ConfirmEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
