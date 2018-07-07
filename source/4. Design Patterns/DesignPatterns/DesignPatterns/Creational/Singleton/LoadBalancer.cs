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
        }

        public static LoadBalancer Instance()
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
    }
}
