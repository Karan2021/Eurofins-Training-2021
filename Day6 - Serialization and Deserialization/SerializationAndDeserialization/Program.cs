using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.createPerson();
            p.deserialization();

            Console.WriteLine();

            p.createPersonXML();
            p.deserializationXML();

            Console.Read();
        }
    }
}
