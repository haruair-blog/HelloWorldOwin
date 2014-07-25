using System;
using Microsoft.Owin.Hosting;

namespace HelloWorldOwin
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var url = "http://localhost:9000";
			using (WebApp.Start<Startup> (url)) {
				Console.WriteLine (url);
				Console.WriteLine ("Press enter to quit.");
				Console.ReadLine ();
			}
		}
	}
}
