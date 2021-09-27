using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadParallel
{
    class FileOperations
    {
        public List<string> ReadFile(string filePath)
        {
            FileStream fsr = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsr);

            Console.WriteLine("Reading file...");
            List<string> l = new List<string>();

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                l.Add(line);
            }
            return l;
        }
    }
}
