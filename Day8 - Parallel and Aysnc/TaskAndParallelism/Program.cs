using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAndParallelism
{
    class Program
    {
        //private static int totalSize;

        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now;

            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //SEQUENTIAL
            Console.WriteLine("Sequential Thread...");
            DateTime d1 = DateTime.Now;
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even number : " + i + ", Thread : " + Thread.CurrentThread.ManagedThreadId);

                Thread.Sleep(500);
            }
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));
            DateTime d2 = DateTime.Now;
            TimeSpan interval = d2 - d1;
            Console.WriteLine("Total Number of Seconds: {0}", interval.TotalSeconds);
            Console.WriteLine();



            //PARALLEL THREAD
            Console.WriteLine("Parallel Thread...");
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));
            Parallel.For(1, n, i =>
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even number : " + i + ", Thread : " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(500);
            });
            Console.WriteLine(aDate.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.Read();



            //if (!Directory.Exists(@"C:\Users\Manoj Kumar A\Desktop"))
            //{
            //    Console.WriteLine("The directory does not exist.");
            //    return;
            //}

            //String[] files = Directory.GetFiles(@"C:\Users\Manoj Kumar A\Desktop");
            //Parallel.For(0, files.Length, index => {
            //    FileInfo fi = new FileInfo(files[index]); long size = fi.Length; Interlocked.Add(ref totalSize, (int)size);
            //    Console.WriteLine("Thread : " + Thread.CurrentThread.ManagedThreadId);
            //}); 
            //Console.WriteLine("Directory '{0}':", @"C:\Users\Manoj Kumar A\Desktop\LearnGithub");
            //Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);

            Console.Read();
        }
    }
}
