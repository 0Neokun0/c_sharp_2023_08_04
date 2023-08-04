using System;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Noah", 4);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Eat();
            dog.Play();
        }
    }
}