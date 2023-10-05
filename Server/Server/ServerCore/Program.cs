﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        static void MianThread(object state)
        {
            for(int i =0; i < 5; i++) 
                Console.WriteLine("Hellow Thread!");
        }
        static void Main(string[] args)
        {
            

            ThreadPool.SetMinThreads(1, 1);
            ThreadPool.SetMaxThreads(5, 5);

            for (int i =0;i < 4;i++)
            {
                Task t = new Task(() => { while (true) { } }, TaskCreationOptions.LongRunning);
                t.Start();
            }
            

            //for (int i =0;i < 4;i++)
            //    ThreadPool.QueueUserWorkItem((obj) => { while (true) { } });    

            ThreadPool.QueueUserWorkItem(MianThread);

            //Thread t = new Thread(MianThread);
            //t.Name = "Test Thread";
            //t.IsBackground = true;
            //t.Start();

            //Console.WriteLine("Waiting for Thread!");

            //t.Join();
            //Console.WriteLine("Hello, World!");
            while(true)
            {

            }
        }
    }
}