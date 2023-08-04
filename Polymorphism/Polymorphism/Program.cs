using System;
namespace Polymorphism
{
    class Program
    {
        public void greet()
        {
            Console.WriteLine("Hello");
        }

        public void greet1( string name) {
            Console.WriteLine("Hello" + name);
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.greet();
            p1.greet1("Timmy");

        }
    }
}