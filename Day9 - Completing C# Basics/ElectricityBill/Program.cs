using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Electicity Bill Generation");
            Console.WriteLine("**************************");
            Console.WriteLine("Enter the number of consumers bill to be generated");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            Dictionary<Consumer, BillGeneration> d = new Dictionary<Consumer, BillGeneration>();

            Consumer cc = new Consumer();
            cc.enterConsumerDetails(n,i);

            Console.WriteLine("Bill Generated");
            
            Console.WriteLine();
            foreach(var data in d)
            {
                Console.WriteLine(data.Value.Bill_no);
                Console.WriteLine(data.Key.Consumer_no);
                Console.WriteLine(data.Key.Consumer_name);
                Console.WriteLine(data.Key.Total_units);
                Console.WriteLine(data.Value.Cost_per_unit);
                Console.WriteLine(data.Value.DueDate);
            }

            Console.Read();

        }
    }
}
