using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Animal_OOP
{
    internal class Cat:Animal
    {
        public string Character { get; set; }
        public Cat(string name, string color, int age, int leg, string character)
        {
            Name = name;
            HasTail = true;
            Color = color;
            Age = age;
            Leg = leg;
            Character = character;
        }
        public override void makeSound()
        {
            Console.WriteLine(Name + " " + "is a Cat and it meows") ;
        }
        public void hate()
        {
            Console.WriteLine(Name + " " +  "hates water");
        }
        public override void printinfo()
        {
            Console.WriteLine("Animal name: " + Name);
            Console.WriteLine("Animal tail status: " + HasTail);
            Console.WriteLine(Name + " " + "color:" + " " + Color);
            Console.WriteLine(Name + " " + "has" + " " + Leg + " " + "legs");
            Console.WriteLine(Name + " " + "age is: " + Age);
            Console.WriteLine("character status: " + Character);

        }
    }
}
