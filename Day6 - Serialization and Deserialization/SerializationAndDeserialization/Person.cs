using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationAndDeserialization
{
    [Serializable]
    public class Person
    {
        public string name;
        public int age;
        private City city;

       

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void createPerson()
        {
            Person p = new Person();
            p.Name = "Manoj";
            p.Age = 22;
            p.city = new City();
            p.city.City_name = "Bengaluru";
            p.city.City_population = 10000;
            
            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\Day6 - Serialization and Deserialization\files\person.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs,p);
            fs.Close();


        }

        public void createPersonXML()
        {
            Person p = new Person();
            p.Name = "Manoj";
            p.Age = 22;
            p.city = new City();
            p.city.City_name = "Bengaluru";
            p.city.City_population = 10000;

            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Stream fs = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\Day6 - Serialization and Deserialization\files\personXML.txt", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, p);
            fs.Close();
        }

        public void deserialization()
        {
            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\Day6 - Serialization and Deserialization\files\person.txt", FileMode.Open, FileAccess.Read);
            var pp = (Person)binaryFormatter.Deserialize(fs);
            Console.WriteLine(pp.name);
            Console.WriteLine(pp.age);
            Console.WriteLine(pp.city.city_name);
            Console.WriteLine(pp.city.city_population);
        }

        public void deserializationXML()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Stream fs = new FileStream(@"C:\Users\Manoj Kumar A\Desktop\EurofinsTraining\Day6 - Serialization and Deserialization\files\personXML.txt", FileMode.Open, FileAccess.Read);
            var pp = (Person)xs.Deserialize(fs);
            Console.WriteLine(pp.name);
            Console.WriteLine(pp.age);
        }

    }
}
