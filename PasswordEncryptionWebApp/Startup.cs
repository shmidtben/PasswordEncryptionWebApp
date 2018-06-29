using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PasswordEncryptionWebApp.Startup))]
namespace PasswordEncryptionWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
