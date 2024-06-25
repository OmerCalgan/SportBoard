using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartup(typeof(SportBoard.Startup))]
namespace SportBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        private void ConfigureAuth(IAppBuilder app)
        {
            throw new NotImplementedException();
        }
    }
}
