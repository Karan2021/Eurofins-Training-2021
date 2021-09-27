using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHandlingTutorial
{
    class FileHandling
    {
        public string WriteFile(int n)
        {
            FileStream fs = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\EurofinsTraining\Day2\Files\courseDetails.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Course Details");
            sw.WriteLine("**************");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Register Number");
                String reg_no = Console.ReadLine();
                Console.WriteLine("Enter Course Name");
                String course_name = Console.ReadLine();
                Console.WriteLine("Enter course_title");
                String course_title = Console.ReadLine();

                sw.WriteLine("Regno : " + reg_no);
                sw.WriteLine("course : " + course_name);
                sw.WriteLine("title : " + course_title);
                sw.WriteLine();
            }

            sw.Close();
            fs.Close();
            return "File created";
        }

        public string ReadandWriteNetAn()
        {
  
            FileStream fsr = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\EurofinsTraining\Day2\Files\NetworkAnalyserDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsr);

            Console.WriteLine("Mobile Network performance");
            Console.WriteLine("***************************");
            Console.WriteLine("Source      Destination      Date     call - status");

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line.Contains(":"))
                {
                    string[] net = line.Split(':');
                    Console.Write(net[1] + "    ");
                }
                else
                    Console.WriteLine();
            }

            sr.Close();
            fsr.Close();
            return "Read success";
        }
    }
}
