using System;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin;

namespace HelloWorldOwin
{
	public class MySecondMiddleware : OwinMiddleware
	{
		public MySecondMiddleware (OwinMiddleware next) : base(next)
		{
		}

		public override async Task Invoke(IOwinContext context){
			context.Response.Write ("<header><h1>It works</h1></header>");
			await Next.Invoke (context);
			context.Response.Write ("<footer><a href=\"http://localhost:9000\">http://localhost:9000</a></footer>");
		}
	}
}

