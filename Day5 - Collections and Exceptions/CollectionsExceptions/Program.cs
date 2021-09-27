using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.EvenNumbers\n2.WordWithNLetters\n3.Area\n4.PolymorphismTest");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                List<int> l = new List<int>();
                Console.WriteLine("Enter n");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    l.Add(i);
                }

                EvenNumbersList.evenNumbers(l);

            }
            else if(choice==2)
            {
                List<string> ll = new List<string>();
                Console.WriteLine("How Many words do you want to enter");
                int n = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<n;i++)
                {
                    string input = Console.ReadLine();
                    ll.Add(input);
                }
                Console.WriteLine("How many letter words do you want?");
                int nn = Convert.ToInt32(Console.ReadLine());
                WordWithNLetters.PrintWordWithNLetters(nn,ll);

            }
            else if(choice==3)
            {
                Rectangle r = new Rectangle("blue",10,20);
                r.displayArea();
            }
            else if(choice==4)
            {
                Cube ss = new Cube();
                Console.WriteLine("Cube dimensions...");
                Console.WriteLine("Area of Cube is = " + ss.Area());
                Console.WriteLine("Volume of Cube is = " + ss.Volume());

                Circle cc = new Circle();
                Console.WriteLine("Circle dimensions...");

                Console.WriteLine("Area of Circle is = " + cc.Area());
                Console.WriteLine("Volume of Circle is = " + cc.Volume());
            }

            Console.Read();

            

        }
    }
}
