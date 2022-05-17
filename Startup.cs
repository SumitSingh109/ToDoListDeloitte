using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListDeloitte.Startup))]
namespace ToDoListDeloitte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
