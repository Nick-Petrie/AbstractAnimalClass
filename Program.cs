abstract class Animal
{
    // Property
    public abstract string Name { get; set; }
    // Methods
    public abstract string Describe();
    public string whatAmI()
    {
        return "I am an animal";
    }
}

class Cat : Animal
{
    public string Breed { get; set; }
    public int Age { get; set; }

    public override string Name { get; set; }

    public override string Describe()
    {
        return $"I am a {Breed} cat, I am {Age} years old, and my name is {Name}!";
    }
    public Cat()
    {
        Name = "Caesar";
        Breed = "American Curl";
        Age = 16;
    }

    public Cat(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat();

        Cat cat2 = new Cat("Zelda", "Main Coon", 18);

        Console.WriteLine(cat1.Describe());
        Console.WriteLine(cat2.Describe());
    }
}