using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebrand.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = 1200;
            var dir = Directory.GetCurrentDirectory();
            // Create File
            var FileName = dir + "\\mylordmygod.txt";
            //File.Create(FileName);
            // Write by recreating
           // File.WriteAllText(FileName, "My Lord !! My God !! Praise The Lord!!!");
           // Write by appending
            File.AppendAllText(FileName, "My Lord !! My God !! Praise The Lord!!!");
            var info = new FileInfo(FileName);
            Console.WriteLine("File Length {0}", info.Length);
            foreach (var file in Directory.GetFiles(dir))
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
            

        }
    }
}
