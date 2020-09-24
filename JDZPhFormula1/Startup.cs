using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JDZPhFormula1.Startup))]
namespace JDZPhFormula1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
