namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils.Animate("Welcome to the Zoo!", 50);
            ConsoleUtils.Animate("All the animals are hungry - but will be fed...", 50);

            Cat cat = new Cat();
            Dog dog = new Dog(10);

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                animal.Eat(new Bread(1));
                animal.Eat(new Dog(1));
                Console.WriteLine(animal);
            }
        }
    }

    interface IEdible
    {
        public double Weight { get; }
    }

    class Bread : IEdible
    {
        public Bread(double weight)
        {
            Weight = weight;
        }
    
        public double Weight { get; }
    }

    abstract class Animal : object, IEdible
    {
        public Animal(double weight)
        {
            MakeSound();
            Weight = weight;
        }

        public double Weight { get; protected set; }

        public virtual void Eat(IEdible snack)
        {
            Weight += snack.Weight;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, Weight: {Weight}";
        }

        public abstract void MakeSound();
    }

    class Cat : Animal
    {
        public Cat() : base(4.5)
        {
            Weight++;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Dog : Animal
    {
        public Dog(double weight) : base (weight)
        {
        }
        public override void Eat(IEdible snack)
        {
            Weight += snack.Weight * 0.8;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public static class ConsoleUtils
    {
        public static void Animate(string text, int delay)
        {
            foreach (var c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}