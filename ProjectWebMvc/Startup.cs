using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectWebMvc.Startup))]
namespace ProjectWebMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}