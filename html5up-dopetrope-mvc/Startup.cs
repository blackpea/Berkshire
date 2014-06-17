using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using html5up_dopetrope_mvc.App_Start;

using Microsoft.Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace html5up_dopetrope_mvc
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}