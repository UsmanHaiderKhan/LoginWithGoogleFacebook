using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginwithFacebookGoogle.Startup))]
namespace LoginwithFacebookGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
