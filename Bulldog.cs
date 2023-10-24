using Animal_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_OOP
{
    internal class Bulldog : Dog
    {
        public string Personality { get; set; }
        public Bulldog(string name, string color, int age, int leg, string breed, string personality)
        : base(name, color, age, leg, breed)
        {
            Name = name;
            HasTail = true;
            Color = color;
            Leg = leg;
            Age = age;
            Breed = breed;
            Name = name;
            Personality = personality;
        }
        public override void makeSound()
        {
            Console.WriteLine(Name + " " + "barks alot");
        }
        public void stenght()
        {
            Console.WriteLine(Name+"s" + " " + "are strong");
        }
        public override void printinfo()
        {
            Console.WriteLine("Animal name: " + Name);
            Console.WriteLine("Animal Breed: " + Breed);
            Console.WriteLine("Animal tail status: " + HasTail);
            Console.WriteLine(Name + " " + "color:" + " " + Color);
            Console.WriteLine(Name + " " + "has" + " " + Leg + " " + "legs");
            Console.WriteLine(Name + " " + "age is: " + Age);
            Console.WriteLine("personality: " + Personality);

        }

    }
}
