using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Singleton: A class of which only a single instance can exist */
namespace DesignPatterns.Creational.Singleton
{
    public class LoadBalancer
    {
        // 1.
        private static LoadBalancer _instance;
        // 2.
        private static object syncLock = new object();

        protected LoadBalancer()
        {
            // 6.
            // List of available servers

            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null) // 3.
            {
                lock (syncLock) // 4.
                {
                    if (_instance == null) // 5.
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Simple, but effective random load balancer
        public string Server
        {
            get

            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
