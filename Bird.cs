using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_OOP
{
    internal class Bird:Animal
    {
        public string Specie { get; set; }

        public Bird(string name, string color, int leg, int age, string specie)
        {
            Name = name;
            HasTail = false;
            Color = color;
            Age = age;
            Leg = leg;
            Specie = specie;
        }

      
        public override void makeSound()
        {
            Console.WriteLine(Name + " " + "hoots");
        }
        public void fly()
        {
            Console.WriteLine(Name + " " + "flys alot");
        }
        public override void printinfo()
        {
            Console.WriteLine("spicie:  " + Specie);
            Console.WriteLine("Animal name: " + Name);
            Console.WriteLine("Animal tail status: " + HasTail);
            Console.WriteLine(Name + " " + "color:" + " " + Color);
            Console.WriteLine(Name + " " + "has" + " " + Leg + " " + "legs");
            Console.WriteLine(Name + " " + "age is: " + Age);

        }
    }
}
