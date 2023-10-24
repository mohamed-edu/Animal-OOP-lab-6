using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_OOP
{
    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string color, int age, int leg, string breed)
        {
            Name = name;
            HasTail = true;
            Color = color;
            Leg = leg;
            Age = age;
            Breed = breed;


        }


        public override void makeSound()
        {
            Console.WriteLine(Name + " " + "barks");
        }

        public void like()
        {
            Console.WriteLine(Name + " likes to play with boll");
        }
        public override void printinfo()
        {
            Console.WriteLine("Animal Name: " + Name);
            Console.WriteLine("Animal Breed: " + Breed);
            Console.WriteLine("Animal tail status: " + HasTail);
            Console.WriteLine(Name + " " + "color:" + " " + Color);
            Console.WriteLine(Name + " " + "has" + " " + Leg + " " + "legs");
            Console.WriteLine(Name + " " + "age is: " + Age);

        }
    }
   
}
