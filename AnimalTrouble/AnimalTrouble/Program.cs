using System;

namespace OverrideQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Student("John Doe", 25, "C#/.NET");
            Console.WriteLine(mammal);
        }
    }

    abstract class Mammal
    {
        public override string ToString()
        {
            return "Mammel Instance: ";
        }
    }

    class Human : Mammal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    class Student : Human
    {
        public string Major { get; set; }
        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
        }
        public override string ToString()
        {
            return base.ToString() + $", Major: {Major}";
        }
    }
}