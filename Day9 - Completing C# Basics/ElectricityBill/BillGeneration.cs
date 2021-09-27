using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class BillGeneration
    {
        private int bill_no;
        private string consumer_no;
        private double cost_per_unit, total_amount;
        private DateTime dueDate;

        public int Bill_no { get => bill_no; set => bill_no = value; }
        public string Consumer_no { get => consumer_no; set => consumer_no = value; }
        public double Cost_per_unit { get => cost_per_unit; set => cost_per_unit = value; }
        public double Total_amount { get => total_amount; set => total_amount = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }

        public void generateBill(Consumer c,BillGeneration b)
        {
            string fileName = c.Consumer_no;
            FileStream fs = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\Day9 - Completing C# Basics\files\"+fileName+".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            DateTime today = DateTime.Today;
            b.DueDate=today.AddDays(1).AddMonths(1).AddDays(-1);

            sw.WriteLine("Electricity Bill");
            sw.WriteLine("****************");

            System.Random random = new System.Random();
            b.Bill_no = random.Next(1000000);
            sw.WriteLine("Bill no: "+b.Bill_no);
            sw.WriteLine("Consumer Number: "+c.Consumer_no);
            sw.WriteLine("Consumer Name: "+c.Consumer_name);
            sw.WriteLine("Total Units: "+c.Total_units);
            sw.WriteLine("Cost Per Unit: "+b.Cost_per_unit);
            b.Total_amount= c.Total_units * b.Cost_per_unit;
            sw.WriteLine("Total Amount: "+b.Total_amount);
            sw.WriteLine("Due Date: "+b.DueDate.ToShortDateString());
            sw.WriteLine("****Thank you****");

            sw.WriteLine();
            

            sw.Close();
            fs.Close();

        }
    }
}
