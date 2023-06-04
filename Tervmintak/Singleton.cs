using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tervmintak
{
    internal class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }

    internal class ThreadSafeSingleton
    {
        private ThreadSafeSingleton()
        {

        }

        private static readonly object _lock = new object();

        private static ThreadSafeSingleton _instance;

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
