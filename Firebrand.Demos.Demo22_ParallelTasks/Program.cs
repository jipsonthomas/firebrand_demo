using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Firebrand.Demos.Demo22_ParallelTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t1 = new Task(()=>ExecuteLongRunningJob(1, 3000));
            //t1.Start();
            //var t2 = new Task(() => ExecuteLongRunningJob(2, 6000));
            //t2.Start();
            //var t3 = new Task(() => ExecuteLongRunningJob(3, 4000));
            //t3.Start();
            //var t4 = new Task(() => ExecuteLongRunningJob(4, 7000));
            //t4.Start();
            //var t5 = new Task(() => ExecuteLongRunningJob(5, 2000));
            //t5.Start();

            //// Option to wait for task ending to execute
            //Task.WaitAll(t1, t2, t3, t4, t5);

            var intList = new List<int> { 1, 30, 23, 2, 23, 3, 4, 556, 6453, 6565, 43, 6554, 77, 3, 3, 4, 556, 6453, 6565, 43, 6554, 77, 3, 3, 4, 556, 6453, 6565, 43, 6554, 77, 3, 3, 4, 556, 6453, 6565, 43, 6554, 77, 55678, 45 };
            Parallel.For  (0,intList.Count, (i)=> Console.WriteLine(intList[i]));
            Parallel.ForEach(intList, (i) => Console.WriteLine(i));

            //ExecuteLongRunningJob(2, 6000);
            //ExecuteLongRunningJob(3, 4000);
            //ExecuteLongRunningJob(4, 2000);
            //ExecuteLongRunningJob(5, 7000);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static void ExecuteLongRunningJob(int id, int sleepTime)
        {
            Console.WriteLine("Task {0} is begining ", id);
                Thread.Sleep(sleepTime);
            Console.WriteLine("Task {0} is ending ", id);

        }

    }
}
