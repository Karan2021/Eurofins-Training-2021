using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter a number num1 :  ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number num2 :  ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition is = " + (num1 + num2));

            Console.WriteLine("Subtraction is = " + (num1 - num2));

            Console.WriteLine("Multiplication is = " + (num1 * num2));

            Console.WriteLine("Division is = " + (num1 / num2));

            Console.Read();
        }
    }
}
