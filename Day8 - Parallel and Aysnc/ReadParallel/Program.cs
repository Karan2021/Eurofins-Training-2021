using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\Day8 - Parallel and Aysnc\files\networklog.txt";
            FileOperations op = new FileOperations();
          
            List<string> l = new List<string>();
            l = op.ReadFile(filePath);

            Parallel.ForEach(l, line =>
            {
                Console.WriteLine(line+ "Thread : " + Thread.CurrentThread.ManagedThreadId+"\n");
                Thread.Sleep(500);
            });

            Console.Read();
        }
    }
}
