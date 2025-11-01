using System;

namespace OOPS
{
    // Parent class
    class Animal
    {
        public string Name;

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Child class inheriting from Animal
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    class InheritanceExample
    {
        public static void Run()
        {
            Dog dog = new Dog();
            dog.Name = "Bruno";
            dog.Eat();    // Inherited method
            dog.Bark();   // Child class method
        }
    }
}
