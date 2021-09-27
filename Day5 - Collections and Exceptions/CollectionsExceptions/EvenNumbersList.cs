using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class EvenNumbersList
    {
        public static void evenNumbers(List<int> l)
        {
            Console.WriteLine("Even Numbers from 1 to "+l.Count);
            foreach (int number in l)
            {
                if(number%2==0)
                    Console.Write(number+" ");
            }
            Console.WriteLine();
        }
    }
}
