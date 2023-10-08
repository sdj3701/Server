using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        static object _lock = new object();
        static SpinLock _lock2 = new SpinLock();

        static void Main(string[] args)
        {
            lock(_lock)
            {

            }

            bool lockTaken = false;
            try
            {

            }

            _lock2.Enter(ref lockTaken);

            _lock2.Exit();
        }
    }
}