namespace Lab5;

using System;

// Step 1 - Create a Base Class
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine(" The animal makes a sound. ");
    }
}

// Step 2 - Create Derived Classes

// Cat class inherits from Animal
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine(" The cat says meow. ");
    }
}

// Dog class inherits from Animal
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine(" The dog says: bow wow.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Demonstrating Runtime Polymorphism ---");

        // Step 3: Test in Main()

        Animal myAnimal = new Animal();
        myAnimal.animalSound(); // Calls the base Animal's animalSound()

        Animal myCat = new Cat();
        myCat.animalSound(); // Calls Cat's overridden animalSound() at runtime

        Animal myDog = new Dog();
        myDog.animalSound(); // Calls Dog's overridden animalSound() at runtime

        Console.WriteLine("\nThis demonstrates runetime polymorphism: " +
                          "even though 'myCat' and 'myDog' are referenced as 'Animal' types, " +
                          "the correct overridden method is called based on the actual object type at runtime.");
    }
}