using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimAbstr
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name)
            : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Мяу!");
        }
    }
    class Dog : Animal
    {
        int age;
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, int age)
            : base(name)
        {
            this.age = age;
        }

        public override void Say()
        {
            Console.WriteLine("Гав! Мой возраст - {0}", age);
        }
    }
}
