using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void WriteEvent(string message) {
            string ApplicationName = "Facebook";
            System.Diagnostics.EventLog.WriteEntry(
                ApplicationName,
                message,
                System.Diagnostics.EventLogEntryType.Error);

        }
    }
}
 
 









