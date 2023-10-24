using Animal_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Animal_OOP
{

    class Chihuahua : Dog
    {
        public int Size { get; set; }
        public Chihuahua(string name, string color, int age, int leg, string breed, int size)
        : base(name, color, age, leg, breed)
        {
            Name = name;
            HasTail = true;
            Color = color;
            Leg = leg;
            Age = age;
            Breed = breed;
            Name = name;
            Size = size;
        }

        public override void makeSound()
        {
            Console.WriteLine(Name + " " + "barks");
        }
        public void funFact()
        {
            Console.WriteLine(Breed + "s" + " " + "are the most aggressive dog");
        }
        public override void printinfo()
        {
            Console.WriteLine("Animal name: " + Name);
            Console.WriteLine("Animal Breed: " + Breed);
            Console.WriteLine("Animal tail status: " + HasTail);
            Console.WriteLine(Name + " " + "color:" + " " + Color);
            Console.WriteLine(Name + " " + "has" + " " + Leg + " " + "legs");
            Console.WriteLine(Name + " " + "age is: " + Age);
            Console.WriteLine("Size: " + Size);

        }



    }
}
