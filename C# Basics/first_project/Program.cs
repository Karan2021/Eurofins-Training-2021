/* using System;
namespace First
{
    class program
    {
      static void Main(string[] args)
       {
         Console.WriteLine("karan");
         Console.ReadKey();
       }
    }
} 

using System;
namespace Myprogram
{
    class program
        {
          static void Main(string[] args)
    {
        string name = "karan";
        Console.WriteLine(name);
    }

}
}


using System;
namespace typecasting
{
    class program
    {
        static void Main(string[] args)
        {
            double value1 = 10.5;
            int value2 = (int)value1;
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.ReadKey();
        }
    }
}



using System;
namespace typeconv
{
    class program
    {
        static void Main(string[] args)
        {
            int value1 = 20;
            double value2 = 20.25;
            bool value3 = false;
            Console.WriteLine(Convert.ToString(value1));
            Console.WriteLine(Convert.ToInt32(value2));
            Console.WriteLine(Convert.ToString(value3));
        }
    }
}



using System;
namespace project
{
    class project
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName :");
            string UserName = Console.ReadLine();
            Console.WriteLine("User Name is " +UserName);
        }
    }
}



using System;
namespace proj
{
    class neww
    {
        static void Main(String[] args)
        {
            int a = 25;
            int b = 45;
            a += 5;
            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(a>25 && a<40);
            Console.WriteLine(!(a > 25 && a < 40));
            Console.WriteLine(a < 25 || a > 20);
        }
    }
}


using System;
namespace project
{
    class str
    {
        static void Main(string[] args)
        {
            string text = "karan";
            string text1 = "s";
            string name = $"my name is {text} {text1}";
            Console.WriteLine("length of text is : " + text.Length);
            Console.WriteLine(name);
            Console.WriteLine(text[1]);
            int pos = name.IndexOf("s");
            string lastname = name.Substring(pos);
            Console.WriteLine(lastname);
        }

    }
}


using System;
namespace file
{
    class practice
    {
        static void Main(string[] args)
        {
            int a = 20;
            string result = (a > 10)? "correct" : "not correct";
            Console.WriteLine(result);

        }
    }
}


using System;
namespace day
{
    class stats
    {
        static void Main(string[] args)
        {
            int day = 2;
          
            while (day<3)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("monday");
                        break;
                    case 2:
                        Console.WriteLine("Friday");
                        day ++;
                        break;
                }
            }
        }
    }
}



using System;
namespace dowhile
{
    class test
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);



            {
                for (i = 7; i < 10; i++)
                {
                    if (i == 8)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }

            
        }
    }
}


using System;
namespace sample
{
    class test
    {
        static void Main(string[] args)
        {
            string[] names = { "karan", "sonu" };
            Console.WriteLine(names.Length);

            int[] numbers = {1,2,9,33,0};
            
            foreach (string i in names)
                Console.WriteLine(i);
            
                Array.Sort(names);
            foreach (string i in names)
                Console.WriteLine(i);

                Array.Sort(numbers);
            foreach (int i in numbers)
                Console.WriteLine(i);
        }
    }
}



using System;
using System.Linq;
namespace array_concept
{
    class arr
    {
        static void Main(string[] args)
        {
            int[] num = { 11, 2, 43, 12, 99 };
            Console.WriteLine(num.Max());
            Console.WriteLine(num.Min());
            Console.WriteLine(num.Sum());
        }
    }
}



using System;
namespace methods
{
    class methods
    {
        static void NewMethod(string name)
        {
            Console.WriteLine(name + " hello world");
        }

        static int MyMethod(int x, int y)
        {
            return x + y;
        }
        static double MyMethod(double x, double y)
        {
            return x + y;
        }
            static void Main(string[] args)
            {
                NewMethod("karan");

                int new1 = MyMethod(10, 20);
                double new2 = MyMethod(2.5, 6.5);
                Console.WriteLine("int value :" + new1);
                Console.WriteLine("double value :" + new2);
            }

        }
    }


using System;
namespace classes
{
    class Car
    {
        string model;
        string color;
        int year;
        static void Main(string[] args)
        {
            Car kia = new Car();
            kia.model = "Suv";
            kia.color = "red";
            kia.year = 2021;

            Car benz = new Car();
            benz.model = "Sedan";
            benz.color = "black";
            benz.year = 2019;

            Console.WriteLine(kia.model);
            Console.WriteLine(kia.color);
            Console.WriteLine(benz.model);
        }
    }

}


using System;
namespace classes
    {
        class Car
{
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }

    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
    }
}
}



using System;
namespace person
{
    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "sample";
            Console.WriteLine(myObj.Name);
        }
    }
}




using System;
namespace person
{
    class Vehicle  // base class (parent) 
    {
        public string brand = "Tata";   // Vehicle field
        public void drive()             // Vehicle method 
        {
            Console.WriteLine("sample data");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "nexon";  // Car field
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the action() method (From the Vehicle class) on the myCar object
            myCar.drive();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}


using System;
namespace polymorph
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}



using System;
namespace interface1
{ 
    interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class Demo : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some other text...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Demo myObj = new Demo();
        myObj.myMethod();
        myObj.myOtherMethod();
    }
}
}




using System;

namespace MyApplication
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}



using System;
using System.IO;
namespace textfile
{
    class myprogram
    {
        static void Main(string[] args)
        {
            string text = "hello world";
            File.WriteAllText("sample.txt", text);

            string text1 = File.ReadAllText("sample.txt");
            Console.WriteLine(text1);
        }
    }
}



using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}



using System;

namespace MyApplication
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            checkAge(17);
        }
    }
}

*/