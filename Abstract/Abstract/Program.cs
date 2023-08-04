using System;
namespace AbstractClass
{

    abstract class Language
    {

        // non-abstract method
        public void display()
        {
            Console.WriteLine("Non abstract method");
        }
    }

    // inheriting from abstract class
    class Program : Language
    {

        static void Main(string[] args)
        {

            // object of Program class
            Program obj = new Program();

            // access method of an abstract class
            obj.display();

            Console.ReadLine();
        }
    }
}