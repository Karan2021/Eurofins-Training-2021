using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class WordWithNLetters
    {
        public static void PrintWordWithNLetters(int n, List<string> l)
        {
            Console.WriteLine("Words with "+n+" Letters");
            foreach(string ss in l)
            {
                if(ss.Length==n)
                {
                    Console.WriteLine(ss);
                }
            }
        }
    }
}
