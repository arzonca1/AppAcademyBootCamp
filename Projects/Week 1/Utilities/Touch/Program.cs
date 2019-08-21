using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touch
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) return;

            FileInfo fi = new FileInfo(args[0]);
            if (fi.Exists) fi.LastWriteTime = DateTime.Now;
            else using (File.Create(args[0]));

        }
    }
}
