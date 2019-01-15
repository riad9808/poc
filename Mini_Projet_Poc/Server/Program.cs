using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using wcf;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ServiceHost host = new ServiceHost(typeof(Service1)))
			{
				host.Open();
				
				Console.WriteLine("Service1 Started");

				using (ServiceHost host1 = new ServiceHost(typeof(Service2)))
				{
					host1.Open();
					Console.WriteLine("Service2 Started");
					Console.ReadLine();
				}
			}
		}
	}
}
