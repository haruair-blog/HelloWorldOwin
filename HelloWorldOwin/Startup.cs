using System;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(HelloWorldOwin.Startup))]

namespace HelloWorldOwin
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.Use (typeof(HelloWorldOwin.MyFirstMiddleware));
			app.Use (typeof(HelloWorldOwin.MySecondMiddleware));

			app.Run (context => {
				return context.Response.WriteAsync("<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>");
			});
		}
	}
}
