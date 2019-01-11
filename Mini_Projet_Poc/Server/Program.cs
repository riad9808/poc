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
			ServiceHost host = new ServiceHost(typeof(Service2));
			host.Open();
			Console.WriteLine("Service Hosted Sucessfully");
			Console.Read();
		}
	}
}
