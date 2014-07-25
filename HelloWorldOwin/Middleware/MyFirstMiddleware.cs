using System;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin;

namespace HelloWorldOwin
{
	public class MyFirstMiddleware : OwinMiddleware
	{
		public MyFirstMiddleware (OwinMiddleware next) : base(next)
		{
		}

		public override async Task Invoke(IOwinContext context){
			context.Response.Write ("<!doctype html><html><body>");
			await Next.Invoke (context);
			context.Response.Write ("</body></html>");
		}
	}
}

