using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExceptions
{
    class Circle:Shape22
    {
        int radius = 10;

        public double Area()
        {
            return 3.17 * radius * radius;
        }

        public double Volume()
        {
            return 0;
        }
    }
}
