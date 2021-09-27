using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class Consumer
    {
        private string consumer_no, consumer_name;
        int total_units;

        public string Consumer_no { get => consumer_no; set => consumer_no = value; }
        public string Consumer_name { get => consumer_name; set => consumer_name = value; }
        public int Total_units { get => total_units; set => total_units = value; }

        public void enterConsumerDetails(int n, int i)
        {
            while (n != 0)
            {
                Console.WriteLine("Enter Details of Customer " + i++);
                Consumer c = new Consumer();
                Console.WriteLine("Enter Consumer Number");
                c.Consumer_no = Console.ReadLine();
                Console.WriteLine("Enter Consumer Name");
                c.Consumer_name = Console.ReadLine();
                Console.WriteLine("Enter Total Units Consumed by Customer");
                c.Total_units = Convert.ToInt32(Console.ReadLine());

                BillGeneration b = new BillGeneration();
                Console.WriteLine("Enter cost per unit");
                double cost_per_unit = Convert.ToDouble(Console.ReadLine());
                b.Cost_per_unit = cost_per_unit;
                b.generateBill(c, b);

                Console.WriteLine();
                n--;
            }
        }
    }
}
