using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeDir
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) return;

            DirectoryInfo fi = new DirectoryInfo(args[0]);
            if (fi.Exists) Console.Error.WriteLine("Directory already exists");
            else
            {
                Directory.CreateDirectory(args[0]);
                Console.WriteLine($"Created directory {args[0]}");
            }
            Console.ReadKey();
        }
    }
}
