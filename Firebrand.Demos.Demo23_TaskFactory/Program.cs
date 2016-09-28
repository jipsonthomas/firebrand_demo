using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Firebrand.Demos.Demo23_TaskFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => ExecuteLongRunningJob(1, 3000, source.Token))
                .ContinueWith((prevTask) => ExecuteAnotherLongRunningJob(7, 3000, source.Token));
                var t2 = Task.Factory.StartNew(() => ExecuteLongRunningJob(2, 6000, source.Token))
                    .ContinueWith((prevTask) => ExecuteAnotherLongRunningJob(8, 3000, source.Token)).ContinueWith((prevTask) => ExecuteLongRunningJob(9, 3000, source.Token));
                var t3 = Task.Factory.StartNew(() => ExecuteLongRunningJob(3, 4000, source.Token))
                    .ContinueWith((prevTask) => ExecuteAnotherLongRunningJob(10, 3000, source.Token));
                var t4 = Task.Factory.StartNew(() => ExecuteLongRunningJob(4, 7000, source.Token))
                    .ContinueWith((prevTask) => ExecuteAnotherLongRunningJob(11, 3000, source.Token));
                var t5 = Task.Factory.StartNew(() => ExecuteLongRunningJob(5, 2000, source.Token))
                    .ContinueWith((prevTask) => ExecuteAnotherLongRunningJob(12, 3000, source.Token));
                Thread.Sleep(3000);
                source.Cancel();
                // Option to wait for task ending to execute
                Task.WaitAll(t1, t2, t3, t4, t5);
            }
            catch(Exception e)
            {
                Console.WriteLine("Cancellation Requested!!!");
            }
            
           
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void ExecuteLongRunningJob(int id, int sleepTime,CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation Requested!!!");
                token.ThrowIfCancellationRequested();
            }
            else
            {
                Console.WriteLine("Job1 - Task {0} is begining ", id);
                Thread.Sleep(sleepTime);
                Console.WriteLine("Job 1 - Task {0} is ending ", id);
            }
            

        }
        static void ExecuteAnotherLongRunningJob(int id, int sleepTime,CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation Requested!!!");
                token.ThrowIfCancellationRequested();
            }
            else
            {
                Console.WriteLine("Job2 {0} is begining ", id);
                Thread.Sleep(sleepTime);
                Console.WriteLine("Job2 {0} is ending ", id);
            }
            

        }
    }
}
