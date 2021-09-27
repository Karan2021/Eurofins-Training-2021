using System;

namespace FileHandlingTutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.Course Details\n2.Network Analyser\n");
            choice = Convert.ToInt32(Console.ReadLine());


            if (choice == 1)
            {
                int n;
                Console.WriteLine("Enter the Number of Courses");
                n = Convert.ToInt32(Console.ReadLine());
                FileHandling obj = new FileHandling();
                obj.WriteFile(n);
                Console.Read();
            }
            else if(choice==2)
            {
                FileHandling obj = new FileHandling();
                obj.ReadandWriteNetAn();
            }
        }
    }
}
