using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmlFormsTemplate.Startup))]
namespace HtmlFormsTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
