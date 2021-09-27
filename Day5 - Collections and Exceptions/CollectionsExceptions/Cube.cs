using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class Cube:Shape22
    {
        static int x = 10;
       
        public double Area()
        {
            return 6 * x * x;
        }

        public double Volume()
        {
            return x * x * x;
        }


    }
}
