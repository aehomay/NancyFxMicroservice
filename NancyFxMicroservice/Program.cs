using System;
using Nancy.Hosting.Self;

namespace NancyFxMicroservice
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var host = new NancyHost(new Uri("http://localhost:9000")))
			{
				host.Start();
				Console.WriteLine("Running on http://localhost:9000");
				Console.ReadLine();
			}
		}
	}
}