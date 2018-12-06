using Nancy;
using Nancy.Extensions;
using System;

namespace NancyFxMicroservice
{
	public class HelloWorldModule : NancyModule
	{
		public HelloWorldModule():base("api")
		{
			Get["/values"] = parameters => new string[] { "Hello", "World", "...!" };
			Get["/values/{id}"] = parameters => (parameters.id.Value == "1") ? "Hello" : (parameters.id.Value == "2") ? "World" : (parameters.id.Value == "3") ? "...!" : "No world found... ;-)";
			Post["/values"] = _ => 
			{
				var value = Context.Request.Body.AsString();
				Console.WriteLine($"The received value is:{value}");
				return HttpStatusCode.OK;
			};
		}
	}
}