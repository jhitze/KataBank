using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KataBankOCR.Startup))]
namespace KataBankOCR
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
