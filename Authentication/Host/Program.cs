using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Portal.Service1)))
            using (ServiceHost host1 = new ServiceHost(typeof(Question.Service1)))
            using (ServiceHost host2 = new ServiceHost(typeof(AssignmentFiles.Service1)))
            using (ServiceHost host3 = new ServiceHost(typeof(Assignment.Service1)))
            {
                host.Open();
                host1.Open();
                host2.Open();
                host3.Open();
                Console.WriteLine("Host started.");
                Console.ReadLine();
            }

        }
    }
}
